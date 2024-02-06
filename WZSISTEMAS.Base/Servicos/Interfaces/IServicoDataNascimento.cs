namespace WZSISTEMAS.Base.Servicos.Interfaces;
public interface IServicoDataNascimento
{
    bool VerificarMaioridade(DateTime dataNascimento);
    int ObterIdade(DateTime dataNascimento);
}
