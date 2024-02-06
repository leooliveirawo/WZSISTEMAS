namespace WZSISTEMAS.Helpers;

public static class WindowsFormsHelper
{
    public static ICollection<Form> Forms { get; } = new List<Form>();

    public static  bool VerificarAutenticacao(this Form form, IServicoUsuarios servicoUsuarios)
    {
        try
        {
            var resultado = servicoUsuarios.ValidarToken(Program.Token ?? default!);

            if (resultado.Valido)
            {
                Program.Token = resultado.Token;

                return true;
            }
            else
            {
                form.ExibirMensagemErro("A sessão expirou.", "Sessão expirou");

                foreach (var form1 in Forms)
                {
                    form.Close();
                }

                Forms.Clear();

                return false;
            }
        }
        catch (Exception erro)
        {
            form.ExibirMensagemErro(erro);

            return false;
        }
    }

    public static void AbrirSimuladorCartao(this Form form, object sender, EventArgs e)
    {
        var driver = ProvedorServicos.DriverCartao();

        var frm = new FrmSimuladorCartao((IDriverCartaoVirtual)driver);

        frm.Show(form);
    }

}
