namespace WZSISTEMAS.Base.NotaFiscal.Interfaces;

public interface IImpostoPISST
{
    //PISSTTipos? PISSTTipo { get; set; }
    decimal? PISST_BaseCalculo_vBC { get; set; }
    decimal? PISST_AliquotaPercentual_pPIS { get; set; }
    decimal? PISST_QuantidadeVendida_qBCProd { get; set; }
    decimal? PISST_AliquotaReais_vAliqProd { get; set; }

}
