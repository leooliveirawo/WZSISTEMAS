namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoDesenvolvedor
{
   void PreencherBancoDados();
    ResultadoToken Desautenticar(string token);
}