using System.Net.Http.Json;

namespace WZSISTEMAS.Base.Servicos;
public class ServicoConsultaCEP : IServicoConsultaCEP
{
    private const string uri = "https://brasilapi.com.br";
    private const string api = "/api/cep/v2/";
    
    public virtual async Task<ConsultaCEP?> ObterEnderecoPeloCEPAsync(string cEP)
    {
        var web = new HttpClient
        {
            BaseAddress = new Uri(uri)
        };

        return await web.GetFromJsonAsync<ConsultaCEP>($"{api}{cEP}");
    }
}
