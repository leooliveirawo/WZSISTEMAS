namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoValidacao<T>
{
    ValidationResult Validar(T valor);
}