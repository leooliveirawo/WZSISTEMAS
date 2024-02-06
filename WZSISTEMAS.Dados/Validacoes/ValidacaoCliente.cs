using WZSISTEMAS.Base.Servicos.Interfaces;

namespace WZSISTEMAS.Dados.Validacoes;

public class ValidacaoCliente : AbstractValidator<Cliente>
{
    public ValidacaoCliente(
        IServicoCPF servicoCPF,
        IServicoCNPJ cnpj,
        IServicoDataNascimento servicoDatasNascimentos)
    {
        ArgumentNullException.ThrowIfNull(servicoCPF, nameof(servicoCPF));
        ArgumentNullException.ThrowIfNull(cnpj, nameof(cnpj));
        ArgumentNullException.ThrowIfNull(servicoDatasNascimentos, nameof(servicoDatasNascimentos));

        RuleFor(x => x.NomeCompleto_RazaoSocial)
            .NotEmpty()
            .WithMessage("O nome completo/razão social do cliente não foi informado");

        When(x => x.Tipo == TipoCliente.PessoaFisica, () =>
        {
            RuleFor(x => x.CPF_CNPJ)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("O CPF/CNPJ do cliente não foi informado")
                .Must(x => servicoCPF.Validar(x))
                .WithMessage("O CPF/CNPJ do cliente não é válido");

            RuleFor(x => x.DataNascimento)
                .Must(x => servicoDatasNascimentos.VerificarMaioridade(x ?? default!))
                .When(x => x.DataNascimento.HasValue)
                .WithMessage("O cliente deve ter pelo menos 18 anos completos");
        });

        When(x => x.Tipo == TipoCliente.PessoaJuridica, () =>
        {
            RuleFor(x => x.CPF_CNPJ)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("O CPF/CNPJ do cliente não foi informado")
                .Must(x => servicoCPF.Validar(x))
                .WithMessage("O CPF/CNPJ do cliente não é válido");
        });

        RuleFor(x => x.Logradouro)
            .NotEmpty()
            .WithMessage("O logradouro do cliente não foi informado");

        RuleFor(x => x.CEP)
            .NotEmpty()
            .WithMessage("O CEP do cliente não foi informado");

        RuleFor(x => x.Bairro)
            .NotEmpty()
            .WithMessage("O bairro do cliente não foi informado");

        RuleFor(x => x.Cidade)
            .NotEmpty()
            .WithMessage("A cidade do cliente não foi informada");

        RuleFor(x => x.Telefone)
            .NotEmpty()
            .WithMessage("O telefone do cliente não foi informado");
    }
}