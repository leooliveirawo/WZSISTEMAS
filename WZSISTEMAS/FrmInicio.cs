namespace WZSISTEMAS;

public partial class FrmInicio : FrmBase
{
    private readonly IServicoJson servicoJson;
    private readonly IServicoCriptografia servicoCriptografia;
    private readonly IServicoCaixas servicoCaixas;
    private readonly IServicoTerminais servicoTerminais;
    private readonly IServicoDesenvolvedor servicoDesenvolvedor;

    public FrmInicio(
        IServicoJson servicoJson,
        IServicoCriptografia servicoCriptografia,
        IServicoCaixas servicoCaixas,
        IServicoTerminais servicoTerminais,
        IServicoDesenvolvedor desenvolvedor)
    {
        InitializeComponent();

        this.servicoJson = servicoJson
            ?? throw new ArgumentNullException(nameof(servicoJson));

        this.servicoCriptografia = servicoCriptografia
            ?? throw new ArgumentNullException(nameof(servicoCriptografia));

        this.servicoCaixas = servicoCaixas
            ?? throw new ArgumentNullException(nameof(servicoCaixas));

        this.servicoTerminais = servicoTerminais
            ?? throw new ArgumentNullException(nameof(servicoTerminais));

        this.servicoDesenvolvedor = desenvolvedor
            ?? throw new ArgumentNullException(nameof(desenvolvedor));
    }

    private long? AbrirCaixa()
    {
        if (!VerificarTerminalConfigurado())
            return default;

        var caixa = servicoCaixas.ObterCaixaResumidoPeloUsuarioId_TerminalId_Aberto(
            UsuarioId,
            TerminalId);

        return VerificarCaixaAberto(caixa)?.Id;

        Caixa? VerificarCaixaAberto(Caixa? caixa)
        {
            while (true)
            {
                if (caixa is null)
                {
                    if (this.ExibirMensagemSimNao("O caixa não foi aberto.\n\nDeseja abrir o caixa?", "Caixa fechado"))
                    {
                        using var frmCaixaAbertura = ProvedorServicos.FrmCaixaAbertura();

                        frmCaixaAbertura.DefinirUsuarioId(UsuarioId);
                        frmCaixaAbertura.DefinirTerminalId(TerminalId);

                        if (frmCaixaAbertura.ShowDialog(this, DialogResult.OK))
                            caixa = frmCaixaAbertura.Caixa;
                    }
                    else
                    {
                        this.ExibirMensagem("O caixa não foi aberto.", "Caixa fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return default;
                    }
                }
                else
                    return caixa;
            }
        }

        bool VerificarTerminalConfigurado()
        {
            var terminal = servicoTerminais.ObterTerminalVinculado();

            if (terminal is null)
            {
                this.ExibirMensagem("Não foi possível completar a operação, pois terminal não foi configurado e vinculado.", "Terminal não foi configurado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }
    }

    private void AbrirFrenteCaixa(long caixaId, Venda? venda = default)
    {
        using var frmFrenteCaixa = ProvedorServicos.FrmFrenteCaixa();

        frmFrenteCaixa.DefinirCaixaId(caixaId);
        frmFrenteCaixa.DefinirFuncionarioId(FuncionarioId);

        if (venda is not null)
            frmFrenteCaixa.DefinirVenda(venda);

        frmFrenteCaixa.ShowDialog(this);
    }

    private void AbrirCadastrosClientes_Click(object sender, EventArgs e)
    {
        using var frm = ProvedorServicos.FrmCadastroClientes();

        frm.ShowDialog(this);
    }

    private void AbrirCadastrosFuncionarios_Click(object sender, EventArgs e)
    {
        using var frm = ProvedorServicos.FrmCadastroFuncionarios();

        frm.ShowDialog(this);
    }

    private void AbrirCadastrosFornecedores_Click(object sender, EventArgs e)
    {
        using var frm = ProvedorServicos.FrmCadastroFornecedores();

        frm.ShowDialog(this);
    }

    private void AbrirCadastrosCargos_Click(object sender, EventArgs e)
    {
        using var frm = ProvedorServicos.FrmCadastroCargos();

        frm.ShowDialog(this);
    }

    private void AbrirCadastrosProdutos_Click(object sender, EventArgs e)
    {
        using var frm = ProvedorServicos.FrmCadastroProdutos();

        frm.ShowDialog(this);
    }

    private void EmpresasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var frm = ProvedorServicos.FrmCadastroEmpresas();

        frm.ShowDialog(this);
    }

    private void TransportadorasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var frm = ProvedorServicos.FrmConsultaAvancadaTransportadoras();

        frm.ShowDialog(this);
    }

    private void TsmiCaixa_Click(object sender, EventArgs e)
    {
        try
        {
            var caixaId = AbrirCaixa();

            if (caixaId.HasValue)
            {
                var frm = ProvedorServicos.FrmCaixa();

                frm.DefinirCaixaId(caixaId.Value);
                frm.ShowDialog(this);
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void TsmiPedidos_Click(object sender, EventArgs e)
    {
        try
        {
            var caixaId = AbrirCaixa();

            if (caixaId.HasValue)
            {
                using var frmPedido = ProvedorServicos.FrmPedido();

                frmPedido.DefinirCaixaId(caixaId.Value);
                frmPedido.DefinirFuncionarioId(FuncionarioId);

                frmPedido.ShowDialog(this);

                if (frmPedido.PedidoConvertidoParaVenda)
                    AbrirFrenteCaixa(caixaId.Value, frmPedido.Venda);
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void TsmiFrenteCaixa_Click(object sender, EventArgs e)
    {
        try
        {
            var caixaId = AbrirCaixa();

            if (caixaId.HasValue)
                AbrirFrenteCaixa(caixaId.Value);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void ManutencaoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var caixaId = AbrirCaixa();

            if (caixaId.HasValue)
            {
                using var frm = ProvedorServicos.FrmFrenteCaixaManutencao();

                frm.DefinirCaixaId(caixaId.Value);

                frm.ShowDialog(this);
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void EntradaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var frm = ProvedorServicos.FrmEntrada();

        frm.ShowDialog(this);
    }

    private void TerminalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var frm = ProvedorServicos.FrmTerminal();

        frm.ShowDialog(this);
    }

    private void FrmInicio_Load(object sender, EventArgs e)
    {
        tsmiDesenvolvedor.Visible = EmDesenvolvimento;
    }

    private void ConvêniosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var frm = ProvedorServicos.FrmClienteConvenio();

        frm.ShowDialog(this);
    }

    private void BancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        => this.ExibirMensagemNaoImplementado();

    private void TsmiDesenvolvedor_Click(object sender, EventArgs e)
    {

    }

    private void TsmiTrocarUsuario_Click(object sender, EventArgs e)
    {
        if (this.ExibirMensagemSimNao("Tem certeza que deseja fechar?\nSerá necessário autenticar novamente.", "Confirmar fechamento"))
            Close();
    }

    private void TsmiDesenvolvedorInvalidarToken_Click(object sender, EventArgs e)
    {
        try
        {
            if (Program.Token is not null)
            {
                var token = servicoDesenvolvedor.Desautenticar(Program.Token);

                Program.Token = token.Token;
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void TsmiUtilitariosControleItens_Click(object sender, EventArgs e)
    {
        using var frm = ProvedorServicos.FrmControleItens();

        frm.ShowDialog(this);
    }
}