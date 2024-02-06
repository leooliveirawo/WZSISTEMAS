using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.Valores;
using WZSISTEMAS.Consultas;
using WZSISTEMAS.Dados.Entidades;
using WZSISTEMAS.Dados.Servicos.Interfaces;
using WZSISTEMAS.Helpers;
using WZSISTEMAS.WinForms.Helpers;

namespace WZSISTEMAS.Cadastros;

public partial class FrmCadastroEmpresas : Form
{
    private readonly IServicoEmpresas servicoEntidades;

    private long id;
    private CadastroModos modo;

    public FrmCadastroEmpresas(IServicoEmpresas servicoEntidades)
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

            txtRazaoSocial.Selecionar();
        }
        else if (modo == CadastroModos.Visualizar)
        {
            DefinirBusca(true);
            DefinirCampos(false);

            btnEditar.Ativar();
            btnExcluir.Ativar();
            btnCancelar.Ativar();
        }

       void DesativarBotoesAcoes()
        {
            btnNovo.Desativar();
            btnEditar.Desativar();
            btnExcluir.Desativar();
            btnSalvar.Desativar();
            btnCancelar.Desativar();
        }
    }

    private void DefinirBusca(bool habilitar)
        => gbxBusca.Enabled = habilitar;

    private void DefinirCampos(bool habilitar)
    {
        tbpDadosPrincipais.Enabled = habilitar;
        tbpLocalizacao.Enabled = habilitar;
        tbpContato.Enabled = habilitar;
    }

    private void RedefinirCampos()
    {
        id = 0;

        txtCodigoReferencia.Clear();
        txtRazaoSocial.Clear();
        txtCNPJ.Clear();
        txtInscricaoEstadual.Clear();

        txtLogradouro.Clear();
        txtLogradouroNumero.Clear();
        txtComplemento.Clear();
        txtReferencia.Clear();
        txtCEP.Clear();
        txtBairro.Clear();
        txtCidade.Clear();
        cbbxUF.Definir(UFs.SP);

        txtTelefone1.Clear();
        txtTelefone2.Clear();
        txtTelefone3.Clear();

        txtEmail.Clear();
    }

    private void PreencherCadastro(Empresa entidade)
    {
        entidade.Id = id;

        entidade.CodigoReferencia = txtCodigoReferencia.Text;
        entidade.RazaoSocial = txtRazaoSocial.Text;
        entidade.CNPJ = txtCNPJ.Text;
        entidade.InscricaoEstadual = txtInscricaoEstadual.Text;

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

    private void PreencherTela(Empresa entidade)
    {
        id = entidade.Id;

        txtCodigoReferencia.Text = entidade.CodigoReferencia;
        txtRazaoSocial.Text = entidade.RazaoSocial;
        txtCNPJ.Text = entidade.CNPJ;
        txtInscricaoEstadual.Text = entidade.InscricaoEstadual;

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
    }

    private void PreencherResultado(Empresa? entidade)
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

            txtBuscarCNPJOuCodigoReferencia.Text = entidade.CNPJ;

            DefinirModo(CadastroModos.Visualizar);
        }
    }

    private void LimparTudoESelecionar()
    {
        servicoEntidades.DescartarAlteracoes();

        txtBuscarCNPJOuCodigoReferencia.Selecionar();
    }

    private void FrmCadastroEmpresas_Load(object sender, EventArgs e)
    {
        cbbxUF.Configurar(UFsHelpers.ObterLista());

        DefinirModo(CadastroModos.Padrao);
    }

    private void TxtBuscarCNPJOuCodigoReferencia_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar)
            && !string.IsNullOrWhiteSpace(txtBuscarCNPJOuCodigoReferencia.Text))
        {
            e.Handled = true;

            try
            {
                var entidade = servicoEntidades.ObterPorCNPJOuCodigoReferencia(txtBuscarCNPJOuCodigoReferencia.Text);

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

    private void BtnBuscarConsultaAvancada_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmConsultaAvancadaEmpresas();

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
            servicoEntidades.DescartarAlteracoes();

            this.ExibirMensagemErro(erro);
        }
        finally
        {
            LimparTudoESelecionar();
        }

        void SalvarNovo()
        {
            var entidade = new Empresa();

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

       void CadastroNaoEncontrado()
        {
            RedefinirCampos();

            DefinirModo(CadastroModos.Padrao);

            this.ExibirMensagemCadastroNaoEncontrado();
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
}
