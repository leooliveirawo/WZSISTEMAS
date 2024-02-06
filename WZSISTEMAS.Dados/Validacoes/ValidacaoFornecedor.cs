using WZSISTEMAS.Base.Servicos.Interfaces;

namespace WZSISTEMAS.Dados.Validacoes;

public class ValidacaoFornecedor : AbstractValidator<Fornecedor>
{
    public ValidacaoFornecedor(IServicoCNPJ cnpj)
    {
        ArgumentNullException.ThrowIfNull(cnpj, nameof(cnpj));

        RuleFor(x => x.RazaoSocial)
            .NotEmpty()
            .WithMessage("A razão social do fornecedor não foi informada");

        RuleFor(x => x.CNPJ)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("O CNPJ do fornecedor não foi informado")
            .Must(x => cnpj.Validar(x))
            .WithMessage("O CNPJ do fornecedor não é válido");

        RuleFor(x => x.Logradouro)
            .NotEmpty()
            .WithMessage("O logradouro do fornecedor não foi informado");

        RuleFor(x => x.CEP)
            .NotEmpty()
            .WithMessage("O CEP do fornecedor não foi informado");

        RuleFor(x => x.Bairro)
            .NotEmpty()
            .WithMessage("O bairro do fornecedor não foi informado");

        RuleFor(x => x.Cidade)
            .NotEmpty()
            .WithMessage("A cidade do fornecedor não foi informada");

        RuleFor(x => x.UF)
            .NotEmpty()
            .WithMessage("O estado (UF) do fornecedor não foi informado");
    }
}