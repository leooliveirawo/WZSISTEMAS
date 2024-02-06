using WZSISTEMAS.Base.Servicos.Interfaces;

namespace WZSISTEMAS.Base.Servicos;

public class ServicoCodigoBarras(IServicoRandomico servicoRandomico) : IServicoCodigoBarras
{
    private readonly IServicoRandomico servicoRandomico = servicoRandomico
        ?? throw new ArgumentNullException(nameof(servicoRandomico));

    public virtual string GerarCodigoBarras() 
        => GerarCodigoBarras(
            servicoRandomico.GerarRandomicamente(3),
            servicoRandomico.GerarRandomicamente(5),
            servicoRandomico.GerarRandomicamente(4),
            servicoRandomico.GerarRandomicamente(1));

    public virtual string GerarCodigoBarras(
        string codigoPais,
        string codigoEmpresa,
        string codigoItem,
        string digitoVerificador)
    {
        if (codigoPais.Length != 3)
            throw new ArgumentException("O código do país deve ter 2 digitos");

        if (codigoEmpresa.Length != 5)
            throw new ArgumentException("O código da empresa deve ter 5 digitos");

        if (codigoItem.Length != 4)
            throw new ArgumentException("O código do ítem deve ter 4 digitos");

        if (digitoVerificador.Length != 1)
            throw new ArgumentException("O digito verificador deve ter 1 digito");

        return $"{codigoPais}{codigoEmpresa}{codigoItem}{digitoVerificador}";
    }
}
