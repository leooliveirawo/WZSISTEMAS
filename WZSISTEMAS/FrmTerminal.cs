using WZSISTEMAS.Dados.Servicos.Interfaces;
using WZSISTEMAS.WinForms.Helpers;

namespace WZSISTEMAS;

public partial class FrmTerminal : Form
{
    private class EmpresaItem
    {
        public long Id { get; set; }
        public string? CodigoReferencia { get; set; }
        public string RazaoSocial { get; set; } = default!;
        public string CNPJ { get; set; } = default!;

        public string RazaoSocial_CNJP { get; set; } = default!;

    }

    private readonly IServicoTerminais servicoTerminais;
    private readonly IServicoEmpresas servicoEmpresas;

    private readonly ICollection<EmpresaItem> empresaItens;

    public FrmTerminal(
        IServicoTerminais servicoTerminais,
        IServicoEmpresas servicoEmpresas)
    {
        InitializeComponent();
        this.servicoTerminais = servicoTerminais ?? throw new ArgumentNullException(nameof(servicoTerminais));
        this.servicoEmpresas = servicoEmpresas ?? throw new ArgumentNullException(nameof(servicoEmpresas));

        empresaItens = new List<EmpresaItem>();
    }


    private void FrmTerminal_Load(object sender, EventArgs e)
    {
        try
        {
            var empresas = servicoEmpresas.ObterLista();

            empresaItens.Clear();

            foreach (var empresa in empresas)
            {
                empresaItens.Add(new EmpresaItem
                {
                    Id = empresa.Id,
                    CodigoReferencia = empresa.CodigoReferencia,
                    RazaoSocial = empresa.RazaoSocial,
                    CNPJ = empresa.CNPJ,
                    RazaoSocial_CNJP = $"{empresa.RazaoSocial} ({empresa.CNPJ})"
                });
            }

            cbbxEmpresa.ValueMember = nameof(EmpresaItem.Id);
            cbbxEmpresa.DisplayMember = nameof(EmpresaItem.RazaoSocial_CNJP);
            cbbxEmpresa.DataSource = empresaItens;

            var terminal = servicoTerminais.ObterTerminalVinculado();

            txtIdentificacao.Text = terminal is null ? "Não vinculado" : terminal.Nome;

            servicoTerminais.DescartarAlteracoes();

        }
        catch (Exception erro)
        {
            servicoTerminais.DescartarAlteracoes();

            this.ExibirMensagemErro(erro);
        }
    }

    private void CbbxEmpresa_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar))
        {
            e.Handled = true;

            var cNPJOuCodigoReferencia = cbbxEmpresa.Text;

            var empresaItem = empresaItens.FirstOrDefault(x => x.CNPJ == cNPJOuCodigoReferencia || x.CodigoReferencia == cNPJOuCodigoReferencia);

            if (empresaItem is not null)
                cbbxEmpresa.SelectedValue = empresaItem.Id;
        }
    }

    private void BtnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            if (cbbxEmpresa.SelectedValue is null)
            {
                MessageBox.Show(this, "A empresa não foi informada.", "Empresa não informada");

                return;
            }

            var empresa = empresaItens.First(x => x.Id == (long)cbbxEmpresa.SelectedValue);

            var terminal = servicoTerminais.ObterTerminalVinculado(true);

            if (terminal is null)
                terminal = servicoTerminais.VincularTerminal(empresa.Id);
            else
            {
                terminal.EmpresaId = empresa.Id;
                terminal.Nome = $"Terminal {terminal.Id} - {empresa.RazaoSocial} ({empresa.CNPJ})";

                servicoTerminais.Editar(terminal);
                servicoTerminais.SalvarAlteracoes();
            }

            servicoTerminais.DescartarAlteracoes();

            txtIdentificacao.Text = terminal.Nome;
            TerminalId = terminal.Id;

            MessageBox.Show(this, "Terminal configurado e vinculado com sucesso.", "Terminal vinculado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception erro)
        {
            servicoTerminais.DescartarAlteracoes();

            this.ExibirMensagemErro(erro);
        }
    }
}
