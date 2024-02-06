namespace WZSISTEMAS.Base.Servicos.Interfaces;

public interface IServicoCodigoBarras
{
    string GerarCodigoBarras();
    string GerarCodigoBarras(string codigoPais, string codigoEmpresa, string codigoItem, string digitoVerificador);
}
