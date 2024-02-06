namespace WZSISTEMAS.Dados.Validacoes;

public class ValidacaoTransportador : AbstractValidator<Transportadora>
{
    public ValidacaoTransportador()
    {
        RuleFor(x => x.RazaoSocial)
            .NotEmpty()
            .WithMessage("A razão social da transportadora não foi informada");

        RuleFor(x => x.CNPJ)
            .NotEmpty()
            .WithMessage("O CNPJ da transportadora não foi informado");

        RuleFor(x => x.Logradouro)
            .NotEmpty()
            .WithMessage("O logradouro da transportadora não foi informado");

        RuleFor(x => x.CEP)
            .NotEmpty()
            .WithMessage("O CEP da transportadora não foi informado");

        RuleFor(x => x.Bairro)
            .NotEmpty()
            .WithMessage("O bairro da transportadora não foi informado");

        RuleFor(x => x.Cidade)
            .NotEmpty()
            .WithMessage("A cidade da transportadora não foi informada");

        RuleFor(x => x.UF)
            .NotEmpty()
            .WithMessage("O estado (UF) da transportadora não foi informado");

        RuleFor(x => x.Telefone)
            .NotEmpty()
            .WithMessage("O telefone da transportadora não foi informado");
    }
}