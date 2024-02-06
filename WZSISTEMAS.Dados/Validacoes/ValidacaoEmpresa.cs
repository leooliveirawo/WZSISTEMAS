namespace WZSISTEMAS.Dados.Validacoes;

public class ValidacaoEmpresa : AbstractValidator<Empresa>
{
    public ValidacaoEmpresa()
    {
        RuleFor(x => x.RazaoSocial)
            .NotEmpty()
            .WithMessage("A razão social da empresa não foi informada");

        RuleFor(x => x.CNPJ)
            .NotEmpty()
            .WithMessage("O CNPJ da empresa não foi informado");

        RuleFor(x => x.Logradouro)
            .NotEmpty()
            .WithMessage("O logradouro da empresa não foi informado");

        RuleFor(x => x.CEP)
            .NotEmpty()
            .WithMessage("O CEP da empresa não foi informado");

        RuleFor(x => x.Bairro)
            .NotEmpty()
            .WithMessage("O bairro da empresa não foi informado");

        RuleFor(x => x.Cidade)
            .NotEmpty()
            .WithMessage("A cidade da empresa não foi informada");

        RuleFor(x => x.UF)
            .NotEmpty()
            .WithMessage("O estado (UF) da empresa não foi informado");
    }
}