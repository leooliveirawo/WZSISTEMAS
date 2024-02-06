using WZSISTEMAS.Base.NotaFiscal.Valores;

namespace WZSISTEMAS.Base.NotaFiscal.Servicos.Interfaces;

public interface IServicoCFe
{
    string? ConverterParaXml(CFe cFe);
    CFe? ConverterParaCFe(string xml);
    CFe? LerEConverterParaCFe(string caminho);
}