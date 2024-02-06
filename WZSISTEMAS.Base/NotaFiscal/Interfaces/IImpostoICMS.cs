using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Base.NotaFiscal.Interfaces;

public interface IImpostoICMS
{
    public TiposICMS TipoICMS { get; set; }
    public string ICMS { get; set; }

}
