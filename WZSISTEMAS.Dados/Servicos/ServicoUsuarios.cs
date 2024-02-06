using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoUsuarios(
    DbContext dbContext,
    IValidator<Usuario> validador,
    IValidator<UsuarioCredenciais> validadorUsuarioCredenciais,
    IServicoToken servicoToken,
    IServicoHash servicoHash)
    : ServicoEntidades<Usuario>(dbContext), IServicoUsuarios
{
    private readonly string chaveToken = "eK_f9*2=9fjUw95_o(uJk@c9-dH8&dx6w@$";
    private readonly string iV = "eK_f9*2=9fjUw95_";
    private readonly string key = "eK_f9*2=9fjUw95_o(uJk@c9-dH8&dx6";

    private readonly IServicoHash servicoHash = servicoHash ?? throw new ArgumentNullException(nameof(servicoHash));
    private readonly IServicoToken servicoToken = servicoToken ?? throw new ArgumentNullException(nameof(servicoToken));
    private readonly IValidator<Usuario> validador = validador ?? throw new ArgumentNullException(nameof(validador));
    private readonly IValidator<UsuarioCredenciais> validadorUsuarioCredenciais = validadorUsuarioCredenciais ?? throw new ArgumentNullException(nameof(validadorUsuarioCredenciais));

    public virtual Usuario? Autenticar(UsuarioCredenciais credenciais)
    {
        var hashSenha = credenciais.GerarHash(servicoHash);

        return DbContext.Set<Usuario>()
            .AsNoTracking()
            .FirstOrDefault(usuario => usuario.NomeUsuario == credenciais.NomeUsuario && usuario.HashSenha == hashSenha);
    }

    public virtual void Criar(Usuario entidade, string senha)
    {
        entidade.HashSenha = servicoHash.GerarHash(senha);

        Criar(entidade);
    }

    public virtual void Editar(Usuario entidade, string senhaAtual, string novaSenha)
    {
        var hashSenha = servicoHash.GerarHash(senhaAtual);

        if (entidade.HashSenha == hashSenha)
        {
            entidade.HashSenha = servicoHash.GerarHash(novaSenha);

            Editar(entidade);
        }
        else
        {
            throw new InvalidOperationException("A senha informada está incorreta");
        }
    }

    public virtual void Editar(Usuario entidade, string senhaAtual)
    {
        if (entidade.HashSenha == servicoHash.GerarHash(senhaAtual))
            Editar(entidade);
        else
            throw new InvalidOperationException("A senha informada está incorreta");
    }

    public virtual Usuario? ObterPorFuncionarioId(long funcionarioId, bool usarTracking = false)
    {
        return usarTracking
            ? DbContext.Set<Usuario>()
                .FirstOrDefault(x => x.FuncionarioId == funcionarioId)
            : DbContext.Set<Usuario>()
                .AsNoTracking()
                .FirstOrDefault(x => x.FuncionarioId == funcionarioId);
    }

    public virtual ValidationResult Validar(Usuario entidade)
    {
        return validador.Validate(entidade);
    }

    public virtual bool VerificarNomeUsuarioUsada(string nomeUsuario)
    {
        return DbContext.Set<Usuario>()
            .AsNoTracking()
            .Where(usuario => usuario.NomeUsuario == nomeUsuario)
            .Select(usuario => usuario.Id)
            .Any();
    }

    public  Usuario? ObterPorNomeUsuario(string nomeUsuario)
    {
        return DbContext.Set<Usuario>()
            .AsNoTracking()
            .FirstOrDefault(usuario => usuario.NomeUsuario == nomeUsuario);
    }


    public  ResultadoToken AutenticarToken(long id)
    {
        return AutenticarToken(
            ObterPorId(id));
    }

    public virtual ResultadoToken AutenticarToken(UsuarioCredenciais credenciais)
    {
        return AutenticarToken(
            Autenticar(credenciais));
    }

    public virtual ResultadoToken ValidarToken(string token)
    {
        var usuarioToken = servicoToken.Descriptografar(iV, key, token);

        if (usuarioToken is null)
            throw new InvalidOperationException("Os dados do token não são válidos");

        if (!usuarioToken.Cancelado
            && usuarioToken.ExpiraEm > DateTime.Now
            && VerificarNomeUsuarioUsada(usuarioToken.Valor))
        {
            usuarioToken.ExpiraEm = DateTime.Now.AddMinutes(60);

            return new ResultadoToken
            {
                Token = servicoToken.Criptografar(
                    iV,
                    key,
                    usuarioToken),
                Valido = true
            };
        }

        return new ResultadoToken();
    }

    public virtual ResultadoToken<Usuario> ObterUsuarioPorToken(string token)
    {
        var retorno = ValidarToken(token);

        if (retorno.Valido)
        {
            var usuarioToken = servicoToken.Descriptografar(iV, key, token);

            var usuario = ObterPorNomeUsuario(usuarioToken.Valor);

            if (usuario is not null)
                return new ResultadoToken<Usuario>
                {
                    Token = retorno.Token,
                    Valido = true,
                    Retorno = usuario
                };
        }

        return new ResultadoToken<Usuario>();
    }

    public virtual ResultadoToken Desautenticar(string token)
    {
        var usuarioToken = servicoToken.Descriptografar(iV, key, token);

        if (usuarioToken is not null
            && VerificarNomeUsuarioUsada(usuarioToken.Valor))
        {
            usuarioToken.Cancelado = true;

            return new ResultadoToken
            {
                Token = servicoToken.Criptografar(
                    iV,
                    key,
                    usuarioToken),
                Valido = true
            };
        }

        return new ResultadoToken();
    }

    private  ResultadoToken AutenticarToken(Usuario? usuario)
    {
        if (usuario is null)
            return new ResultadoToken();

        var token = servicoToken.CriarToken(
            usuario.NomeUsuario,
            chaveToken,
            DateTime.Now.AddMinutes(60));


        return new ResultadoToken
        {
            Token = servicoToken.Criptografar(
                iV,
                key,
                token),
            Valido = true
        };
    }

    protected override Expression<Func<Usuario, ItemLista<long>>> ConverterEntidadeParaLista()
    {
        return usuario => new ItemLista<long>
        {
            Item = usuario.Id,
            Descricao = usuario.NomeUsuario
        };
    }

    public virtual ValidationResult Validar(UsuarioCredenciais valor)
        => validadorUsuarioCredenciais.Validate(valor);
}