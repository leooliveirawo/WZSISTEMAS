using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoFornecedores(DbContext dbContext, IValidator<Fornecedor> validacao)
    : ServicoEntidades<Fornecedor>(dbContext), IServicoFornecedores
{
    private readonly IValidator<Fornecedor> validacao = validacao ?? throw new ArgumentNullException(nameof(validacao));

    public virtual Fornecedor? ObterPorCNPJ(string cNPJ)
    {
        return DbContext.Set<Fornecedor>()
            .AsNoTracking()
            .FirstOrDefault(x => x.CNPJ == cNPJ);
    }

    public virtual IEnumerable<Fornecedor> ListarPorRazaoSocial(string razaoSocial)
    {
        return DbContext.Set<Fornecedor>()
            .AsNoTracking()
            .Where(x => x.RazaoSocial.Contains(razaoSocial))
            .ToList();
    }

    public virtual ValidationResult Validar(Fornecedor entidade)
    {
        return validacao.Validate(entidade);
    }
}