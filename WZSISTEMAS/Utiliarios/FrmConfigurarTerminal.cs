namespace WZSISTEMAS.Utiliarios;

public partial class FrmConfigurarTerminal : Form
{
    private readonly IServicoTerminais servicoTerminais;
    private readonly IServicoEmpresas servicoEmpresas;

    private IEnumerable<Empresa> empresas = default!;

    public FrmConfigurarTerminal(
        IServicoTerminais servicoTerminais,
        IServicoEmpresas servicoEmpresas)
    {
        InitializeComponent();

        this.servicoTerminais = servicoTerminais ?? throw new ArgumentNullException(nameof(servicoTerminais));
        this.servicoEmpresas = servicoEmpresas ?? throw new ArgumentNullException(nameof(servicoEmpresas));
    }

    private void CarregarTerminal()
    {
        var terminal = servicoTerminais.ObterTerminalVinculado();

        txtIdentificacao.Text = terminal?.Nome ?? "Não vinculado";
        cbbxEmpresa.Definir(terminal?.EmpresaId ?? cbbxEmpresa.SelectedValue);
    }


    private void FrmTerminal_Load(object sender, EventArgs e)
    {
        try
        {
            empresas = servicoEmpresas.ObterLista();

            cbbxEmpresa.Configurar(
                servicoEmpresas.ConverterParaListaItem(empresas));
            
            CarregarTerminal();
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void CbbxEmpresa_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.VerificarTeclaEnter())
        {
            var cNPJOuCodigoReferencia = cbbxEmpresa.Text;

            var empresaItem = empresas.FirstOrDefault(x => x.CNPJ == cNPJOuCodigoReferencia || x.CodigoReferencia == cNPJOuCodigoReferencia);

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
                this.ExibirMensagem("A empresas não foi informada.", "Empresa não informada");

                return;
            }

            var empresa = empresas.First(x => x.Id == cbbxEmpresa.Converter<long>());

            var terminal = servicoTerminais.ObterTerminalVinculado(true);

            if (terminal is null)
                terminal = servicoTerminais.VincularTerminal(empresa.Id);
            else
            {
                terminal.EmpresaId = empresa.Id;
                terminal.Nome = terminal.DefinirNome(empresa);

                servicoTerminais.Editar(terminal);
                servicoTerminais.SalvarAlteracoes();
            }

            servicoTerminais.DescartarAlteracoes();

            txtIdentificacao.Text = terminal.Nome;
            TerminalId = terminal.Id;

            if (!txtIdentificacao.ReadOnly)
            {
                btnImportar.Text = "Importar";

                txtIdentificacao.SomenteLeitura();
                txtIdentificacao.Selecionar();
            }

            this.ExibirMensagemOperacaoConcluida("Terminal configurado e vinculado com sucesso.");
        }
        catch (Exception erro)
        {
            servicoTerminais.DescartarAlteracoes();

            this.ExibirMensagemErro(erro);
        }
    }

    private void TxtIdentificacao_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.VerificarTeclaEnter()
            && !txtIdentificacao.ReadOnly)
        {
            if (txtIdentificacao.Text.ConverterParaLong(out var id))
            {
                try
                {
                    var entidade = servicoTerminais.ObterPorId(id);

                    if (entidade is null)
                    {
                        this.ExibirMensagem("O terminal não foi encontrado.", "Terminal não encontrado");

                        txtIdentificacao.Selecionar();
                    }
                    else
                    {
                        txtIdentificacao.Text = entidade.Nome;
                        cbbxEmpresa.Definir(entidade.EmpresaId);

                        btnImportar.Text = "Importar";

                        txtIdentificacao.SomenteLeitura();
                        txtIdentificacao.Selecionar();
                    }
                }
                catch (Exception erro)
                {
                    this.ExibirMensagemErro(erro);

                    txtIdentificacao.Selecionar();
                }
            }
            else
            {
                this.ExibirMensagem("Para importar um terminal é necessário informar um número inteiro positivo.",
                    "Identificação inválida");

                txtIdentificacao.Selecionar();
            }
        }
    }

    private void BtnImportar_Click(object sender, EventArgs e)
    {
        if (txtIdentificacao.ReadOnly)
        {
            btnImportar.Text = "Cancelar";

            txtIdentificacao.Clear();
            txtIdentificacao.LeituraEEscrita();
            txtIdentificacao.Selecionar();
        }
        else
        {
            btnImportar.Text = "Importar";
            
            CarregarTerminal();

            txtIdentificacao.SomenteLeitura();
            txtIdentificacao.Selecionar();
        }
    }
}
