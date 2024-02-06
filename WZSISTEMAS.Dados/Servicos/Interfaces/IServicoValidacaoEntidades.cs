namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoValidacao<T>
{
    ValidationResult Validar(T valor);
}

public interface IServicoValidacaoEntidades<TEntidade> : IServicoValidacao<TEntidade>
    where TEntidade : Entidade
{
}