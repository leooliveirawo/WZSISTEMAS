namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoValidacaoEntidades<TEntidade> : IServicoValidacao<TEntidade>
    where TEntidade : Entidade
{
}