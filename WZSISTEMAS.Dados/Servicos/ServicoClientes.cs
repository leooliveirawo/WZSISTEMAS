using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoClientes(
    DbContext dbContext,
    IValidator<Cliente> validacao)
    : ServicoEntidades<Cliente>(dbContext), IServicoClientes
{
    private readonly IValidator<Cliente> validacao = validacao
                                                     ?? throw new ArgumentNullException(nameof(validacao));

    public override void Criar(Cliente entidade)
    {
        entidade.ConvenioLimiteDisponivel = entidade.ConvenioLimite;

        base.Criar(entidade);
    }

    public override void Editar(Cliente entidade)
    {
        entidade.ConvenioLimiteDisponivel = entidade.ConvenioLimite - entidade.ConvenioLimiteUsado;

        base.Editar(entidade);
    }

    public virtual Cliente? ObterPorCPF_CNPJ(string cPF_CNPJ)
    {
        return DbContext.Set<Cliente>()
            .AsNoTracking()
            .FirstOrDefault(x => x.CPF_CNPJ == cPF_CNPJ);
    }

    public virtual IEnumerable<Cliente> ListaPorNomeCompleto_RazaoSocial(
        string nomeCompleto_RazaoSocial)
    {
        return DbContext.Set<Cliente>()
            .AsNoTracking()
            .Where(x => x.NomeCompleto_RazaoSocial.Contains(nomeCompleto_RazaoSocial))
            .ToList();
    }

    public virtual ValidationResult Validar(Cliente entidade)
    {
        return validacao.Validate(entidade);
    }

    public virtual IEnumerable<Cliente> ListaConvenioPorCPF_CNPJ_NomeCompleto_RazaoSocial(
        string cPF_CNPJ_NomeCompleto_RazaoSocial)
    {
        return DbContext.Set<Cliente>()
            .AsNoTracking()
            .Where(
                x => x.NomeCompleto_RazaoSocial.Contains(cPF_CNPJ_NomeCompleto_RazaoSocial)
                     || x.CPF_CNPJ == cPF_CNPJ_NomeCompleto_RazaoSocial)
            .ToList();
    }

    public virtual bool VerificarLimiteDisponivel(long clienteId, decimal valor)
    {
        var limiteDisponivel = DbContext.Set<Cliente>()
                                   .AsNoTracking()
                                   .Where(x => x.Id == clienteId)
                                   .Select(x => x.ConvenioLimiteDisponivel)
                                   .FirstOrDefault()
                               ?? throw new InvalidOperationException("O cliente não foi encontrado");

        return limiteDisponivel >= valor;
    }
}