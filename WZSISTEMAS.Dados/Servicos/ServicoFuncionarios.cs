using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoFuncionarios(DbContext dbContext, IValidator<Funcionario> validacao)
    : ServicoEntidades<Funcionario>(dbContext), IServicoFuncionarios
{
    private readonly IValidator<Funcionario> validacao = validacao
                                                         ?? throw new ArgumentNullException(nameof(validacao));

    public virtual Funcionario? ObterPorCPF(string cPF)
    {
        return DbContext.Set<Funcionario>()
            .AsNoTracking()
            .FirstOrDefault(x => x.CPF == cPF);
    }

    public virtual IEnumerable<Funcionario> ListarPorNomeCompleto(string nomeCompleto)
    {
        return DbContext.Set<Funcionario>()
            .AsNoTracking()
            .Where(x => x.NomeCompleto.Contains(nomeCompleto))
            .ToList();
    }

    public virtual ValidationResult Validar(Funcionario entidade)
    {
        return validacao.Validate(entidade);
    }
}