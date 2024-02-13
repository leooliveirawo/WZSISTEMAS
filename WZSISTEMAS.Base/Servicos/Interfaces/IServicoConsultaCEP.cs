namespace WZSISTEMAS.Base.Servicos.Interfaces;
public interface IServicoConsultaCEP
{
    Task<ConsultaCEP?> ObterEnderecoPeloCEPAsync(string cEP);
}
