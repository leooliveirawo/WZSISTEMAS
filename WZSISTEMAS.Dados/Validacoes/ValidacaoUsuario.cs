namespace WZSISTEMAS.Dados.Validacoes;

public class ValidacaoUsuario : AbstractValidator<Usuario>
{
    public ValidacaoUsuario()
    {
        RuleFor(x => x.NomeUsuario)
            .NotEmpty()
            .WithMessage("O nome de usuário não foi informado");
    }
}