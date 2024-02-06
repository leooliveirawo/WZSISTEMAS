using WZSISTEMAS.Base.Valores;

namespace WZSISTEMAS.Base.Servicos;

public class ServicoToken(
    IServicoJson servicoJson,
    IServicoCriptografia servicoCriptografia) : IServicoToken
{
    private readonly IServicoJson servicoJson = servicoJson
        ?? throw new ArgumentNullException(nameof(servicoJson));

    private readonly IServicoCriptografia servicoCriptografia = servicoCriptografia
        ?? throw new ArgumentNullException(nameof(servicoCriptografia));

    private DateTime ExpiraEmPadrao => DateTime.Now.AddMinutes(30);

    private const string chavePadrao = "eK_f9*2=9fjUw95_o(uJk@c9-dH8&dx6w@$";

    public virtual Token CriarToken(string valor)
        => CriarToken(
            valor,
            chavePadrao,
            ExpiraEmPadrao);

    public virtual Token CriarToken(
        string valor,
        DateTime expiraEm)
        => CriarToken(
            valor,
            chavePadrao,
            expiraEm);

    public virtual Token CriarToken(
        string valor,
        string chave)
        => CriarToken(
            valor,
            chave,
            ExpiraEmPadrao);

    public virtual Token CriarToken(
        string valor,
        string chave,
        DateTime expiraEm)
        => new()
        {
            Valor = valor,
            Chave = chave,
            ExpiraEm = expiraEm,
        };

    public virtual string Criptografar(
        string iV,
        string key,
        Token token)
    {
        var tokenJson = servicoJson.Serializar(token)
            ?? throw new InvalidOperationException("O dados do token não são válidos");

        return servicoCriptografia.Criptografar(
            iV,
            key,
            tokenJson);
    }

    public virtual Token Descriptografar(
        string iV,
        string key,
        string tokenCriptografado)
    {
        var tokenJson = servicoCriptografia.Descriptografar(
            iV,
            key,
            tokenCriptografado);

        return servicoJson.Deserializar<Token>(tokenJson)
            ?? throw new InvalidOperationException("Os dados do token não são válidos");
    }
}
