using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public abstract class ServicoEntidades<TEntity>(
    DbContext dbContext)
    : IServicoEntidades<TEntity> where TEntity : Entidade
{
    protected DbContext DbContext { get; } = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

    public virtual void Criar(TEntity entidade)
        => DbContext.Add(entidade ?? throw new ArgumentNullException(nameof(entidade)));

    public virtual void CriarVarios(IEnumerable<TEntity> entidades)
        => DbContext.Set<TEntity>().AddRange(entidades);

    public virtual void Editar(TEntity entidade)
        => DbContext.Update(entidade ?? throw new ArgumentNullException(nameof(entidade)));

    public virtual void EditarVarios(IEnumerable<TEntity> entidades)
        => DbContext.UpdateRange(entidades);

    public virtual void ExcluirPeloId(long id)
        => DbContext.Set<TEntity>().Remove(ObterPorId(id) ?? throw new InvalidOperationException("Entidade não encontrada"));

    public virtual TEntity? ObterPorId(long id, bool usarRastreamento = false)
        => dbContext.Set<TEntity>().PrimeiroOuPadrao(entidade => entidade.Id == id, usarRastreamento);

    public virtual IEnumerable<TEntity> ObterLista()
        => DbContext.Set<TEntity>().ObterLista();

    public virtual void DescartarAlteracoes()
        => DbContext.ChangeTracker.Clear();

    public virtual void SalvarAlteracoes()
        => DbContext.SaveChanges();

    public virtual bool Contem()
        => DbContext.Set<TEntity>()
        .AsNoTracking()
        .Select(entidade => entidade.Id)
        .Any();

    public virtual IEnumerable<ItemLista<long>> ObterListaItens()
        => DbContext.Set<TEntity>()
            .AsNoTracking()
            .Select(ConverterEntidadeParaLista())
            .ObterLista();

    protected virtual Expression<Func<TEntity, ItemLista<long>>> ConverterEntidadeParaLista()
        => entidade => new ItemLista<long>
        {
            Item = entidade.Id,
            Descricao = entidade.Id.ToString()
        };
}