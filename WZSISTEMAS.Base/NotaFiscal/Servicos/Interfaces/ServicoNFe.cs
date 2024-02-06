using WZSISTEMAS.Base.NotaFiscal.Valores;

namespace WZSISTEMAS.Base.NotaFiscal.Servicos.Interfaces;

public interface ServicoNFe
{
    NFe? ConverterParaNFe(string xml);
    NFe? LerEConverterParaNFe(string cs);
}