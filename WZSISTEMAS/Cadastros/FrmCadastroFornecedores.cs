using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Servicos.Interfaces;
using WZSISTEMAS.Base.NotaFiscal.Valores;
using WZSISTEMAS.Base.Servicos.Interfaces;
using WZSISTEMAS.Base.Valores;
using WZSISTEMAS.Consultas;
using WZSISTEMAS.Dados.Entidades;
using WZSISTEMAS.Dados.Servicos.Interfaces;
using WZSISTEMAS.WinForms.Helpers;

namespace WZSISTEMAS.Cadastros;

public partial class FrmCadastroFornecedores : Form
{
    private readonly IServicoFornecedores servicoEntidades;
    private readonly ServicoNFe servicoServicoNFe;
    private readonly IServicoConsultaCEP servicoConsultaCEP;

    private long id;
    private CadastroModos modo;

    public FrmCadastroFornecedores(
        IServicoFornecedores servicoEntidades,
        ServicoNFe servicoNFe,
        IServicoConsultaCEP servicoConsultaCEP)
    {
        InitializeComponent();

        this.servicoEntidades = servicoEntidades
            ?? throw new ArgumentNullException(nameof(servicoEntidades));

        this.servicoServicoNFe = servicoNFe
            ?? throw new ArgumentNullException(nameof(servicoNFe));

        this.servicoConsultaCEP = servicoConsultaCEP
            ?? throw new ArgumentNullException(nameof(servicoConsultaCEP));
    }

    private void DefinirModo(CadastroModos modo)
    {
        this.modo = modo;

        DesativarAcoesBotoes();

        if (modo == CadastroModos.Padrao)
        {
            DefinirBusca(true);
            DefinirCampos(false);

            RedefinirCampos();

            btnNovo.Ativar();
            btnImportarXml.Ativar();
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
        else
        {
            DefinirBusca(true);
            DefinirCampos(false);

            btnEditar.Ativar();
            btnExcluir.Ativar();
            btnCancelar.Ativar();
        }

       void DesativarAcoesBotoes()
        {
            btnNovo.Desativar();
            btnEditar.Desativar();
            btnExcluir.Desativar();
            btnSalvar.Desativar();
            btnCancelar.Desativar();

            btnImportarXml.Desativar();
        }
    }

    private void DefinirBusca(bool habilitar)
        => gbxBusca.Enabled = habilitar;

    private void DefinirCampos(bool habilitar)
    {
        tbpDadosPrincipais.Enabled = habilitar;
        tbpLocalizacao.Enabled = habilitar;
        tbpEmitenteContato.Enabled = habilitar;
    }

    private void RedefinirCampos()
    {
        id = 0;

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
        cbbxUF.SelectedValue = UFs.SP;

        txtTelefone1.Clear();
        txtTelefone2.Clear();
        txtTelefone3.Clear();

        txtEmail.Clear();
    }

    private void PreencherCadastro(Fornecedor entidade)
    {
        entidade.Id = id;

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

    private void PreencherTela(Fornecedor entidade)
    {
        id = entidade.Id;

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
        cbbxUF.SelectedValue = entidade.UF;

        txtTelefone1.Text = entidade.Telefone;
        txtTelefone2.Text = entidade.Telefone2;
        txtTelefone3.Text = entidade.Telefone3;

        txtEmail.Text = entidade.Email;
    }

    private void AtualizarEmitente(Fornecedor fornecedor, Emitente emitente)
    {
        fornecedor.RazaoSocial = emitente.NomeOuRazaoSocial;
        fornecedor.CNPJ = emitente.CPF_CNPJ;
        fornecedor.InscricaoEstadual = emitente.IE;

        fornecedor.Logradouro = emitente.Endereco.Logradouro;
        fornecedor.LogradouroNumero = emitente.Endereco.LogradouroNumero;
        fornecedor.Complemento = emitente.Endereco.Complemento;

        fornecedor.CEP = emitente.Endereco.CEP;
        fornecedor.Bairro = emitente.Endereco.Bairro;
        fornecedor.Cidade = emitente.Endereco.Cidade;
        fornecedor.UF = emitente.Endereco.UF;

        fornecedor.Telefone = emitente.Endereco.Telefone;
    }

    private void CadastroNaoEncontrado()
    {
        RedefinirCampos();

        DefinirModo(CadastroModos.Padrao);

        this.ExibirMensagemCadastroNaoEncontrado();
    }

    private void PreencherResultado(Fornecedor? entidade)
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

            txtBuscarCNPJ.Text = entidade.CNPJ;

            DefinirModo(CadastroModos.Visualizar);
        }
    }

    private void LimparTudoESelecionar()
    {
        servicoEntidades.DescartarAlteracoes();

        txtBuscarCNPJ.Selecionar();
    }

    private void FrmCadastroFornecedores_Load(object sender, EventArgs e)
    {
        DefinirModo(CadastroModos.Padrao);

        cbbxUF.Configurar(UFsHelpers.ObterLista());
    }

    private void TxtBuscarCNPJ_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar)
            && !string.IsNullOrWhiteSpace(txtBuscarCNPJ.Text))
        {
            e.Handled = true;

            try
            {
                var entidade = servicoEntidades.ObterPorCNPJ(txtBuscarCNPJ.Text);

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
            using var frm = new FrmConsultaAvancadaFornecedores(servicoEntidades);

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
            var entidade = new Fornecedor();

            PreencherCadastro(entidade);

            if (!this.ValidarEntidade(servicoEntidades, entidade))
                return;

            servicoEntidades.Criar(entidade);
            servicoEntidades.SalvarAlteracoes();

            id = entidade.Id;

            DefinirModo(CadastroModos.Visualizar);

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

    private void BtnImportarXml_Click(object sender, EventArgs e)
    {
        try
        {
            var frm = new OpenFileDialog()
            {
                Title = "Selecione um arquivo xml de uma nota fiscal",
                DefaultExt = "xml",
                Filter = "Arquivo xml (*.xml)|*.xml|Todos os arquivos (*.*)|*.*",
                AddExtension = true,
            };

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var nFe = servicoServicoNFe.LerEConverterParaNFe(frm.FileName);

                if (nFe is null)
                    this.ExibirMensagemErro(
                        "Um erro ocorreu ao importar o arquivo xml da nota fiscal",
                        "Erro interno");
                else if (nFe.InformacoesNFe.Destinatario.DestinatarioTipoCPF_CNPJ == DestinatarioTiposCPF_CNPJ.CPF)
                    this.ExibirMensagemErro(
                        "O destinatario da nota fiscal é uma pessoa física.",
                        "Destinatário é pessoa física",
                        icone: MessageBoxIcon.Warning);
                else
                {
                    var fornecedor = servicoEntidades.ObterPorCNPJ(nFe.InformacoesNFe.Destinatario.CPF_CNPJ);

                    var emitente = nFe.InformacoesNFe.Emitente;

                    if (fornecedor is not null)
                    {
                        if (this.ExibirMensagemSimNao("O fornecedor correspondente CNPJ do emitente da nota fiscal foi encontrado. \n\nDeseja atualizar os dados do fornecedor de acordo com os dados da nota fiscal?", "Fornecedor encontrado"))
                        {
                            AtualizarEmitente(fornecedor, emitente);
                            PreencherTela(fornecedor);
                            DefinirModo(CadastroModos.Editar);
                        }
                        else
                        {
                            PreencherTela(fornecedor);
                            DefinirModo(CadastroModos.Visualizar);
                        }

                        txtBuscarCNPJ.Text = fornecedor.CNPJ;
                    }
                    else
                    {
                        fornecedor = new();

                        AtualizarEmitente(fornecedor, emitente);

                        PreencherTela(fornecedor);
                        DefinirModo(CadastroModos.Novo);
                    }
                }
            }
        }
        catch (InvalidOperationException erro)
        {
            if (erro.Source == "System.Private.Xml")
                this.ExibirMensagemErro("O arquivo xml informado da nota fiscal não é válido.", "Arquivo xml não é válido");
            else
                this.ExibirMensagemErro(erro);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
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
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }
}
