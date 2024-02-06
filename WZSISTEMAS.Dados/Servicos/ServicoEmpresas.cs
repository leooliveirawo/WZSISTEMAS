using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoEmpresas(DbContext dbContext, IValidator<Empresa> validacao)
    : ServicoEntidades<Empresa>(dbContext), IServicoEmpresas
{
    private readonly IValidator<Empresa> validacao = validacao ?? throw new ArgumentNullException(nameof(validacao));

    public virtual IEnumerable<Empresa> ListarPorRazaoSocial(string razaoSocial)
    {
        return DbContext.Set<Empresa>()
            .AsNoTracking()
            .Where(x => x.RazaoSocial.Contains(razaoSocial))
            .ToList();
    }

    public virtual Empresa? ObterPorCNPJOuCodigoReferencia(string cNPJOuCodigoReferencia)
    {
        return DbContext.Set<Empresa>()
            .AsNoTracking()
            .FirstOrDefault(x => x.CNPJ == cNPJOuCodigoReferencia || x.CodigoReferencia == cNPJOuCodigoReferencia);
    }

    public virtual ValidationResult Validar(Empresa entidade)
    {
        return validacao.Validate(entidade);
    }
}