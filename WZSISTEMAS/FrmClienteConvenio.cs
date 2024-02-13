namespace WZSISTEMAS;

public partial class FrmClienteConvenio : Form
{
    private readonly IServicoClientesFaturas servicoEntidades;
    private readonly IServicoClientes servicoClientes;
    private bool consultaHabilitada;
    private long clienteId;

    public FrmClienteConvenio(
        IServicoClientesFaturas servicoEntidades,
        IServicoClientes servicoClientes)
    {
        InitializeComponent();

        this.servicoEntidades = servicoEntidades
            ?? throw new ArgumentNullException(nameof(servicoEntidades));

        this.servicoClientes = servicoClientes
            ?? throw new ArgumentNullException(nameof(servicoClientes));
    }

    private void Consultar()
    {
        try
        {
            using var frm = ProvedorServicos.FrmConsultaAvancadaConvenio();

            if (frm.ShowDialog(this, DialogResult.OK))
            {
                clienteId = frm.Id;
                consultaHabilitada = true;
                RecarregarConsulta();
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void FrmClienteConvenio_Load(object sender, EventArgs e)
    {
        cbbxMes.Configurar(MesesHelper.CriarLista());
        cbbxMes.Definir((Mes)DateTime.Now.Month);

        nmupAno.Maximum = 9999;

        nmupAno.Value = DateTime.Now.Year;
    }

    private void BtnConsultar_Click(object sender, EventArgs e)
        => Consultar();

    private void RecarregarConsulta()
    {
        txtCPF_CNPJ.Clear();
        txtNomeCompleto_RazaoSocial.Clear();

        dgvTitulos.Rows.Clear();

        var fatura = servicoEntidades.ObterPorClienteId(
            clienteId,
            cbbxMes.Converter<Mes>(),
            (int)nmupAno.Value,
            false,
            true);

        if (fatura is not null)
        {
            txtNomeCompleto_RazaoSocial.Text = fatura.Cliente.NomeCompleto_RazaoSocial;
            txtCPF_CNPJ.Text = fatura.Cliente.CPF_CNPJ;

            lbValorTotal.Text = $"Valor total (R$) {fatura.ValorFatura:C2}";

            lbFechamentoData.Text = $"Fechamento em: {fatura.DiaFechamentoVencimento.ObterDiaFechamento():00}/{(int)fatura.MesReferente:00}/{fatura.AnoReferente}";
            lbVencimentoData.Text = $"Vencimento em: {fatura.DiaFechamentoVencimento.ObterDiaVencimento():00}/{(int)fatura.MesReferente:00}/{fatura.AnoReferente}";


            foreach (var lancamento in fatura.Lancamentos) dgvTitulos.Rows.Add(lancamento.LancadoEm.ToLongDateString(), $"{lancamento.ValorLancamento:C2}");
        }
        else
        {
            var cliente = servicoClientes.ObterPorId(clienteId);

            if (cliente is null)
            {
                this.ExibirMensagemErro("O cliente não foi encontrado.");
            }
            else
            {
                txtNomeCompleto_RazaoSocial.Text = cliente.NomeCompleto_RazaoSocial;
                txtCPF_CNPJ.Text = cliente.CPF_CNPJ;

                lbValorTotal.Text = $"Valor total (R$) {0:C2}";

                lbFechamentoData.Text = $"Fechamento em: {cliente.FaturaDiaFechamentoVencimento.ObterDiaFechamento():00}/{cbbxMes.Converter<int>():00}/{nmupAno.Value}";
                lbVencimentoData.Text = $"Vencimento em: {cliente.FaturaDiaFechamentoVencimento.ObterDiaVencimento():00}/{cbbxMes.Converter<int>():00}/{nmupAno.Value}";
            }
        }
    }

    private void CbbxMes_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (consultaHabilitada)
            RecarregarConsulta();

    }

    private void NmupAno_ValueChanged(object? sender, EventArgs e)
    {
        if (consultaHabilitada)
            RecarregarConsulta();
    }

    private void CbbxMes_KeyDown(object sender, KeyEventArgs e)
    {
        cbbxMes.SelectedIndexChanged -= CbbxMes_SelectedIndexChanged;
        nmupAno.ValueChanged -= NmupAno_ValueChanged;

        if (e.KeyData == Keys.Left)
        {
            if (cbbxMes.Converter<Mes>() == Mes.Janeiro)
            {
                e.Handled = true;

                nmupAno.Value--;

                cbbxMes.Definir(Mes.Dezembro);

                if (consultaHabilitada)
                    RecarregarConsulta();
            }
        }
        else if (e.KeyData == Keys.Right)
        {
            if (cbbxMes.Converter<Mes>() == Mes.Dezembro)
            {
                e.Handled = true;

                nmupAno.Value++;

                cbbxMes.Definir(Mes.Janeiro);

                if (consultaHabilitada)
                    RecarregarConsulta();
            }
        }

        cbbxMes.SelectedIndexChanged += CbbxMes_SelectedIndexChanged;
        nmupAno.ValueChanged += NmupAno_ValueChanged;
    }
}
