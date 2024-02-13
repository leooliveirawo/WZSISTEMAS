namespace WZSISTEMAS.FrenteCaixa;

public partial class FrmFrenteCaixaCPF_CNPJNaNota : Form
{
    private readonly IServicoCPF servicoCPF;
    private readonly IServicoCNPJ servicoCnpj;

    public string? CPF_CNPJ { get; set; }

    public FrmFrenteCaixaCPF_CNPJNaNota(
        IServicoCPF servicoCPF,
        IServicoCNPJ cnpj)
    {
        InitializeComponent();

        this.servicoCPF = servicoCPF
            ?? throw new ArgumentNullException(nameof(servicoCPF));

        this.servicoCnpj = cnpj
            ?? throw new ArgumentNullException(nameof(cnpj));
    }

    public void DefinirCPF_CNPJ(string? cPF_CNPJ)
    {
        if (cPF_CNPJ is not null)
        {
            CPF_CNPJ = ValidarCPFOuCNPJ(cPF_CNPJ)
                ? cPF_CNPJ
                : throw new InvalidOperationException("O CPF/CNPJ informado não é válido");
        }
        else
            CPF_CNPJ = default;
    }

    private bool ValidarCPFOuCNPJ(string cPF_CNPJ)
    {
        if (cPF_CNPJ.Length == 11)
            return servicoCPF.Validar(cPF_CNPJ);
        else if (cPF_CNPJ.Length == 14)
            return servicoCnpj.Validar(cPF_CNPJ);
        else
            return false;
    }

    private void InformarCPF_CNPJ()
    {
        try
        {
            if (!string.IsNullOrEmpty(txtCPF_CNPJ.Text)
                && !ValidarCPFOuCNPJ(txtCPF_CNPJ.Text))
            {
                this.ExibirMensagem("O CPF/CNPJ informado não é válido", "CPF/CNPJ invalido");

                txtCPF_CNPJ.Selecionar();
            }
            else
            {
                CPF_CNPJ = string.IsNullOrEmpty(txtCPF_CNPJ.Text) ? null : txtCPF_CNPJ.Text;

                DialogResult = DialogResult.OK;
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void FrmFrenteCaixaCPF_CNPJNaNota_Load(object sender, EventArgs e)
    {
        if (CPF_CNPJ is not null)
            txtCPF_CNPJ.Text = CPF_CNPJ;
    }

    private void FrmFrenteCaixaCPF_CNPJNaNota_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar))
        {
            e.Handled = true;

            InformarCPF_CNPJ();
        }
    }

    private void FrmFrenteCaixaCPF_CNPJNaNota_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyData.Equals(Keys.Escape))
            DialogResult = DialogResult.Cancel;
        else if (e.KeyData.Equals(Keys.F4))
        {
            txtCPF_CNPJ.Clear();

            InformarCPF_CNPJ();
        }

    }
}
