namespace WZSISTEMAS.Base.Servicos.Interfaces;
public interface IServicoCNPJ
{
    bool Validar(string cNPJ);
    string Gerar();
    string GerarDigitosVerificadores(string cNPJParcial);
}
