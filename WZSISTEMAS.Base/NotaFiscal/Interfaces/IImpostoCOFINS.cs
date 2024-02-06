using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Base.NotaFiscal.Interfaces;

public interface IImpostoCOFINS
{
    public TiposCOFINS TipoCOFINS { get; set; }
    public string COFINS { get; set; }

}
