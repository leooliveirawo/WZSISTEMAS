namespace WZSISTEMAS.Dados.Validacoes;

public class ValidacaoFuncionario : AbstractValidator<Funcionario>
{
    public ValidacaoFuncionario(
        IServicoCPF servicoCPF,
        IServicoDataNascimento servicoDatasNascimentos)
    {
        ArgumentNullException.ThrowIfNull(servicoCPF, nameof(servicoCPF));
        ArgumentNullException.ThrowIfNull(servicoDatasNascimentos, nameof(servicoDatasNascimentos));

        RuleFor(x => x.NomeCompleto)
            .NotEmpty()
            .WithMessage("O nome completo do funcionário não foi informado");

        RuleFor(x => x.CPF)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("O CPF do funcionário não foi informado")
            .Must(x => servicoCPF.Validar(x))
            .WithMessage("O CPF do funcionário não é válido");

        RuleFor(x => x.DataNascimento)
            .Must(x => servicoDatasNascimentos.VerificarMaioridade(x ?? DateTime.Now))
            .When(x => x.DataNascimento.HasValue)
            .WithMessage("O funcionário deve ter pelo menos 18 anos completos");

        RuleFor(x => x.Logradouro)
            .NotEmpty()
            .WithMessage("O logradouro do funcionário não foi informado");

        RuleFor(x => x.CEP)
            .NotEmpty()
            .WithMessage("O CEP do funcionário não foi informado");

        RuleFor(x => x.Bairro)
            .NotEmpty()
            .WithMessage("O bairro do funcionário não foi informado");

        RuleFor(x => x.Cidade)
            .NotEmpty()
            .WithMessage("A cidade do funcionário não foi informada");

        RuleFor(x => x.UF)
            .NotEmpty()
            .WithMessage("O estado (UF) do funcionário não foi informado");

        RuleFor(x => x.Telefone)
            .NotEmpty()
            .WithMessage("O telefone do funcionário não foi informado");
    }
}