namespace WZSISTEMAS.Dados.Validacoes;

public class ValidacaoCargo : AbstractValidator<Cargo>
{
    public ValidacaoCargo()
    {
        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("O nome do cargo não foi informado");
    }
}