using System.Text.Json.Serialization;

namespace WZSISTEMAS.Base.Valores;

[Serializable]
public class ConsultaCEP
{
    [JsonPropertyName("cep")]
    public string CEP { get; set; } = default!;

    [JsonPropertyName("street")]
    public string Logradouro { get; set; } = default!;

    [JsonPropertyName("neighborhood")]
    public string Bairro { get; set; } = default!;

    [JsonPropertyName("city")]
    public string Cidade { get; set; } = default!;

    [JsonPropertyName("state")]
    public string Estado { get; set; } = default!;
}
