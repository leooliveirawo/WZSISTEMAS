namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoCaixasEntradas : IServicoEntidades<CaixaEntrada>
{
    CaixaEntrada CancelarEntrada(
        long entradaCaixaId,
        string motivoCancelamento);

    CaixaEntrada? ObterPorId(
        long id,
        bool usarRastreamento = false,
        bool incluirPropriedadeCaixa = false);
}