namespace WZSISTEMAS.Cadastros;

public partial class FrmCadastroCargos : Form
{
    private readonly IServicoCargos servicoEntidades;

    private long id;

    private CadastroModos modo;

    public FrmCadastroCargos(
        IServicoCargos servicoEntidades)
    {
        InitializeComponent();

        this.servicoEntidades = servicoEntidades 
            ?? throw new ArgumentNullException(nameof(servicoEntidades));
    }

    private void DefinirModo(CadastroModos modo)
    {
        this.modo = modo;

        DesativarBotoesAcoes();

        if (modo == CadastroModos.Padrao)
        {
            DefinirBusca(true);
            DefinirCampos(false);

            RedefinirCampos();

            btnNovo.Ativar();
        }
        else if (modo == CadastroModos.Editar
            || modo == CadastroModos.Novo)
        {
            DefinirBusca(false);
            DefinirCampos(true);

            btnSalvar.Ativar();
            btnCancelar.Ativar();

            txtNome.Selecionar();
        }
        else
        {
            DefinirBusca(true);
            DefinirCampos(false);

            btnEditar.Ativar();
            btnExcluir.Ativar();
            btnCancelar.Ativar();
        }

       void DesativarBotoesAcoes()
        {
            btnNovo.Ativar();
            btnEditar.Ativar();
            btnExcluir.Ativar();
            btnSalvar.Ativar();
            btnCancelar.Ativar();
        }
    }

    private void DefinirBusca(bool habilitar)
    {
        gbxConsulta.Enabled = habilitar;
        gbxCadastros.Enabled = habilitar;
    }

    private void DefinirCampos(bool habilitar) 
        => gbxDados.Enabled = habilitar;

    private void RedefinirCampos()
    {
        id = 0;

        txtNome.Clear();
        txtDescricao.Clear();
    }

    private void PreencherCadastro(Cargo entidade)
    {
        entidade.Id = id;

        entidade.Nome = txtNome.Text;
        entidade.Descricao = txtDescricao.Text;
    }

    private void PreencherTela(Cargo cargo)
    {
        id = cargo.Id;

        txtNome.Text = cargo.Nome;
        txtDescricao.Text = cargo.Descricao;
    }

    private void PreencherCadastros(IEnumerable<Cargo> entidades)
    {
        foreach (var entidade in entidades)
            dgvCadastros.Adicionar(entidade.Id, entidade.Nome);
    }

    private void CadastroNaoEncontrado()
    {
        RedefinirCampos();

        DefinirModo(CadastroModos.Padrao);

        this.ExibirMensagemCadastroNaoEncontrado();
    }

    private void PreencherResultado(Cargo? entidade)
    {
        if (entidade is null)
        {
            RedefinirCampos();

            DefinirModo(CadastroModos.Padrao);

            this.ExibirMensagemPesquisaSemResultados();
        }
        else
        {
            PreencherTela(entidade);

            DefinirModo(CadastroModos.Visualizar);
        }
    }

    private void PreencherResultados(IEnumerable<Cargo> entidades)
    {
        dgvCadastros.Rows.Clear();

        if (!entidades.Any())
        {
            RedefinirCampos();

            DefinirModo(CadastroModos.Padrao);

            this.ExibirMensagemPesquisaSemResultados();
        }
        else
        {
            PreencherCadastros(entidades);

            DefinirModo(CadastroModos.Visualizar);
        }
    }

    private void LimparTudoESelecionar()
    {
        servicoEntidades.DescartarAlteracoes();

        txtBuscarPorNome.Selecionar();
    }

    private void FrmCadastroCargos_Load(object sender, EventArgs e)
        => DefinirModo(CadastroModos.Padrao);

    private void TxtBuscarPorNome_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.VerificarTeclaEnter()
            && !string.IsNullOrWhiteSpace(txtBuscarPorNome.Text))
        {
            try
            {
                var entidades = servicoEntidades.ObterTudoPorNome(txtBuscarPorNome.Text);

                PreencherResultados(entidades);
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
            finally
            {
                LimparTudoESelecionar();
            }
        }
    }

    private void BtnNovo_Click(object sender, EventArgs e)
        => DefinirModo(CadastroModos.Novo);

    private void BtnEditar_Click(object sender, EventArgs e) 
        => DefinirModo(CadastroModos.Editar);

    private void BtnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.ExibirMensagemExcluirCadastroConfirmar())
            {
                servicoEntidades.ExcluirPeloId(id);

                DefinirModo(CadastroModos.Padrao);

                this.ExibirMensagemCadastroExcluido();
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            LimparTudoESelecionar();
        }
    }

    private void BtnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            if (modo == CadastroModos.Novo)
                SalvarNovo();
            else
                SalvarEditar();
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            LimparTudoESelecionar();
        }

        void SalvarNovo()
        {
            var entidade = new Cargo();

            PreencherCadastro(entidade);

            servicoEntidades.Criar(entidade);
            servicoEntidades.SalvarAlteracoes();

            DefinirModo(CadastroModos.Padrao);

            this.ExibirMensagemCadastroSalvo();
        }

        void SalvarEditar()
        {
            var entidade = servicoEntidades.ObterPorId(id, true);

            if (entidade is null)
                CadastroNaoEncontrado();
            else
            {
                PreencherCadastro(entidade);

                servicoEntidades.Editar(entidade);
                servicoEntidades.SalvarAlteracoes();

                DefinirModo(CadastroModos.Visualizar);

                this.ExibirMensagemCadastroSalvo();
            }
        }
    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {
        try
        {
            if (modo == CadastroModos.Novo)
                DefinirModo(CadastroModos.Padrao);
            else if (modo == CadastroModos.Editar)
                CancelarEditar();
            else if (modo == CadastroModos.Visualizar)
                DefinirModo(CadastroModos.Padrao);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            LimparTudoESelecionar();
        }

        void CancelarEditar()
        {
            var entidade = servicoEntidades.ObterPorId(id);

            if (entidade is null)
                this.ExibirMensagemPesquisaSemResultados();
            else
            {
                PreencherTela(entidade);

                DefinirModo(CadastroModos.Visualizar);
            }
        }
    }

    private void BtnVoltar_Click(object sender, EventArgs e)
        => Close();

    private void DgvCadastros_SelectionChanged(object sender, EventArgs e)
    {
        try
        {
            if (dgvCadastros.SelectedRows.Count > 0)
            {
                var entidade = servicoEntidades.ObterPorId(
                    dgvCadastros.ConverterPrimeiroSelecionado<long>());

                PreencherResultado(entidade);
            }
            else
            {
                RedefinirCampos();
                DefinirModo(CadastroModos.Padrao);
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            LimparTudoESelecionar();
        }
    }
}
