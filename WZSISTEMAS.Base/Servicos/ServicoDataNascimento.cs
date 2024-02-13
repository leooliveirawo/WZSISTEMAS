namespace WZSISTEMAS.Base.Servicos;

public class ServicoDataNascimento : IServicoDataNascimento
{
    public virtual int ObterIdade(DateTime dataNascimento)
    {
        var idade = DateTime.Now.Year - dataNascimento.Year;

        if (DateTime.Now.Month < dataNascimento.Month
            || DateTime.Now.Month == dataNascimento.Month
            && DateTime.Now.Day < dataNascimento.Day)
            idade--;

        return idade;
    }

    public virtual bool VerificarMaioridade(DateTime dataNascimento)
        => ObterIdade(dataNascimento) >= 18;
}
