namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoFuncionarios : IServicoEntidades<Funcionario>, IServicoValidacaoEntidades<Funcionario>
{
    Funcionario? ObterPorCPF(string cPF);
    IEnumerable<Funcionario> ListarPorNomeCompleto(string nomeCompleto);
}