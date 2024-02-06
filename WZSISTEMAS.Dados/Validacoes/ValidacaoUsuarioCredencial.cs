namespace WZSISTEMAS.Dados.Validacoes;
public class ValidacaoUsuarioCredencial :AbstractValidator<UsuarioCredenciais>
{
    public ValidacaoUsuarioCredencial()
    {
        RuleFor(x => x.NomeUsuario)
            .NotEmpty()
            .WithMessage("O nome de usuário não foi informado");

        RuleFor(x => x.Senha)
            .NotEmpty()
            .WithMessage("A senha não foi informada");
    }
}
