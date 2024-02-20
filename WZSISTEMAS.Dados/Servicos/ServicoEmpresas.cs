using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoEmpresas(DbContext dbContext, IValidator<Empresa> validacao)
    : ServicoEntidades<Empresa>(dbContext), IServicoEmpresas
{
    private readonly IValidator<Empresa> validacao = validacao ?? throw new ArgumentNullException(nameof(validacao));

    protected override Expression<Func<Empresa, ItemLista<long>>> ConverterEntidadeParaLista()
        => empresa => new ItemLista<long>()
        {
            Item = empresa.Id,
            Descricao = empresa.RazaoSocial_CNJP()
        };

    public virtual IEnumerable<Empresa> ListarPorRazaoSocial(string razaoSocial)
        => DbContext.Set<Empresa>()
            .AsNoTracking()
            .Where(x => x.RazaoSocial.Contains(razaoSocial))
            .ToList();

    public virtual Empresa? ObterPorCNPJOuCodigoReferencia(string cNPJOuCodigoReferencia)
        => DbContext.Set<Empresa>()
            .AsNoTracking()
            .FirstOrDefault(x => x.CNPJ == cNPJOuCodigoReferencia || x.CodigoReferencia == cNPJOuCodigoReferencia);

    public virtual ValidationResult Validar(Empresa entidade)
        => validacao.Validate(entidade);
}