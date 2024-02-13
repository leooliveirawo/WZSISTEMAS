namespace WZSISTEMAS.Cadastros;

public partial class FrmCadastroProdutos : Form
{
    private readonly IServicoProdutos servicoEntidades;
    private readonly IServicoJson servicoJson;
    private long id;

    private CadastroModos modo;

    public FrmCadastroProdutos(
        IServicoProdutos servicoEntidades,
        IServicoJson servicoJson)
    {
        InitializeComponent();

        this.servicoEntidades = servicoEntidades 
            ?? throw new ArgumentNullException(nameof(servicoEntidades));

        this.servicoJson = servicoJson 
            ?? throw new ArgumentNullException(nameof(servicoJson));
    }

    private void DefinirModo(CadastroModos modo)
    {
        this.modo = modo;

        DesativarBotoesAcoes();

        tbcDados.SelectedTab = tbpDadosPrincipais;

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

            txtCodigoBarras.Focus();
            txtCodigoBarras.SelectAll();
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
    {
        gbxBusca.Enabled = habilitar;
    }

    private void DefinirCampos(bool habilitar)
    {
        tbpDadosPrincipais.Enabled = habilitar;
        tbpCustosPrecos.Enabled = habilitar;
        tbpImpostos.Enabled = habilitar;
        tbpPesagemBalanca.Enabled = habilitar;
    }

    private void RedefinirCampos()
    {
        id = 0;

        txtCodigoBarras.Clear();
        txtCodigoReferencia.Clear();
        txtDescricao.Clear();
        txtDescricaoPDV.Clear();
        rbtnProdutoModo_Padrao.Checked = true;

        txtCustoReal.Clear();
        txtMargemLucro.Clear();
        txtPrecoFinal.Clear();

        txtEstoqueAtual.Clear("0");
        txtEstoqueMinimo.Clear("0");
        chbxNotificarEstoqueBaixo.Checked = false;
        chbxGerenciarEstoque.Checked = false;

        cbbxUnidadeMedida.Definir(UnidadesMedidas.Unidade_UNID);
        cbbxTipo.Definir(TipoItem.Produto);

        rbtnModoCustoPreco_SomenteUm.Checked = true;

        txtCustoReal2.Clear();
        txtMargemLucro2.Clear();
        txtPrecoFinal2.Clear();

        txtCustoReal3.Clear();
        txtMargemLucro3.Clear();
        txtPrecoFinal3.Clear();

        txtCodigoAuxiliarBalanca.Clear();
        chbxGerarDadosAuxiliaresBalanca.Checked = false;
        chbxPesar.Checked = false;

        txtNCM.Clear();
        txtCFOP.Clear();

        ctICMS.TipoICMS = TiposICMS.ICMS00;
        ctPIS.TipoPIS = TiposPIS.PISAliq;
        ctCOFINS.TipoCOFINS = TiposCOFINS.COFINSAliq;
    }

    private void PreencherCadastro(Item entidade)
    {
        entidade.Id = id;

        entidade.CodigoBarras = txtCodigoBarras.Text;
        entidade.CodigoReferencia = txtCodigoReferencia.Text;
        entidade.Descricao = txtDescricao.Text;
        entidade.DescricaoPDV = txtDescricaoPDV.Text;

        entidade.EstoqueMinimo = txtEstoqueMinimo.ConverterParaLong();
        entidade.EstoqueAtual = txtEstoqueAtual.ConverterParaLong();

        entidade.NotificarEstoqueBaixo = chbxNotificarEstoqueBaixo.Checked;
        entidade.GerenciarEstoque = chbxGerenciarEstoque.Checked;

        entidade.CustoReal = txtCustoReal.ConverterParaDecimalNulo();
        entidade.MargemLucro = txtMargemLucro.ConverterParaDecimalNulo();
        entidade.PrecoFinal = txtPrecoFinal.ConverterParaDecimal();

        entidade.UnidadeMedida = cbbxUnidadeMedida.Converter<UnidadesMedidas>();
        entidade.TipoItem = cbbxTipo.Converter<TipoItem>();

        entidade.ModoItem = rbtnProdutoModo_Padrao.Checked ? ModosItem.Padrao
            : rbtnProdutoModo_SolicitarPeso.Checked ? ModosItem.SolicitarPeso
            : ModosItem.SolicitarPreco;

        entidade.CustoReal2 = txtCustoReal2.ConverterParaDecimalNulo();
        entidade.MargemLucro2 = txtMargemLucro2.ConverterParaDecimalNulo();
        entidade.PrecoFinal2 = txtPrecoFinal2.ConverterParaDecimalNulo();

        entidade.CustoReal3 = txtCustoReal3.ConverterParaDecimalNulo();
        entidade.MargemLucro3 = txtMargemLucro3.ConverterParaDecimalNulo();
        entidade.PrecoFinal3 = txtPrecoFinal3.ConverterParaDecimalNulo();

        entidade.MultiplosPrecos = rbtnModoCustoPreco_DoisOuMais.Checked;

        entidade.CodigoAuxiliarBalanca = txtCodigoAuxiliarBalanca.Text;

        entidade.GerarDadosAuxiliarBalanca = chbxGerarDadosAuxiliaresBalanca.Checked;
        entidade.UsarBalancaCheckout = chbxPesar.Checked;

        entidade.NCM = txtNCM.Text;
        entidade.CFOP = txtCFOP.Text;

        var iCMS = ctICMS.ObterICMS(servicoJson);

        entidade.TipoICMS = iCMS.Item1;
        entidade.ICMS = iCMS.Item2;

        var pIS = ctPIS.ObterPIS(servicoJson);

        entidade.TipoPIS = pIS.Item1;
        entidade.PIS = pIS.Item2;

        var coFINS = ctCOFINS.ObterCOFINS(servicoJson);

        entidade.TipoCOFINS = coFINS.Item1;
        entidade.COFINS = coFINS.Item2;
    }

    private void PreencherTela(Item entidade)
    {
        id = entidade.Id;

        txtCodigoBarras.Text = entidade.CodigoBarras;
        txtCodigoReferencia.Text = entidade.CodigoReferencia;

        txtDescricao.Text = entidade.Descricao;
        txtDescricaoPDV.Text = entidade.DescricaoPDV;

        if (entidade.ModoItem == ModosItem.Padrao)
            rbtnProdutoModo_Padrao.Checked = true;
        else if (entidade.ModoItem == ModosItem.SolicitarPeso)
            rbtnProdutoModo_SolicitarPeso.Checked = true;
        else
            rbtnProdutoModo_SolicitarPreco.Checked = true;

        cbbxTipo.Definir(entidade.TipoItem);

        txtCustoReal.Text = entidade.CustoReal?.ToString() ?? string.Empty;
        txtMargemLucro.Text = entidade.MargemLucro?.ToString() ?? string.Empty;
        txtPrecoFinal.Text = entidade.PrecoFinal.ToString();

        txtEstoqueAtual.Text = entidade.EstoqueAtual.ToString();
        txtEstoqueMinimo.Text = entidade.EstoqueMinimo.ToString();

        cbbxUnidadeMedida.Definir(entidade.UnidadeMedida);

        chbxGerenciarEstoque.Checked = entidade.GerenciarEstoque;
        chbxNotificarEstoqueBaixo.Checked = entidade.NotificarEstoqueBaixo;

        txtCustoReal2.Text = entidade.CustoReal2?.ToString() ?? string.Empty;
        txtMargemLucro2.Text = entidade.MargemLucro2?.ToString() ?? string.Empty;
        txtPrecoFinal2.Text = entidade.PrecoFinal2?.ToString() ?? string.Empty;

        txtCustoReal3.Text = entidade.CustoReal3?.ToString() ?? string.Empty;
        txtMargemLucro3.Text = entidade.MargemLucro3?.ToString() ?? string.Empty;
        txtPrecoFinal3.Text = entidade.PrecoFinal3?.ToString() ?? string.Empty;

        rbtnModoCustoPreco_DoisOuMais.Checked = entidade.MultiplosPrecos;

        txtCodigoAuxiliarBalanca.Text = entidade.CodigoAuxiliarBalanca;
        chbxGerarDadosAuxiliaresBalanca.Checked = entidade.GerarDadosAuxiliarBalanca;
        chbxPesar.Checked = entidade.UsarBalancaCheckout;

        txtNCM.Text = entidade.NCM;
        txtCFOP.Text = entidade.CFOP;

        ctICMS.DefinirICMS(servicoJson, entidade.TipoICMS, entidade.ICMS);
        ctPIS.DefinirPIS(servicoJson, entidade.TipoPIS, entidade.PIS);
        ctCOFINS.DefinirCOFINS(servicoJson, entidade.TipoCOFINS, entidade.COFINS);
    }

    private void PreencherResultado(Item? entidade)
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

            txtBuscarIdCodigoBarrasCodigoReferencia.Text = entidade.CodigoBarras;

            DefinirModo(CadastroModos.Visualizar);
        }
    }

    private void LimparTudoESelecionar()
    {
        servicoEntidades.DescartarAlteracoes();

        txtBuscarIdCodigoBarrasCodigoReferencia.Selecionar();
    }

    private void CadastroNaoEncontrado()
    {
        RedefinirCampos();

        DefinirModo(CadastroModos.Padrao);

        this.ExibirMensagemCadastroNaoEncontrado();
    }

    private void FrmCadastroProdutos_Load(object sender, EventArgs e)
    {
        cbbxUnidadeMedida.Configurar(UnidadeMedidaHelper.ObterLista());
        cbbxTipo.Configurar(TipoItemHelper.ObterLista());

        DefinirModo(CadastroModos.Padrao);
    }

    private void TxtBuscarIdCodigoBarrasCodigoReferencia_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar)
            && !string.IsNullOrWhiteSpace(txtBuscarIdCodigoBarrasCodigoReferencia.Text))
        {
            e.Handled = true;

            try
            {
                var entidade = chbxUsarCodigoReferencia.Checked
                    ? servicoEntidades.ObterPorCodigoReferencia(txtBuscarIdCodigoBarrasCodigoReferencia.Text)
                    : servicoEntidades.ObterPorIdOuCodigoBarras(txtBuscarIdCodigoBarrasCodigoReferencia.Text);

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
            using var frm = new FrmConsultaAvancadaItens(servicoEntidades);

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
            var entidade = new Item();

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
    {
        Close();
    }

    private void TbcDados_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tbcDados.SelectedTab?.Name == tbpDadosPrincipais.Name)
            txtCodigoBarras.Selecionar();
        else if (tbcDados.SelectedTab?.Name == tbpImpostos.Name)
            txtNCM.Selecionar();
        else if (tbcDados.SelectedTab?.Name == tbpCustosPrecos.Name)
            rbtnModoCustoPreco_SomenteUm.Selecionar();
        else
            txtCodigoAuxiliarBalanca.Selecionar();
    }
}
