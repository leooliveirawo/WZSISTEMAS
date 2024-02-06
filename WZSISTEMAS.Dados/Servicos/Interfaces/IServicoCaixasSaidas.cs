namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoCaixasSaidas : IServicoEntidades<CaixaSaida>
{
    CaixaSaida? ObterPeloId(
        long id,
        bool usarRastreamento = false,
        bool incluirPropriedadeCaixa = false);
}