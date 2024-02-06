namespace WZSISTEMAS.Dados.Validacoes;

public class ValidacaoProduto : AbstractValidator<Item>
{
    public ValidacaoProduto()
    {
        RuleFor(x => x.CodigoBarras)
            .NotEmpty()
            .WithMessage("O código de barras não foi informado");

        RuleFor(x => x.Descricao)
            .NotEmpty()
            .WithMessage("A descrição não foi informada");

        RuleFor(x => x.PrecoFinal)
            .NotEmpty()
            .WithMessage("O preço final (R$) não foi informado");
    }
}