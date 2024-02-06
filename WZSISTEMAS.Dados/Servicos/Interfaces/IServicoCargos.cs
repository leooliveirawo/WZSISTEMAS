namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoCargos : IServicoEntidades<Cargo>
{
    IEnumerable<Cargo> ObterTudoPorNome(string nome);
}