using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.Servicos.Interfaces;
using WZSISTEMAS.Base.Valores;
using WZSISTEMAS.Dados.Entidades;
using WZSISTEMAS.Dados.Helpers;
using WZSISTEMAS.Dados.Servicos.Interfaces;
using WZSISTEMAS.Dados.Valores;
using WZSISTEMAS.Helpers;
using WZSISTEMAS.WinForms.Helpers;

namespace WZSISTEMAS.Cadastros;

public partial class FrmCadastroClientes : Form
{
    private readonly IServicoUsuarios servicoUsuarios;
    private readonly IServicoClientes servicoEntidades;
    private readonly IServicoClientesLancamentos servicoClientesTitulos;
    private readonly IServicoConsultaCEP servicoConsultaCEP;

    private long id;

    private CadastroModos modo;

    public FrmCadastroClientes(
        IServicoUsuarios servicoUsuarios,
        IServicoClientes servicoEntidades,
        IServicoClientesLancamentos servicoClientesTitulos,
        IServicoConsultaCEP servicoConsultaCEP)
    {
        InitializeComponent();

        this.servicoUsuarios = servicoUsuarios
            ?? throw new ArgumentNullException(nameof(servicoUsuarios));

        this.servicoEntidades = servicoEntidades
            ?? throw new ArgumentNullException(nameof(servicoEntidades));

        this.servicoClientesTitulos = servicoClientesTitulos
            ?? throw new ArgumentNullException(nameof(servicoClientesTitulos));

        this.servicoConsultaCEP = servicoConsultaCEP
            ?? throw new ArgumentNullException(nameof(servicoConsultaCEP));
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

            txtBuscarCPF_CNPJ.Selecionar();
        }
        else if (modo == CadastroModos.Editar
            || modo == CadastroModos.Novo)
        {
            DefinirBusca(false);
            DefinirCampos(true);

            btnSalvar.Ativar();
            btnCancelar.Ativar();

            if (modo == CadastroModos.Editar)
                chbxAlterarConvenioDiaFechamentoVencimento.Show();
            else
                chbxAlterarConvenioDiaFechamentoVencimento.Marcar();

            txtNomeCompleto_RazaoSocial.Selecionar();
        }
        else
        {
            DefinirBusca(true);
            DefinirCampos(false);

            btnEditar.Ativar();
            btnExcluir.Ativar();
            btnCancelar.Ativar();

            chbxAlterarConvenioDiaFechamentoVencimento.Show();
        }

       void DesativarBotoesAcoes()
        {
            btnNovo.Desativar();
            btnEditar.Desativar();
            btnExcluir.Desativar();
            btnSalvar.Desativar();
            btnCancelar.Desativar();

            chbxAlterarConvenioDiaFechamentoVencimento.Hide();
            chbxAlterarConvenioDiaFechamentoVencimento.Desmarcar();
        }
    }

    private void DefinirBusca(bool habilitar)
        => gbxBusca.Enabled = habilitar;

    private void DefinirCampos(bool habilitar)
    {
        tbpDadosPrincipais.Enabled = habilitar;
        tbpLocalizacao.Enabled = habilitar;
        tbpContato.Enabled = habilitar;
        tbpConvenio.Enabled = habilitar;
    }

    private void RedefinirCampos()
    {
        id = 0;

        cbbxTipo.SelectedValue = TipoCliente.PessoaFisica;

        txtNomeCompleto_RazaoSocial.Clear();
        txtCPF_CNPJ.Clear();
        txtRG_InscricaoEstadual.Clear();
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

        cbbxConvenioDiaVencimentoFechamento.Definir(DiaDeFechamentoEVencimento.Dia1_8);

        rbtnConvenioModoInativo.Checked = true;

        txtConvenioLimite.Clear();
    }

    private void PreencherCadastro(Cliente entidade)
    {
        entidade.Id = id;

        entidade.Tipo = cbbxTipo.Converter<TipoCliente>();

        entidade.NomeCompleto_RazaoSocial = txtNomeCompleto_RazaoSocial.Text;
        entidade.CPF_CNPJ = txtCPF_CNPJ.Text;
        entidade.RG_INSCRICAO_ESTADUAL = txtRG_InscricaoEstadual.ObterStringNula();

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

        entidade.ConvenioAtivo = rbtnConvenioModoAtivo.Checked;
        entidade.ConvenioInativo = rbtnConvenioModoInativo.Checked;
        entidade.ConvenioBloqueado = rbtnConvenioModoBloqueado.Checked;

        entidade.FaturaDiaFechamentoVencimento = cbbxConvenioDiaVencimentoFechamento.Converter<DiaDeFechamentoEVencimento>();

        entidade.ConvenioLimite = txtConvenioLimite.ConverterParaDecimalNulo();
    }

    private void PreencherTela(Cliente entidade)
    {
        id = entidade.Id;

        cbbxTipo.Definir(entidade.Tipo);
        txtNomeCompleto_RazaoSocial.Text = entidade.NomeCompleto_RazaoSocial;
        txtCPF_CNPJ.Text = entidade.CPF_CNPJ;
        txtRG_InscricaoEstadual.Text = entidade.RG_INSCRICAO_ESTADUAL;

        if (entidade.DataNascimento.HasValue)
            dtpDataNascimento.Value = entidade.DataNascimento.Value;

        txtLogradouro.Text = entidade.Logradouro;
        txtLogradouroNumero.Text = entidade.LogradouroNumero;
        txtComplemento.Text = entidade.Complemento;
        txtReferencia.Text = entidade.Referencia;
        txtCEP.Text = entidade.CEP;
        txtBairro.Text = entidade.Bairro;
        txtCidade.Text = entidade.Cidade;
        cbbxUF.Definir(entidade.UF);

        txtTelefone1.Text = entidade.Telefone;
        txtTelefone2.Text = entidade.Telefone2;
        txtTelefone3.Text = entidade.Telefone3;

        txtEmail.Text = entidade.Email;

        cbbxConvenioDiaVencimentoFechamento.Definir(entidade.FaturaDiaFechamentoVencimento);

        rbtnConvenioModoAtivo.Checked = entidade.ConvenioAtivo;
        rbtnConvenioModoInativo.Checked = entidade.ConvenioInativo;
        rbtnConvenioModoBloqueado.Checked = entidade.ConvenioBloqueado;

        txtConvenioLimite.Text = entidade.ConvenioLimite?.ToString();
    }

    private void CadastroNaoEncontrado()
    {
        RedefinirCampos();

        DefinirModo(CadastroModos.Padrao);

        this.ExibirMensagemCadastroNaoEncontrado();
    }

    private void PreencherResultado(Cliente? entidade)
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

            txtCPF_CNPJ.Text = entidade.CPF_CNPJ;

            DefinirModo(CadastroModos.Visualizar);
        }
    }

    private void LimparTudoESelecionar()
    {
        servicoEntidades.DescartarAlteracoes();

        txtBuscarCPF_CNPJ.Selecionar();
    }

    private void FrmCadastroClientes_Load(object sender, EventArgs e)
    {
        cbbxTipo.Configurar(TipoClienteHelper.ObterLista());
        cbbxUF.Configurar(UFsHelpers.ObterLista());
        cbbxConvenioDiaVencimentoFechamento.Configurar(DiaFechamentoEVencimentoHelper.ObterLista());

        DefinirModo(CadastroModos.Padrao);

        cbbxConvenioDiaVencimentoFechamento.Desativar();
    }

    private void TxtBuscarCPF_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar)
            && !string.IsNullOrWhiteSpace(txtBuscarCPF_CNPJ.Text))
        {
            e.Handled = true;

            if (this.VerificarAutenticacao(servicoUsuarios))
            {
                try
                {
                    var entidade = servicoEntidades.ObterPorCPF_CNPJ(txtBuscarCPF_CNPJ.Text);

                    PreencherResultado(entidade);
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
    }

    private void BtnBuscarConsultaAvancada_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmConsultaAvancadaClientes();

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
            LimparTudoESelecionar();
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
            var entidade = new Cliente();

            PreencherCadastro(entidade);

            if (this.ValidarEntidade(servicoEntidades, entidade))
            {
                servicoEntidades.Criar(entidade);
                servicoEntidades.SalvarAlteracoes();

                DefinirModo(CadastroModos.Padrao);

                this.ExibirMensagemCadastroSalvo();
            }
        }

        void SalvarEditar()
        {
            var entidade = servicoEntidades.ObterPorId(id, true);

            if (entidade is null)
                CadastroNaoEncontrado();
            else
            {
                PreencherCadastro(entidade);

                if (this.ValidarEntidade(servicoEntidades, entidade))
                {
                    servicoEntidades.Editar(entidade);
                    servicoEntidades.SalvarAlteracoes();

                    DefinirModo(CadastroModos.Visualizar);

                    this.ExibirMensagemCadastroSalvo();
                }
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
            else
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

    private void ChbxNaoInformarDataNascimento_CheckedChanged(object sender, EventArgs e)
    {
        dtpDataNascimento.Value = DateTime.Now;
        dtpDataNascimento.Enabled = !chbxNaoInformarDataNascimento.Checked;
    }

    private void CbbxTipo_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbbxTipo.Comparar(TipoCliente.PessoaJuridica))
        {
            dtpDataNascimento.Desativar();

            chbxNaoInformarDataNascimento.Desmarcar();
            chbxNaoInformarDataNascimento.Desativar();
        }
        else
        {
            dtpDataNascimento.Ativar();

            chbxNaoInformarDataNascimento.Ativar();
        }
    }

    private void ChbxAlterarConvenio_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (modo == CadastroModos.Editar
                && chbxAlterarConvenioDiaFechamentoVencimento.Checked)
            {
                if (servicoClientesTitulos.VerificarLancamentosEmAberto(id))
                {
                    chbxAlterarConvenioDiaFechamentoVencimento.Desmarcar();

                    this.ExibirMensagem("O cliente possui titulos em aberto e não é possível alterar da data de fechamento/vencimento do convenio até que esses titulos sejam pagos.", "Titulos em aberto");

                    return;
                }
            }

            cbbxConvenioDiaVencimentoFechamento.Enabled = chbxAlterarConvenioDiaFechamentoVencimento.Checked;
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            servicoEntidades.DescartarAlteracoes();
        }
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
        catch(Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }
}
