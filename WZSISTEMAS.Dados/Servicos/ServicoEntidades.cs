using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public abstract class ServicoEntidades<TEntidade>(
    DbContext dbContext)
    : IServicoEntidades<TEntidade> where TEntidade : Entidade
{
    protected DbContext DbContext { get; } = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

    public virtual void Criar(TEntidade entidade)
        => DbContext.Add(entidade ?? throw new ArgumentNullException(nameof(entidade)));

    public virtual void CriarVarios(IEnumerable<TEntidade> entidades)
        => DbContext.Set<TEntidade>().AddRange(entidades);

    public virtual void Editar(TEntidade entidade)
        => DbContext.Update(entidade ?? throw new ArgumentNullException(nameof(entidade)));

    public virtual void EditarVarios(IEnumerable<TEntidade> entidades)
        => DbContext.UpdateRange(entidades);

    public virtual void ExcluirPeloId(long id)
        => DbContext.Set<TEntidade>().Remove(ObterPorId(id) ?? throw new InvalidOperationException("Entidade não encontrada"));

    public virtual TEntidade? ObterPorId(long id, bool usarRastreamento = false)
        => dbContext.Set<TEntidade>().PrimeiroOuPadrao(entidade => entidade.Id == id, usarRastreamento);

    public virtual IEnumerable<TEntidade> ObterLista()
        => DbContext.Set<TEntidade>().ObterLista();

    public virtual IEnumerable<ItemLista<long>> ConverterParaListaItem(IEnumerable<TEntidade> entidades)
        => entidades
            .AsQueryable()
            .Select(ConverterEntidadeParaLista())
            .ToList();

    public virtual void DescartarAlteracoes()
        => DbContext.ChangeTracker.Clear();

    public virtual void SalvarAlteracoes()
        => DbContext.SaveChanges();

    public virtual bool Contem()
        => DbContext.Set<TEntidade>()
        .AsNoTracking()
        .Select(entidade => entidade.Id)
        .Any();

    public virtual IEnumerable<ItemLista<long>> ObterListaItens(params long[] idsIgnorados)
        => DbContext.Set<TEntidade>()
            .AsNoTracking()
            .FiltrarIdsIgnorados(idsIgnorados)
            .Select(ConverterEntidadeParaLista())
            .ObterLista();

    protected virtual Expression<Func<TEntidade, ItemLista<long>>> ConverterEntidadeParaLista()
        => entidade => new ItemLista<long>
        {
            Item = entidade.Id,
            Descricao = entidade.Id.ToString()
        };
}