namespace WZSISTEMAS.Cadastros;

public partial class FrmCadastroFuncionarios : Form
{
    private readonly IServicoFuncionarios servicoEntidades;
    private readonly IServicoCargos servicoCargos;
    private readonly IServicoUsuarios servicoUsuarios;
    private readonly IServicoConsultaCEP servicoConsultaCEP;

    private long id;
    private long usuarioId;

    private CadastroModos modo;
    private CadastroUsuarioModos usuarioModo;

    public FrmCadastroFuncionarios(
        IServicoFuncionarios servicoEntidades,
        IServicoCargos servicoCargos,
        IServicoUsuarios servicoUsuarios,
        IServicoConsultaCEP servicoConsultaCEP)
    {
        InitializeComponent();

        this.servicoEntidades = servicoEntidades
            ?? throw new ArgumentNullException(nameof(servicoEntidades));

        this.servicoCargos = servicoCargos
            ?? throw new ArgumentNullException(nameof(servicoCargos));

        this.servicoUsuarios = servicoUsuarios
            ?? throw new ArgumentNullException(nameof(servicoUsuarios));

        this.servicoConsultaCEP = servicoConsultaCEP
            ?? throw new ArgumentNullException(nameof(servicoConsultaCEP));
    }

    private void DefinirModo(CadastroModos modo)
    {
        this.modo = modo;

        OcultarBotoesAcoes();

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

            tbpUsuario.Show();

            txtNomeCompleto.Focus();
            txtNomeCompleto.SelectAll();
        }
        else
        {
            DefinirBusca(true);
            DefinirCampos(false);

            btnEditar.Ativar();
            btnExcluir.Ativar();
            btnCancelar.Ativar();
        }

       void OcultarBotoesAcoes()
        {
            btnNovo.Desativar();
            btnEditar.Desativar();
            btnExcluir.Desativar();
            btnSalvar.Desativar();
            btnCancelar.Desativar();
        }
    }

    private void DefinirUsuarioModo(CadastroUsuarioModos usuarioModo)
    {
        gbxSenha.Hide();
        gbxAlterarSenha.Hide();
        chbxAlterarSenha.Desmarcar();
        txtNovaSenha.Desativar();
        txtConfirmeNovaSenha.Desativar();

        if (usuarioModo == CadastroUsuarioModos.Novo)
            gbxSenha.Show();
        else
            gbxAlterarSenha.Show();

        this.usuarioModo = usuarioModo;
    }

    private void DefinirBusca(bool habilitar)
    {
        gbxBusca.Enabled = habilitar;
    }

    private void DefinirCampos(bool habilitar)
    {
        tbpDadosPrincipais.Enabled = habilitar;
        tbpLocalizacao.Enabled = habilitar;
        tbpContato.Enabled = habilitar;
        tbpUsuario.Enabled = habilitar;
    }

    private void RedefinirCampos()
    {
        id = 0;
        usuarioId = 0;

        cbbxCargo.DataSource = default;

        txtNomeCompleto.Clear();
        txtCPF.Clear();
        txtRG.Clear();
        dtpDataNascimento.Limpar(DateTime.Now);
        chbxNaoInformarDataNascimento.Limpar();

        txtLogradouro.Clear();
        txtLogradouroNumero.Clear();
        txtComplemento.Clear();
        txtReferencia.Clear();
        txtCEP.Clear();
        txtBairro.Clear();
        txtCidade.Clear();
        cbbxUF.SelectedValue = UFs.SP;

        txtTelefone1.Clear();
        txtTelefone2.Clear();
        txtTelefone3.Clear();

        txtEmail.Clear();

        txtNomeUsuario.Clear();

        RedefinirCamposSenhas();
    }

    private void RedefinirCamposSenhas()
    {
        txtSenha.Clear();
        txtSenhaAtual.Clear();
        txtConfirmeASenha.Clear();
        txtConfirmeNovaSenha.Clear();

        chbxAlterarSenha.Limpar();
    }

    private void PreencherCadastro(Funcionario entidade)
    {
        entidade.Id = id;

        entidade.CargoId = cbbxCargo.Converter<long>();

        entidade.NomeCompleto = txtNomeCompleto.Text;
        entidade.CPF = txtCPF.Text;
        entidade.RG = txtRG.ObterStringNula();

        entidade.DataNascimento = dtpDataNascimento.ObterDateTimeSoDataNulo(chbxNaoInformarDataNascimento.Checked);

        entidade.Logradouro = txtLogradouro.Text;
        entidade.LogradouroNumero = txtLogradouroNumero.ObterStringNula();
        entidade.Complemento = txtComplemento.ObterStringNula();
        entidade.Referencia = txtReferencia.ObterStringNula();

        entidade.CEP = txtCEP.Text;
        entidade.Bairro = txtBairro.Text;
        entidade.Cidade = txtCidade.Text;
        entidade.UF = cbbxUF.Converter<UFs>();

        entidade.Telefone = txtTelefone1.Text;
        entidade.Telefone2 = txtTelefone2.Text;
        entidade.Telefone3 = txtTelefone3.Text;

        entidade.Email = txtEmail.Text;
    }

    private void PreencherCadastro(Usuario entidade)
        => entidade.NomeUsuario = txtNomeUsuario.Text;

    private void PreencherTela(Funcionario entidade)
    {
        PreencherCargos();

        id = entidade.Id;

        txtNomeCompleto.Text = entidade.NomeCompleto;
        txtCPF.Text = entidade.CPF;
        txtRG.Text = entidade.RG;

        cbbxCargo.SelectedValue = entidade.CargoId;

        if (entidade.DataNascimento.HasValue)
        {
            chbxNaoInformarDataNascimento.Ativar();
            chbxNaoInformarDataNascimento.Desmarcar();

            dtpDataNascimento.Value = entidade.DataNascimento.Value;
        }
        else
        {
            chbxNaoInformarDataNascimento.Desativar();
            chbxNaoInformarDataNascimento.Desmarcar();
        }

        txtLogradouro.Text = entidade.Logradouro;
        txtLogradouroNumero.Text = entidade.LogradouroNumero;
        txtComplemento.Text = entidade.Complemento;
        txtReferencia.Text = entidade.Referencia;
        txtCEP.Text = entidade.CEP;
        txtBairro.Text = entidade.Bairro;
        txtCidade.Text = entidade.Cidade;
        cbbxUF.SelectedValue = entidade.UF;

        txtTelefone1.Text = entidade.Telefone;
        txtTelefone2.Text = entidade.Telefone2;
        txtTelefone3.Text = entidade.Telefone3;

        txtEmail.Text = entidade.Email;
    }

    private void PreencherTela(Usuario entidade)
        => txtNomeUsuario.Text = entidade.NomeUsuario;

    private void PreencherCargos()
        => cbbxCargo.Configurar(servicoCargos.ObterListaItens());

    private void CadastroNaoEncontrado()
    {
        RedefinirCampos();

        DefinirModo(CadastroModos.Padrao);

        this.ExibirMensagemCadastroNaoEncontrado();
    }

    private void PreencherResultado(Funcionario? entidade)
    {
        if (entidade is null)
        {
            RedefinirCampos();

            DefinirModo(CadastroModos.Padrao);

            this.ExibirMensagemPesquisaSemResultados();
        }
        else
        {
            var usuario = servicoUsuarios.ObterPorFuncionarioId(entidade.Id);

            PreencherTela(entidade);

            txtBuscarCPF.Text = entidade.CPF;

            DefinirModo(CadastroModos.Visualizar);

            if (usuario is null)
            {
                DefinirUsuarioModo(CadastroUsuarioModos.Novo);

                this.ExibirMensagem("O usuário que corresponda ao funcionário não foi encontrado.\n\nPor favor cadastre-o.", "Usuário não encontrado", icone: MessageBoxIcon.Warning);
            }
            else
            {
                usuarioId = usuario.Id;

                DefinirUsuarioModo(CadastroUsuarioModos.Editar);

                PreencherTela(usuario);
            }
        }
    }

    private void FrmCadastroFuncionarios_Load(object sender, EventArgs e)
    {
        gbxAlterarSenha.Location = gbxSenha.Location;

        cbbxUF.Configurar(UFsHelpers.ObterLista());

        DefinirModo(CadastroModos.Padrao);
    }

    private void TxtBuscarCPF_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.VerificarTeclaEnter()
            && !string.IsNullOrWhiteSpace(txtBuscarCPF.Text))
        {
            try
            {
                var entidade = servicoEntidades.ObterPorCPF(txtBuscarCPF.Text);

                PreencherResultado(entidade);
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
            finally
            {
                servicoEntidades.DescartarAlteracoes();

                txtBuscarCPF.Selecionar();
            }
        }
    }

    private void BtnBuscarConsultaAvancada_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmConsultaAvancadaFuncionarios();

            if (frm.ShowDialog(this, DialogResult.OK))
            {
                var entidade = servicoEntidades.ObterPorId(frm.Id);

                PreencherResultado(entidade);
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            servicoEntidades.DescartarAlteracoes();

            txtBuscarCPF.Selecionar();
        }
    }

    private void BtnNovo_Click(object sender, EventArgs e)
    {
        try
        {
            PreencherCargos();

            DefinirModo(CadastroModos.Novo);
            DefinirUsuarioModo(CadastroUsuarioModos.Novo);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            servicoEntidades.DescartarAlteracoes();

            txtBuscarCPF.Selecionar();
        }
    }

    private void BtnEditar_Click(object sender, EventArgs e)
    {
        DefinirModo(CadastroModos.Editar);
    }

    private void BtnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.ExibirMensagemExcluirCadastroConfirmar())
            {
                servicoEntidades.ExcluirPeloId(id);
                servicoEntidades.DescartarAlteracoes();

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
            servicoEntidades.DescartarAlteracoes();

            txtBuscarCPF.Selecionar();
        }
    }

    private void BtnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            if (modo == CadastroModos.Novo)
            {
                var entidade = new Funcionario();
                var usuario = new Usuario();

                PreencherCadastro(entidade);
                PreencherCadastro(usuario);

                if (this.ValidarEntidade(servicoEntidades, entidade)
                    && this.ValidarEntidade(servicoUsuarios, usuario))
                {
                    servicoEntidades.Criar(entidade);
                    servicoEntidades.SalvarAlteracoes();

                    usuario.FuncionarioId = entidade.Id;

                    servicoUsuarios.Criar(usuario, txtSenha.Text);
                    servicoUsuarios.SalvarAlteracoes();

                    DefinirModo(CadastroModos.Editar);
                    DefinirUsuarioModo(CadastroUsuarioModos.Editar);

                    this.ExibirMensagemCadastroSalvo();
                }
            }
            else
            {
                var entidade = servicoEntidades.ObterPorId(id, true);

                if (entidade is null)
                    CadastroNaoEncontrado();
                else
                {
                    PreencherCadastro(entidade);

                    if (this.ValidarEntidade(servicoEntidades, entidade))
                    {
                        var usuario = servicoUsuarios.ObterPorId(usuarioId, true);

                        var novo = usuario is null;

                        usuario ??= new()
                        {
                            FuncionarioId = id
                        };

                        PreencherCadastro(usuario);

                        if (this.ValidarEntidade(servicoUsuarios, usuario))
                        {
                            if (novo)
                                servicoUsuarios.Criar(usuario);
                            else
                            {
                                if (chbxAlterarSenha.Checked)
                                    servicoUsuarios.Editar(usuario, txtSenhaAtual.Text, txtNovaSenha.Text);
                                else
                                    servicoUsuarios.Editar(usuario);
                            }

                            servicoEntidades.SalvarAlteracoes();

                            DefinirModo(CadastroModos.Visualizar);

                            this.ExibirMensagemCadastroSalvo();
                        }
                    }
                }

                RedefinirCamposSenhas();
                DefinirUsuarioModo(CadastroUsuarioModos.Editar);
            }
        }
        catch (Exception erro)
        {
            servicoEntidades.DescartarAlteracoes();

            this.ExibirMensagemErro(erro);
        }
        finally
        {
            servicoEntidades.DescartarAlteracoes();

            txtBuscarCPF.Selecionar();
        }
    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {
        try
        {
            if (modo == CadastroModos.Novo)
                DefinirModo(CadastroModos.Padrao);
            else if (modo == CadastroModos.Editar)
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
            else if (modo == CadastroModos.Visualizar)
                DefinirModo(CadastroModos.Padrao);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            servicoEntidades.DescartarAlteracoes();

            txtBuscarCPF.Selecionar();
        }
    }

    private void BtnVoltar_Click(object sender, EventArgs e)
        => Close();

    private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmCadastroCargos();

            frm.ShowDialog(this);

            PreencherCargos();
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void ChbxAlterarSenha_CheckedChanged(object sender, EventArgs e)
    {
        txtSenhaAtual.Enabled = chbxAlterarSenha.Checked;
        txtNovaSenha.Enabled = chbxAlterarSenha.Checked;
        txtConfirmeNovaSenha.Enabled = chbxAlterarSenha.Checked;
    }

    private async void BtnConsultarCEP_Click(object sender, EventArgs e)
    {
        try
        {
            if (!string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                var buscaCEP = await servicoConsultaCEP.ObterEnderecoPeloCEPAsync(txtCEP.Text);

                if (buscaCEP is not null)
                {
                    txtCEP.Text = buscaCEP.CEP;

                    txtLogradouro.Text = buscaCEP.Logradouro
                        ?? txtLogradouro.Text;

                    txtBairro.Text = buscaCEP.Bairro
                        ?? txtBairro.Text;

                    txtCidade.Text = buscaCEP.Cidade
                        ?? txtCidade.Text;

                    cbbxUF.Definir(buscaCEP.Estado
                        ?.ConverterDeString()
                        ?? cbbxUF.Converter<UFs>());
                }
                else
                    this.ExibirMensagem("O CEP não foi encontrado.", "CEP não encontrado");
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }
}
