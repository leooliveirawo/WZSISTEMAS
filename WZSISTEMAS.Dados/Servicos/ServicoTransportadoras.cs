using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoTransportadoras(DbContext dbContext, IValidator<Transportadora> validacao)
    : ServicoEntidades<Transportadora>(dbContext), IServicoTransportadoras
{
    private readonly IValidator<Transportadora> validacao =
        validacao ?? throw new ArgumentNullException(nameof(validacao));

    public virtual IEnumerable<Transportadora> ListarPorRazaoSocial(string razaoSocial)
    {
        return DbContext.Set<Transportadora>()
            .AsNoTracking()
            .Where(x => x.RazaoSocial.Contains(razaoSocial))
            .ToList();
    }

    public virtual Transportadora? ObterPorCNPJOuCodigoReferencia(string cNPJOuCodigoReferencia)
    {
        return DbContext.Set<Transportadora>()
            .AsNoTracking()
            .FirstOrDefault(x => x.CNPJ == cNPJOuCodigoReferencia || x.CodigoReferencia == cNPJOuCodigoReferencia);
    }

    public virtual ValidationResult Validar(Transportadora entidade)
    {
        return validacao.Validate(entidade);
    }
}