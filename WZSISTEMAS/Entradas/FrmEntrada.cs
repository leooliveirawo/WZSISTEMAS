using WZSISTEMAS.Base.NotaFiscal.Valores;

namespace WZSISTEMAS.Entradas;

public partial class FrmEntrada : Form
{
    private readonly IServicoFornecedores servicoFornecedores;
    private readonly IServicoEmpresas servicoEmpresas;
    private readonly IServicoTransportadoras servicoTransportadoras;
    private readonly ServicoNFe servicoServicoNFe;

    public FrmEntrada(
        IServicoFornecedores servicoFornecedores,
        IServicoEmpresas servicoEmpresas,
        IServicoTransportadoras servicoTransportadoras,
        ServicoNFe servicoNFe)
    {
        InitializeComponent();

        this.servicoFornecedores = servicoFornecedores ?? throw new ArgumentNullException(nameof(servicoFornecedores));
        this.servicoEmpresas = servicoEmpresas ?? throw new ArgumentNullException(nameof(servicoEmpresas));
        this.servicoTransportadoras = servicoTransportadoras ?? throw new ArgumentNullException(nameof(servicoTransportadoras));
        this.servicoServicoNFe = servicoNFe ?? throw new ArgumentNullException(nameof(servicoNFe));
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

    private void AtualizarDestinatario(Empresa empresa, Destinatario destinatario)
    {
        empresa.RazaoSocial = destinatario.NomeOuRazaoSocial;
        empresa.CNPJ = destinatario.CPF_CNPJ;
        empresa.InscricaoEstadual = destinatario.IE;

        empresa.Logradouro = destinatario.Endereco.Logradouro;
        empresa.LogradouroNumero = destinatario.Endereco.LogradouroNumero;
        empresa.Complemento = destinatario.Endereco.Complemento;

        empresa.CEP = destinatario.Endereco.CEP;
        empresa.Bairro = destinatario.Endereco.Bairro;
        empresa.Cidade = destinatario.Endereco.Cidade;
        empresa.UF = destinatario.Endereco.UF;

        empresa.Telefone = destinatario.Endereco.Telefone;
        empresa.Email = destinatario.Email;
    }

    private void PreencherTelaEmitente(Fornecedor fornecedor)
    {
        txtEmitenteCNPJ1.Text = fornecedor.CNPJ;

        txtEmitenteRazaoSocial.Text = fornecedor.RazaoSocial;
        txtEmitenteCNPJ2.Text = fornecedor.CNPJ;
        txtEmitenteInscricaoEstadual.Text = fornecedor.InscricaoEstadual;

        txtEmitenteLogradouro.Text = fornecedor.Logradouro;
        txtEmitenteLogradouroNumero.Text = fornecedor.LogradouroNumero;
        txtEmitenteComplemento.Text = fornecedor.Complemento;
        txtEmitenteReferencia.Text = fornecedor.Referencia;
        txtEmitenteCEP.Text = fornecedor.CEP;
        txtEmitenteBairro.Text = fornecedor.Bairro;
        txtEmitenteCidade.Text = fornecedor.Cidade;
        txtEmitenteUF.Text = UFsHelpers.ConverterParaString(fornecedor.UF);

        txtEmitenteTelefone1.Text = fornecedor.Telefone;
        txtEmitenteTelefone2.Text = fornecedor.Telefone2;
        txtEmitenteTelefone3.Text = fornecedor.Telefone3;

        txtEmitenteEmail.Text = fornecedor.Email;
    }

    private void PreencherTelaDestinatario(Empresa empresa)
    {
        txtDestinatarioCodigoReferencia.Text = empresa.CodigoReferencia;
        txtDestinatarioRazaoSocial.Text = empresa.RazaoSocial;
        txtTransportadoraCNPJ2.Text = empresa.CNPJ;
        txtDestinatarioInscricaoEstadual.Text = empresa.InscricaoEstadual;

        txtDestinatarioLogradouro.Text = empresa.Logradouro;
        txtDestinatarioLogradouroNumero.Text = empresa.LogradouroNumero;
        txtDestinatarioComplemento.Text = empresa.Complemento;
        txtDestinatarioReferencia.Text = empresa.Referencia;
        txtDestinatarioCEP.Text = empresa.CEP;
        txtDestinatarioBairro.Text = empresa.Bairro;
        txtDestinatarioCidade.Text = empresa.Cidade;
        txtEmitenteUF.Text = UFsHelpers.ConverterParaString(empresa.UF);

        txtDestinatarioTelefone1.Text = empresa.Telefone;
        txtDestinatarioTelefone2.Text = empresa.Telefone2;
        txtDestinatarioTelefone3.Text = empresa.Telefone3;

        txtDestinatarioEmail.Text = empresa.Email;
    }

    private void PreencherTelaTransportadora(Transportadora entidade)
    {
        txtTransportadoraCodigoReferencia.Text = entidade.CodigoReferencia;
        txtTransportadoraRazaoSocial.Text = entidade.RazaoSocial;
        txtTransportadoraCNPJ2.Text = entidade.CNPJ;
        txtTransportadoraInscricaoEstadual.Text = entidade.InscricaoEstadual;

        txtTransportadoraLogradouro.Text = entidade.Logradouro;
        txtTransportadoraLogradouroNumero.Text = entidade.LogradouroNumero;
        txtTransportadoraComplemento.Text = entidade.Complemento;
        txtTransportadoraReferencia.Text = entidade.Referencia;
        txtTransportadoraCEP.Text = entidade.CEP;
        txtTransportadoraBairro.Text = entidade.Bairro;
        txtTransportadoraCidade.Text = entidade.Cidade;
        txtTransportadoraUF.Text = UFsHelpers.ConverterParaString(entidade.UF);

        txtTransportadoraTelefone1.Text = entidade.Telefone;
        txtTransportadoraTelefone2.Text = entidade.Telefone2;
        txtTransportadoraTelefone3.Text = entidade.Telefone3;

        txtTransportadoraEmail.Text = entidade.Email;
    }

    private void DefinirCampos(bool habilitar)
    {
        tbpEmitente.Enabled = habilitar;
        tbpDestinatario.Enabled = habilitar;
        tbpTransportadora.Enabled = habilitar;
        tbpItens.Enabled = habilitar;
    }

    private void RedefinirCamposEmitente()
    {
        txtEmitenteCodigoReferencia.Clear();
        txtEmitenteRazaoSocial.Clear();
        txtEmitenteCNPJ2.Clear();
        txtEmitenteInscricaoEstadual.Clear();

        txtEmitenteLogradouro.Clear();
        txtEmitenteLogradouroNumero.Clear();
        txtEmitenteComplemento.Clear();
        txtEmitenteReferencia.Clear();
        txtEmitenteCEP.Clear();
        txtEmitenteBairro.Clear();
        txtEmitenteCidade.Clear();
        txtEmitenteUF.Clear();

        txtEmitenteTelefone1.Clear();
        txtEmitenteTelefone2.Clear();
        txtEmitenteTelefone3.Clear();

        txtEmitenteEmail.Clear();
    }

    private void RedefinirCamposDestinatario()
    {
        txtDestinatarioCodigoReferencia.Clear();
        txtDestinatarioRazaoSocial.Clear();
        txtDestinatarioCNPJ2.Clear();
        txtDestinatarioInscricaoEstadual.Clear();

        txtDestinatarioLogradouro.Clear();
        txtDestinatarioLogradouroNumero.Clear();
        txtDestinatarioComplemento.Clear();
        txtDestinatarioReferencia.Clear();
        txtDestinatarioCEP.Clear();
        txtDestinatarioBairro.Clear();
        txtDestinatarioCidade.Clear();
        txtDestinatarioUF.Clear();

        txtDestinatarioTelefone1.Clear();
        txtDestinatarioTelefone2.Clear();
        txtDestinatarioTelefone3.Clear();

        txtDestinatarioEmail.Clear();
    }

    private void RedefinirCamposTransportadora()
    {
        txtTransportadoraCodigoReferencia.Clear();
        txtTransportadoraRazaoSocial.Clear();
        txtTransportadoraCNPJ2.Clear();
        txtTransportadoraInscricaoEstadual.Clear();

        txtTransportadoraLogradouro.Clear();
        txtTransportadoraLogradouroNumero.Clear();
        txtTransportadoraComplemento.Clear();
        txtTransportadoraReferencia.Clear();
        txtTransportadoraCEP.Clear();
        txtTransportadoraBairro.Clear();
        txtTransportadoraCidade.Clear();
        txtTransportadoraUF.Clear();

        txtTransportadoraTelefone1.Clear();
        txtTransportadoraTelefone2.Clear();
        txtTransportadoraTelefone3.Clear();

        txtTransportadoraEmail.Clear();
    }

    private void FrmEntrada_Load(object sender, EventArgs e)
    {
        tbpEmitenteDadosPrincipais.Enabled = false;
        tbpEmitenteLocalizacao.Enabled = false;
        tbpEmitenteContato.Enabled = false;

        tbpDestinatarioDadosPrincipais.Enabled = false;
        tbpDestinatarioLocalizacao.Enabled = false;
        tbpDestinatarioContato.Enabled = false;

        tbpTransportadoraDadosPrincipais.Enabled = false;
        tbpTransportadoraLocalizacao.Enabled = false;
        tbpTransportadoraContato.Enabled = false;
    }

    private void TxtEmitenteCNPJ1_KeyPress(object sender, KeyPressEventArgs e)
    {
        try
        {
            if (e.VerificarTeclaEnter()
                && !string.IsNullOrWhiteSpace(txtEmitenteCNPJ1.Text))
            {
                var Destinatario = servicoFornecedores.ObterPorCNPJ(txtEmitenteCNPJ1.Text);

                if (Destinatario is null)
                {
                    RedefinirCamposEmitente();

                    servicoFornecedores.DescartarAlteracoes();

                    MessageBox.Show(this, "O Destinatario não foi encontrado.", "Destinatario não encontrado");
                }
                else
                {
                    PreencherTelaEmitente(Destinatario);
                }
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void TxtDestinatarioCNPJ1_KeyPress(object sender, KeyPressEventArgs e)
    {
        try
        {
            if (e.VerificarTeclaEnter()
                && !string.IsNullOrWhiteSpace(txtDestinatarioCNPJ1.Text))
            {
                var remetente = servicoEmpresas.ObterPorCNPJOuCodigoReferencia(txtDestinatarioCNPJ1.Text);

                if (remetente is null)
                {
                    RedefinirCamposDestinatario();

                    servicoEmpresas.DescartarAlteracoes();

                    MessageBox.Show(this, "O remetente não foi encontrado.", "Destinatario não encontrado");
                }
                else
                {
                    PreencherTelaDestinatario(remetente);
                }
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void TxtTransportadoraCNPJ2_KeyPress(object sender, KeyPressEventArgs e)
    {
        try
        {
            if (e.VerificarTeclaEnter()
                && !string.IsNullOrWhiteSpace(txtTransportadoraCNPJ1.Text))
            {
                var transportadora = servicoTransportadoras.ObterPorCNPJOuCodigoReferencia(txtDestinatarioCNPJ1.Text) ?? throw new InvalidOperationException("A transportadora não foi encontrada");

                if (transportadora is null)
                {
                    RedefinirCamposTransportadora();

                    servicoEmpresas.DescartarAlteracoes();

                    MessageBox.Show(this, "A transportadora não foi encontrada.", "Transportadora não encontrada");
                }
                else
                {
                    PreencherTelaTransportadora(transportadora);
                }
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void BtnNovo_Click(object sender, EventArgs e)
    {

    }

    private void BtnSalvar_Click(object sender, EventArgs e)
    {

    }

    private void BtnLancar_Click(object sender, EventArgs e)
    {

    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {

    }

    private void BtnImportar_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = new OpenFileDialog
            {
                DefaultExt = "*xml",
                Filter = "Arquivo xml (*.xml)|*.xml|Todos os arquivos (*.*)|*.*",
                Title = "Importar xml da nota fiscal"
            };

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var caminho = frm.FileName;

                if (caminho is not null)
                {
                    var nFE = servicoServicoNFe.LerEConverterParaNFe(caminho) ?? throw new InvalidOperationException("O XML do NFe não é válido");

                    if (nFE.InformacoesNFe.Emitente.EmitenteTipoCPF_CNPJ == EmitenteTiposCPF_CNPJ.CPF)
                        throw new InvalidOperationException("O emitente é uma pessoa fisica");

                    if (nFE.InformacoesNFe.Destinatario.DestinatarioTipoCPF_CNPJ == DestinatarioTiposCPF_CNPJ.CPF)
                        throw new InvalidOperationException("O destinatario é uma pessoa fisica");

                    var fornecedor = servicoFornecedores.ObterPorCNPJ(nFE.InformacoesNFe.Destinatario.CPF_CNPJ);

                    if (fornecedor is null)
                    {
                        if (MessageBox.Show("O emitente não foi cadastrado e para emitir a nota é necessário cadastrar.\n\nDeseja cadastrar?", "Emitente não cadastrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            fornecedor = new Fornecedor();

                            AtualizarEmitente(fornecedor, nFE.InformacoesNFe.Emitente);

                            servicoFornecedores.Criar(fornecedor);
                            servicoFornecedores.SalvarAlteracoes();

                            servicoFornecedores.DescartarAlteracoes();
                        }
                        else
                        {
                            MessageBox.Show(this, "A nota não será lançada pois o Destinatario não foi cadastrado");

                            return;
                        }
                    }
                    else if (MessageBox.Show(this, "O emitente já está cadastrado.\n\nDeseja atualizar os dados do emitente?", "Atualização cadastral", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AtualizarEmitente(fornecedor, nFE.InformacoesNFe.Emitente);

                        servicoFornecedores.Editar(fornecedor);
                        servicoFornecedores.SalvarAlteracoes();
                        servicoFornecedores.DescartarAlteracoes();
                    }

                    PreencherTelaEmitente(fornecedor);

                    var empresa = servicoEmpresas.ObterPorCNPJOuCodigoReferencia(nFE.InformacoesNFe.Destinatario.CPF_CNPJ);

                    if (empresa is null)
                    {
                        if (MessageBox.Show("O destinatario não foi cadastrado e para emitir a nota é necessário cadastrar.\n\nDeseja cadastrar?", "destinatario não cadastrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            empresa = new Empresa();

                            AtualizarDestinatario(empresa, nFE.InformacoesNFe.Destinatario);

                            servicoEmpresas.Criar(empresa);
                            servicoEmpresas.SalvarAlteracoes();

                            servicoEmpresas.DescartarAlteracoes();
                        }
                        else
                        {
                            MessageBox.Show(this, "A nota não será lançada pois o destinatario não foi cadastrado");

                            return;
                        }

                        PreencherTelaDestinatario(empresa);
                    }
                    else if (MessageBox.Show(this, "O remetente já está cadastrado.\n\nDeseja atualizar os dados do remetente?", "Atualização cadastral", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AtualizarDestinatario(empresa, nFE.InformacoesNFe.Destinatario);

                        servicoEmpresas.Editar(empresa);
                        servicoEmpresas.SalvarAlteracoes();
                        servicoEmpresas.DescartarAlteracoes();
                    }
                }
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }
}
