namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoCFe2 : IServicoCFe
{
    CFe? ConvertVendaToCFe(
        DadosSAT dadosSAT,
        Venda venda,
        IEnumerable<VendaItem> itens,
        IEnumerable<VendaPagamento> pagamentos);
}