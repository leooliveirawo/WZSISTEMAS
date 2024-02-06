namespace WZSISTEMAS.Dados.Helpers;

public static class ServicoEntidadeHelper
{
    public static InvalidOperationException RastreamentoNaoSuportado<TEntity>(
        this IServicoEntidades<TEntity> servicoEntidades)
        where TEntity : Entidade
    {
        return new InvalidOperationException(
            "O rastreamento não é suportado quando o carregamento de dados dependentes está habilitado");
    }
}