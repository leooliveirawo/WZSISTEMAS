using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Base.NotaFiscal.Interfaces;

public interface IImpostoPIS
{
    TiposPIS TipoPIS { get; set; }
    string PIS { get; set; }
}
