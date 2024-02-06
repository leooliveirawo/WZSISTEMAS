namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoCaixasSuprimentos : IServicoEntidades<CaixaSuprimento>
{
    CaixaSuprimento? ObterPeloId(
        long id,
        bool usarRastreamento = false,
        bool incluirPropriedadeCaixa = false);
}