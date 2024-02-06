namespace WZSISTEMAS.Base.Servicos.Interfaces;

public interface IServicoCPF
{
    bool Validar(string cPF);
    string Gerar();
    string GerarDigitoVerificador(string cPFParcial);
}
