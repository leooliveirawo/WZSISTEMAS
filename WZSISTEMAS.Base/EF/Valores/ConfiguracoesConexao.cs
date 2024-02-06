using WZSISTEMAS.Base.Helpers;

namespace WZSISTEMAS.Base.EF.Valores;
public class ConfiguracoesConexao
{
    public static string ConnectionString { get; set; } = "Data Source=DESKTOP-BTBU21N;Initial Catalog=WZSISTEMAS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public string Servidor { get; set; } = default!;
    public string BancoDados { get; set; } = default!;
    public TipoConexao TipoConexao { get; set; }
    public string? NomeUsuario { get; set; }
    public string? Senha { get; set; }
    public int TempoExpiracao { get; set; } = 50;
    public bool Criptografado { get; set; }
    public bool PossuiCertificado { get; set; }
    public ModoConexao ModoConexao { get; set; }

    public virtual string Converter()
    {
        var connectionString = string.Empty;

        connectionString += Servidor is not null
            ? $"Data Source={Servidor};"
            : string.Empty;

        connectionString += BancoDados is not null
            ? $"Initial Catalog={BancoDados};"
            : string.Empty;

        connectionString += TipoConexao == TipoConexao.AutenticacaoWindows 
            ? "Integrated Security=True;"
            : string.Empty;

        if (TipoConexao == TipoConexao.AutenticacaoSQL)
        {
            connectionString += NomeUsuario is not null
                ? $"UserID={NomeUsuario};"
                : string.Empty;

            connectionString += Senha is not null
                ? $"Password={Senha};"
                : string.Empty;
        }

        connectionString += $"Connect Timeout={TempoExpiracao};";

        connectionString += Criptografado
            ? "Encrypt=True;"
            : "Encrypt=False;";

        connectionString += PossuiCertificado
            ? "Trust Server Certificate=True;"
            : "Trust Server Certificate=False;";
        
        connectionString += ModoConexao == ModoConexao.SomenteLeitura
            ? "Application Intent=Read;"
            : "Application Intent=ReadWrite;";

        return connectionString;
    }

    public static ConfiguracoesConexao Criar(string connectionString)
    {
        var partesConnectionString = connectionString.Split(";");

        var tempoExpiracao = partesConnectionString.FirstOrDefault(parte => parte.Contains("Timeout="))?.Replace("Timeout=", "");

        return new ConfiguracoesConexao
        {
            Servidor = partesConnectionString.FirstOrDefault(parte => parte.Contains("Data Source"))?.Replace("Data Source=", "") ?? string.Empty,
            BancoDados = partesConnectionString.FirstOrDefault(parte => parte.Contains("Initial Catalog="))?.Replace("Initial Catalog=", "") ?? string.Empty,
            TipoConexao = partesConnectionString.Any(parte => parte.Contains("Integrated Security="))
                ? TipoConexao.AutenticacaoWindows
                : TipoConexao.AutenticacaoSQL,
            NomeUsuario = partesConnectionString.FirstOrDefault(parte => parte.Contains("UserId="))?.Replace("UserId=\"", "") ?? string.Empty,
            Senha = partesConnectionString.FirstOrDefault(parte => parte.Contains("Password="))?.Replace("Password=", "") ?? string.Empty,
            TempoExpiracao = tempoExpiracao is null
                ? 0
                : tempoExpiracao.ConverterParaInt(),
            Criptografado = partesConnectionString.FirstOrDefault(parte => parte.Contains("Encrypt=True")) != null,
            PossuiCertificado =
                partesConnectionString.FirstOrDefault(parte => parte.Contains("Trust Server Certificate=True")) != null,
            ModoConexao = partesConnectionString.Any(parte => parte.Contains("Application Intent=ReadWrite"))
                ? ModoConexao.LeituraEEscrita
                : ModoConexao.SomenteLeitura
        };
    }
}
