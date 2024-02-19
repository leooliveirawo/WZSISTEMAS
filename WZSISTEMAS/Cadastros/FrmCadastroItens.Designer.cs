using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Cadastros;

partial class FrmCadastroItens
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        gbxDados = new GroupBox();
        tbcDados = new TabControl();
        tbpDadosPrincipais = new TabPage();
        groupBox4 = new GroupBox();
        cbbxTipo = new ComboBox();
        label20 = new Label();
        groupBox6 = new GroupBox();
        chbxNotificarEstoqueBaixo = new CheckBox();
        chbxGerenciarEstoque = new CheckBox();
        label15 = new Label();
        txtEstoqueMinimo = new TextBox();
        label14 = new Label();
        txtEstoqueAtual = new TextBox();
        cbbxUnidadeMedida = new ComboBox();
        label13 = new Label();
        groupBox5 = new GroupBox();
        rbtnProdutoModo_SolicitarPeso = new RadioButton();
        rbtnProdutoModo_SolicitarPreco = new RadioButton();
        rbtnProdutoModo_Padrao = new RadioButton();
        groupBox1 = new GroupBox();
        label5 = new Label();
        label18 = new Label();
        txtCustoReal = new TextBox();
        label19 = new Label();
        txtMargemLucro = new TextBox();
        txtPrecoFinal = new TextBox();
        label1 = new Label();
        txtDescricaoPDV = new TextBox();
        txtCodigoBarras = new TextBox();
        label2 = new Label();
        label3 = new Label();
        txtCodigoReferencia = new TextBox();
        label4 = new Label();
        txtDescricao = new TextBox();
        tbpCustosPrecos = new TabPage();
        gbxCustoPrecoModo = new GroupBox();
        rbtnModoCustoPreco_DoisOuMais = new RadioButton();
        rbtnModoCustoPreco_SomenteUm = new RadioButton();
        groupBox3 = new GroupBox();
        label9 = new Label();
        label10 = new Label();
        txtCustoReal3 = new TextBox();
        label11 = new Label();
        txtMargemLucro3 = new TextBox();
        txtPrecoFinal3 = new TextBox();
        groupBox2 = new GroupBox();
        label6 = new Label();
        label7 = new Label();
        txtCustoReal2 = new TextBox();
        label8 = new Label();
        txtMargemLucro2 = new TextBox();
        txtPrecoFinal2 = new TextBox();
        tbpImpostos = new TabPage();
        tbcImpostos = new TabControl();
        tbpImpostoICMS = new TabPage();
        ctICMS = new Controles.ControleICMS();
        tbpImpostoPIS = new TabPage();
        ctPIS = new Controles.ControlePIS();
        tbpImpostoCOFINS = new TabPage();
        ctCOFINS = new Controles.ControleCOFINS();
        txtCFOP = new TextBox();
        label17 = new Label();
        txtNCM = new TextBox();
        label16 = new Label();
        tbpPesagemBalanca = new TabPage();
        chbxPesar = new CheckBox();
        chbxGerarDadosAuxiliaresBalanca = new CheckBox();
        label12 = new Label();
        txtCodigoAuxiliarBalanca = new TextBox();
        txtBuscarIdCodigoBarrasCodigoReferencia = new TextBox();
        btnNovo = new Button();
        btnSalvar = new Button();
        btnExcluir = new Button();
        btnCancelar = new Button();
        btnVoltar = new Button();
        btnEditar = new Button();
        gbxBusca = new GroupBox();
        chbxUsarCodigoReferencia = new CheckBox();
        btnBuscarConsultaAvancada = new Button();
        cbbxItemPrincipal = new ComboBox();
        gbxDados.SuspendLayout();
        tbcDados.SuspendLayout();
        tbpDadosPrincipais.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox6.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox1.SuspendLayout();
        tbpCustosPrecos.SuspendLayout();
        gbxCustoPrecoModo.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        tbpImpostos.SuspendLayout();
        tbcImpostos.SuspendLayout();
        tbpImpostoICMS.SuspendLayout();
        tbpImpostoPIS.SuspendLayout();
        tbpImpostoCOFINS.SuspendLayout();
        tbpPesagemBalanca.SuspendLayout();
        gbxBusca.SuspendLayout();
        SuspendLayout();
        // 
        // gbxDados
        // 
        gbxDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gbxDados.Controls.Add(tbcDados);
        gbxDados.Location = new Point(17, 137);
        gbxDados.Margin = new Padding(4, 5, 4, 5);
        gbxDados.Name = "gbxDados";
        gbxDados.Padding = new Padding(4, 5, 4, 5);
        gbxDados.Size = new Size(1090, 730);
        gbxDados.TabIndex = 17;
        gbxDados.TabStop = false;
        gbxDados.Text = "Dados do produto";
        // 
        // tbcDados
        // 
        tbcDados.Controls.Add(tbpDadosPrincipais);
        tbcDados.Controls.Add(tbpCustosPrecos);
        tbcDados.Controls.Add(tbpImpostos);
        tbcDados.Controls.Add(tbpPesagemBalanca);
        tbcDados.Dock = DockStyle.Fill;
        tbcDados.Location = new Point(4, 29);
        tbcDados.Margin = new Padding(4, 5, 4, 5);
        tbcDados.Name = "tbcDados";
        tbcDados.SelectedIndex = 0;
        tbcDados.Size = new Size(1082, 696);
        tbcDados.TabIndex = 34;
        tbcDados.SelectedIndexChanged += TbcDados_SelectedIndexChanged;
        // 
        // tbpDadosPrincipais
        // 
        tbpDadosPrincipais.Controls.Add(groupBox4);
        tbpDadosPrincipais.Controls.Add(cbbxTipo);
        tbpDadosPrincipais.Controls.Add(label20);
        tbpDadosPrincipais.Controls.Add(groupBox6);
        tbpDadosPrincipais.Controls.Add(cbbxUnidadeMedida);
        tbpDadosPrincipais.Controls.Add(label13);
        tbpDadosPrincipais.Controls.Add(groupBox5);
        tbpDadosPrincipais.Controls.Add(groupBox1);
        tbpDadosPrincipais.Controls.Add(label1);
        tbpDadosPrincipais.Controls.Add(txtDescricaoPDV);
        tbpDadosPrincipais.Controls.Add(txtCodigoBarras);
        tbpDadosPrincipais.Controls.Add(label2);
        tbpDadosPrincipais.Controls.Add(label3);
        tbpDadosPrincipais.Controls.Add(txtCodigoReferencia);
        tbpDadosPrincipais.Controls.Add(label4);
        tbpDadosPrincipais.Controls.Add(txtDescricao);
        tbpDadosPrincipais.Location = new Point(4, 34);
        tbpDadosPrincipais.Margin = new Padding(4, 5, 4, 5);
        tbpDadosPrincipais.Name = "tbpDadosPrincipais";
        tbpDadosPrincipais.Padding = new Padding(4, 5, 4, 5);
        tbpDadosPrincipais.Size = new Size(1074, 658);
        tbpDadosPrincipais.TabIndex = 0;
        tbpDadosPrincipais.Text = "Dados principais";
        tbpDadosPrincipais.UseVisualStyleBackColor = true;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(cbbxItemPrincipal);
        groupBox4.Location = new Point(544, 396);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(499, 145);
        groupBox4.TabIndex = 16;
        groupBox4.TabStop = false;
        groupBox4.Text = "Ítem principal";
        // 
        // cbbxTipo
        // 
        cbbxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        cbbxTipo.FormattingEnabled = true;
        cbbxTipo.Location = new Point(269, 357);
        cbbxTipo.Name = "cbbxTipo";
        cbbxTipo.Size = new Size(256, 33);
        cbbxTipo.TabIndex = 14;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Location = new Point(271, 329);
        label20.Margin = new Padding(4, 0, 4, 0);
        label20.Name = "label20";
        label20.Size = new Size(47, 25);
        label20.TabIndex = 15;
        label20.Text = "Tipo";
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(chbxNotificarEstoqueBaixo);
        groupBox6.Controls.Add(chbxGerenciarEstoque);
        groupBox6.Controls.Add(label15);
        groupBox6.Controls.Add(txtEstoqueMinimo);
        groupBox6.Controls.Add(label14);
        groupBox6.Controls.Add(txtEstoqueAtual);
        groupBox6.Location = new Point(7, 396);
        groupBox6.Name = "groupBox6";
        groupBox6.Size = new Size(531, 145);
        groupBox6.TabIndex = 15;
        groupBox6.TabStop = false;
        groupBox6.Text = "Estoque";
        // 
        // chbxNotificarEstoqueBaixo
        // 
        chbxNotificarEstoqueBaixo.AutoSize = true;
        chbxNotificarEstoqueBaixo.Location = new Point(193, 96);
        chbxNotificarEstoqueBaixo.Name = "chbxNotificarEstoqueBaixo";
        chbxNotificarEstoqueBaixo.Size = new Size(222, 29);
        chbxNotificarEstoqueBaixo.TabIndex = 22;
        chbxNotificarEstoqueBaixo.Text = "Notificar estoque baixo";
        chbxNotificarEstoqueBaixo.UseVisualStyleBackColor = true;
        // 
        // chbxGerenciarEstoque
        // 
        chbxGerenciarEstoque.AutoSize = true;
        chbxGerenciarEstoque.Location = new Point(7, 96);
        chbxGerenciarEstoque.Name = "chbxGerenciarEstoque";
        chbxGerenciarEstoque.Size = new Size(180, 29);
        chbxGerenciarEstoque.TabIndex = 21;
        chbxGerenciarEstoque.Text = "Gerenciar estoque";
        chbxGerenciarEstoque.UseVisualStyleBackColor = true;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(166, 27);
        label15.Margin = new Padding(4, 0, 4, 0);
        label15.Name = "label15";
        label15.Size = new Size(142, 25);
        label15.TabIndex = 19;
        label15.Text = "Estoque minimo";
        // 
        // txtEstoqueMinimo
        // 
        txtEstoqueMinimo.CharacterCasing = CharacterCasing.Upper;
        txtEstoqueMinimo.Location = new Point(166, 57);
        txtEstoqueMinimo.Margin = new Padding(4, 5, 4, 5);
        txtEstoqueMinimo.Name = "txtEstoqueMinimo";
        txtEstoqueMinimo.Size = new Size(151, 31);
        txtEstoqueMinimo.TabIndex = 20;
        txtEstoqueMinimo.Text = "0";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(7, 27);
        label14.Margin = new Padding(4, 0, 4, 0);
        label14.Name = "label14";
        label14.Size = new Size(119, 25);
        label14.TabIndex = 17;
        label14.Text = "Estoque atual";
        // 
        // txtEstoqueAtual
        // 
        txtEstoqueAtual.CharacterCasing = CharacterCasing.Upper;
        txtEstoqueAtual.Location = new Point(7, 57);
        txtEstoqueAtual.Margin = new Padding(4, 5, 4, 5);
        txtEstoqueAtual.Name = "txtEstoqueAtual";
        txtEstoqueAtual.Size = new Size(151, 31);
        txtEstoqueAtual.TabIndex = 18;
        txtEstoqueAtual.Text = "0";
        // 
        // cbbxUnidadeMedida
        // 
        cbbxUnidadeMedida.DropDownStyle = ComboBoxStyle.DropDownList;
        cbbxUnidadeMedida.FormattingEnabled = true;
        cbbxUnidadeMedida.Location = new Point(7, 357);
        cbbxUnidadeMedida.Name = "cbbxUnidadeMedida";
        cbbxUnidadeMedida.Size = new Size(256, 33);
        cbbxUnidadeMedida.TabIndex = 13;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(9, 329);
        label13.Margin = new Padding(4, 0, 4, 0);
        label13.Name = "label13";
        label13.Size = new Size(168, 25);
        label13.TabIndex = 12;
        label13.Text = "Unidade de medida";
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(rbtnProdutoModo_SolicitarPeso);
        groupBox5.Controls.Add(rbtnProdutoModo_SolicitarPreco);
        groupBox5.Controls.Add(rbtnProdutoModo_Padrao);
        groupBox5.Location = new Point(547, 157);
        groupBox5.Margin = new Padding(4, 5, 4, 5);
        groupBox5.Name = "groupBox5";
        groupBox5.Padding = new Padding(4, 5, 4, 5);
        groupBox5.Size = new Size(177, 167);
        groupBox5.TabIndex = 11;
        groupBox5.TabStop = false;
        groupBox5.Text = "ModoConexao";
        // 
        // rbtnProdutoModo_SolicitarPeso
        // 
        rbtnProdutoModo_SolicitarPeso.AutoSize = true;
        rbtnProdutoModo_SolicitarPeso.Location = new Point(9, 120);
        rbtnProdutoModo_SolicitarPeso.Margin = new Padding(4, 5, 4, 5);
        rbtnProdutoModo_SolicitarPeso.Name = "rbtnProdutoModo_SolicitarPeso";
        rbtnProdutoModo_SolicitarPeso.Size = new Size(143, 29);
        rbtnProdutoModo_SolicitarPeso.TabIndex = 2;
        rbtnProdutoModo_SolicitarPeso.TabStop = true;
        rbtnProdutoModo_SolicitarPeso.Text = "Solicitar peso";
        rbtnProdutoModo_SolicitarPeso.UseVisualStyleBackColor = true;
        // 
        // rbtnProdutoModo_SolicitarPreco
        // 
        rbtnProdutoModo_SolicitarPreco.AutoSize = true;
        rbtnProdutoModo_SolicitarPreco.Location = new Point(9, 78);
        rbtnProdutoModo_SolicitarPreco.Margin = new Padding(4, 5, 4, 5);
        rbtnProdutoModo_SolicitarPreco.Name = "rbtnProdutoModo_SolicitarPreco";
        rbtnProdutoModo_SolicitarPreco.Size = new Size(149, 29);
        rbtnProdutoModo_SolicitarPreco.TabIndex = 1;
        rbtnProdutoModo_SolicitarPreco.TabStop = true;
        rbtnProdutoModo_SolicitarPreco.Text = "Solicitar preço";
        rbtnProdutoModo_SolicitarPreco.UseVisualStyleBackColor = true;
        // 
        // rbtnProdutoModo_Padrao
        // 
        rbtnProdutoModo_Padrao.AutoSize = true;
        rbtnProdutoModo_Padrao.Location = new Point(9, 37);
        rbtnProdutoModo_Padrao.Margin = new Padding(4, 5, 4, 5);
        rbtnProdutoModo_Padrao.Name = "rbtnProdutoModo_Padrao";
        rbtnProdutoModo_Padrao.Size = new Size(92, 29);
        rbtnProdutoModo_Padrao.TabIndex = 0;
        rbtnProdutoModo_Padrao.TabStop = true;
        rbtnProdutoModo_Padrao.Text = "Padrão";
        rbtnProdutoModo_Padrao.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label18);
        groupBox1.Controls.Add(txtCustoReal);
        groupBox1.Controls.Add(label19);
        groupBox1.Controls.Add(txtMargemLucro);
        groupBox1.Controls.Add(txtPrecoFinal);
        groupBox1.Location = new Point(4, 157);
        groupBox1.Margin = new Padding(4, 5, 4, 5);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4, 5, 4, 5);
        groupBox1.Size = new Size(534, 127);
        groupBox1.TabIndex = 10;
        groupBox1.TabStop = false;
        groupBox1.Text = " ";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(9, 32);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(127, 25);
        label5.TabIndex = 15;
        label5.Text = "Custo real (R$)";
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Location = new Point(170, 32);
        label18.Margin = new Padding(4, 0, 4, 0);
        label18.Name = "label18";
        label18.Size = new Size(178, 25);
        label18.TabIndex = 17;
        label18.Text = "Margem de lucro (%)";
        // 
        // txtCustoReal
        // 
        txtCustoReal.CharacterCasing = CharacterCasing.Upper;
        txtCustoReal.Location = new Point(9, 62);
        txtCustoReal.Margin = new Padding(4, 5, 4, 5);
        txtCustoReal.Name = "txtCustoReal";
        txtCustoReal.Size = new Size(151, 31);
        txtCustoReal.TabIndex = 16;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Location = new Point(353, 37);
        label19.Margin = new Padding(4, 0, 4, 0);
        label19.Name = "label19";
        label19.Size = new Size(94, 25);
        label19.TabIndex = 19;
        label19.Text = "Preço final";
        // 
        // txtMargemLucro
        // 
        txtMargemLucro.CharacterCasing = CharacterCasing.Upper;
        txtMargemLucro.Location = new Point(170, 62);
        txtMargemLucro.Margin = new Padding(4, 5, 4, 5);
        txtMargemLucro.Name = "txtMargemLucro";
        txtMargemLucro.Size = new Size(168, 31);
        txtMargemLucro.TabIndex = 18;
        // 
        // txtPrecoFinal
        // 
        txtPrecoFinal.CharacterCasing = CharacterCasing.Upper;
        txtPrecoFinal.Location = new Point(349, 62);
        txtPrecoFinal.Margin = new Padding(4, 5, 4, 5);
        txtPrecoFinal.Name = "txtPrecoFinal";
        txtPrecoFinal.Size = new Size(151, 31);
        txtPrecoFinal.TabIndex = 20;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(506, 83);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(137, 25);
        label1.TabIndex = 8;
        label1.Text = "Descrição (PDV)";
        // 
        // txtDescricaoPDV
        // 
        txtDescricaoPDV.CharacterCasing = CharacterCasing.Upper;
        txtDescricaoPDV.Location = new Point(501, 108);
        txtDescricaoPDV.Margin = new Padding(4, 5, 4, 5);
        txtDescricaoPDV.Name = "txtDescricaoPDV";
        txtDescricaoPDV.Size = new Size(487, 31);
        txtDescricaoPDV.TabIndex = 9;
        // 
        // txtCodigoBarras
        // 
        txtCodigoBarras.CharacterCasing = CharacterCasing.Upper;
        txtCodigoBarras.Location = new Point(4, 35);
        txtCodigoBarras.Margin = new Padding(4, 5, 4, 5);
        txtCodigoBarras.Name = "txtCodigoBarras";
        txtCodigoBarras.Size = new Size(581, 31);
        txtCodigoBarras.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(9, 10);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(158, 25);
        label2.TabIndex = 2;
        label2.Text = "Código de barras*";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(600, 10);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(152, 25);
        label3.TabIndex = 4;
        label3.Text = "Código referência";
        // 
        // txtCodigoReferencia
        // 
        txtCodigoReferencia.CharacterCasing = CharacterCasing.Upper;
        txtCodigoReferencia.Location = new Point(596, 35);
        txtCodigoReferencia.Margin = new Padding(4, 5, 4, 5);
        txtCodigoReferencia.Name = "txtCodigoReferencia";
        txtCodigoReferencia.Size = new Size(294, 31);
        txtCodigoReferencia.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(9, 83);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(96, 25);
        label4.TabIndex = 6;
        label4.Text = "Descrição*";
        // 
        // txtDescricao
        // 
        txtDescricao.CharacterCasing = CharacterCasing.Upper;
        txtDescricao.Location = new Point(4, 108);
        txtDescricao.Margin = new Padding(4, 5, 4, 5);
        txtDescricao.Name = "txtDescricao";
        txtDescricao.Size = new Size(487, 31);
        txtDescricao.TabIndex = 7;
        // 
        // tbpCustosPrecos
        // 
        tbpCustosPrecos.Controls.Add(gbxCustoPrecoModo);
        tbpCustosPrecos.Controls.Add(groupBox3);
        tbpCustosPrecos.Controls.Add(groupBox2);
        tbpCustosPrecos.Location = new Point(4, 34);
        tbpCustosPrecos.Margin = new Padding(4, 5, 4, 5);
        tbpCustosPrecos.Name = "tbpCustosPrecos";
        tbpCustosPrecos.Padding = new Padding(4, 5, 4, 5);
        tbpCustosPrecos.Size = new Size(1074, 658);
        tbpCustosPrecos.TabIndex = 1;
        tbpCustosPrecos.Text = "Custos/Preços";
        tbpCustosPrecos.UseVisualStyleBackColor = true;
        // 
        // gbxCustoPrecoModo
        // 
        gbxCustoPrecoModo.Controls.Add(rbtnModoCustoPreco_DoisOuMais);
        gbxCustoPrecoModo.Controls.Add(rbtnModoCustoPreco_SomenteUm);
        gbxCustoPrecoModo.Location = new Point(4, 10);
        gbxCustoPrecoModo.Margin = new Padding(4, 5, 4, 5);
        gbxCustoPrecoModo.Name = "gbxCustoPrecoModo";
        gbxCustoPrecoModo.Padding = new Padding(4, 5, 4, 5);
        gbxCustoPrecoModo.Size = new Size(214, 127);
        gbxCustoPrecoModo.TabIndex = 0;
        gbxCustoPrecoModo.TabStop = false;
        gbxCustoPrecoModo.Text = "ModoConexao de custo/preço";
        // 
        // rbtnModoCustoPreco_DoisOuMais
        // 
        rbtnModoCustoPreco_DoisOuMais.AutoSize = true;
        rbtnModoCustoPreco_DoisOuMais.Location = new Point(9, 78);
        rbtnModoCustoPreco_DoisOuMais.Margin = new Padding(4, 5, 4, 5);
        rbtnModoCustoPreco_DoisOuMais.Name = "rbtnModoCustoPreco_DoisOuMais";
        rbtnModoCustoPreco_DoisOuMais.Size = new Size(141, 29);
        rbtnModoCustoPreco_DoisOuMais.TabIndex = 1;
        rbtnModoCustoPreco_DoisOuMais.TabStop = true;
        rbtnModoCustoPreco_DoisOuMais.Text = "Dois ou mais";
        rbtnModoCustoPreco_DoisOuMais.UseVisualStyleBackColor = true;
        // 
        // rbtnModoCustoPreco_SomenteUm
        // 
        rbtnModoCustoPreco_SomenteUm.AutoSize = true;
        rbtnModoCustoPreco_SomenteUm.Location = new Point(9, 37);
        rbtnModoCustoPreco_SomenteUm.Margin = new Padding(4, 5, 4, 5);
        rbtnModoCustoPreco_SomenteUm.Name = "rbtnModoCustoPreco_SomenteUm";
        rbtnModoCustoPreco_SomenteUm.Size = new Size(139, 29);
        rbtnModoCustoPreco_SomenteUm.TabIndex = 0;
        rbtnModoCustoPreco_SomenteUm.TabStop = true;
        rbtnModoCustoPreco_SomenteUm.Text = "Somente um";
        rbtnModoCustoPreco_SomenteUm.UseVisualStyleBackColor = true;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label9);
        groupBox3.Controls.Add(label10);
        groupBox3.Controls.Add(txtCustoReal3);
        groupBox3.Controls.Add(label11);
        groupBox3.Controls.Add(txtMargemLucro3);
        groupBox3.Controls.Add(txtPrecoFinal3);
        groupBox3.Location = new Point(227, 147);
        groupBox3.Margin = new Padding(4, 5, 4, 5);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new Padding(4, 5, 4, 5);
        groupBox3.Size = new Size(534, 127);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Custo/Preço 3";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(9, 32);
        label9.Margin = new Padding(4, 0, 4, 0);
        label9.Name = "label9";
        label9.Size = new Size(127, 25);
        label9.TabIndex = 15;
        label9.Text = "Custo real (R$)";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(170, 32);
        label10.Margin = new Padding(4, 0, 4, 0);
        label10.Name = "label10";
        label10.Size = new Size(178, 25);
        label10.TabIndex = 17;
        label10.Text = "Margem de lucro (%)";
        // 
        // txtCustoReal3
        // 
        txtCustoReal3.CharacterCasing = CharacterCasing.Upper;
        txtCustoReal3.ForeColor = SystemColors.Window;
        txtCustoReal3.Location = new Point(9, 62);
        txtCustoReal3.Margin = new Padding(4, 5, 4, 5);
        txtCustoReal3.Name = "txtCustoReal3";
        txtCustoReal3.Size = new Size(151, 31);
        txtCustoReal3.TabIndex = 16;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(353, 37);
        label11.Margin = new Padding(4, 0, 4, 0);
        label11.Name = "label11";
        label11.Size = new Size(94, 25);
        label11.TabIndex = 19;
        label11.Text = "Preço final";
        // 
        // txtMargemLucro3
        // 
        txtMargemLucro3.CharacterCasing = CharacterCasing.Upper;
        txtMargemLucro3.Location = new Point(170, 62);
        txtMargemLucro3.Margin = new Padding(4, 5, 4, 5);
        txtMargemLucro3.Name = "txtMargemLucro3";
        txtMargemLucro3.Size = new Size(168, 31);
        txtMargemLucro3.TabIndex = 18;
        // 
        // txtPrecoFinal3
        // 
        txtPrecoFinal3.CharacterCasing = CharacterCasing.Upper;
        txtPrecoFinal3.Location = new Point(349, 62);
        txtPrecoFinal3.Margin = new Padding(4, 5, 4, 5);
        txtPrecoFinal3.Name = "txtPrecoFinal3";
        txtPrecoFinal3.Size = new Size(151, 31);
        txtPrecoFinal3.TabIndex = 20;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(txtCustoReal2);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(txtMargemLucro2);
        groupBox2.Controls.Add(txtPrecoFinal2);
        groupBox2.Location = new Point(227, 10);
        groupBox2.Margin = new Padding(4, 5, 4, 5);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(4, 5, 4, 5);
        groupBox2.Size = new Size(534, 127);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Custo/Preço 2";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(9, 32);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(127, 25);
        label6.TabIndex = 15;
        label6.Text = "Custo real (R$)";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(170, 32);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(178, 25);
        label7.TabIndex = 17;
        label7.Text = "Margem de lucro (%)";
        // 
        // txtCustoReal2
        // 
        txtCustoReal2.CharacterCasing = CharacterCasing.Upper;
        txtCustoReal2.Location = new Point(9, 62);
        txtCustoReal2.Margin = new Padding(4, 5, 4, 5);
        txtCustoReal2.Name = "txtCustoReal2";
        txtCustoReal2.Size = new Size(151, 31);
        txtCustoReal2.TabIndex = 16;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(353, 37);
        label8.Margin = new Padding(4, 0, 4, 0);
        label8.Name = "label8";
        label8.Size = new Size(94, 25);
        label8.TabIndex = 19;
        label8.Text = "Preço final";
        // 
        // txtMargemLucro2
        // 
        txtMargemLucro2.CharacterCasing = CharacterCasing.Upper;
        txtMargemLucro2.Location = new Point(170, 62);
        txtMargemLucro2.Margin = new Padding(4, 5, 4, 5);
        txtMargemLucro2.Name = "txtMargemLucro2";
        txtMargemLucro2.Size = new Size(168, 31);
        txtMargemLucro2.TabIndex = 18;
        // 
        // txtPrecoFinal2
        // 
        txtPrecoFinal2.CharacterCasing = CharacterCasing.Upper;
        txtPrecoFinal2.Location = new Point(349, 62);
        txtPrecoFinal2.Margin = new Padding(4, 5, 4, 5);
        txtPrecoFinal2.Name = "txtPrecoFinal2";
        txtPrecoFinal2.Size = new Size(151, 31);
        txtPrecoFinal2.TabIndex = 20;
        // 
        // tbpImpostos
        // 
        tbpImpostos.AutoScroll = true;
        tbpImpostos.Controls.Add(tbcImpostos);
        tbpImpostos.Controls.Add(txtCFOP);
        tbpImpostos.Controls.Add(label17);
        tbpImpostos.Controls.Add(txtNCM);
        tbpImpostos.Controls.Add(label16);
        tbpImpostos.Location = new Point(4, 34);
        tbpImpostos.Name = "tbpImpostos";
        tbpImpostos.Padding = new Padding(3);
        tbpImpostos.Size = new Size(1074, 658);
        tbpImpostos.TabIndex = 3;
        tbpImpostos.Text = "Impostos";
        tbpImpostos.UseVisualStyleBackColor = true;
        // 
        // tbcImpostos
        // 
        tbcImpostos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tbcImpostos.Controls.Add(tbpImpostoICMS);
        tbcImpostos.Controls.Add(tbpImpostoPIS);
        tbcImpostos.Controls.Add(tbpImpostoCOFINS);
        tbcImpostos.Location = new Point(6, 72);
        tbcImpostos.Name = "tbcImpostos";
        tbcImpostos.SelectedIndex = 0;
        tbcImpostos.Size = new Size(1062, 583);
        tbcImpostos.TabIndex = 16;
        // 
        // tbpImpostoICMS
        // 
        tbpImpostoICMS.Controls.Add(ctICMS);
        tbpImpostoICMS.Location = new Point(4, 34);
        tbpImpostoICMS.Name = "tbpImpostoICMS";
        tbpImpostoICMS.Padding = new Padding(3);
        tbpImpostoICMS.Size = new Size(1054, 545);
        tbpImpostoICMS.TabIndex = 0;
        tbpImpostoICMS.Text = "ICMS";
        tbpImpostoICMS.UseVisualStyleBackColor = true;
        // 
        // ctICMS
        // 
        ctICMS.Dock = DockStyle.Fill;
        ctICMS.Location = new Point(3, 3);
        ctICMS.Name = "ctICMS";
        ctICMS.Size = new Size(1048, 539);
        ctICMS.TabIndex = 0;
        ctICMS.TipoICMS = TiposICMS.ICMS00;
        // 
        // tbpImpostoPIS
        // 
        tbpImpostoPIS.Controls.Add(ctPIS);
        tbpImpostoPIS.Location = new Point(4, 34);
        tbpImpostoPIS.Name = "tbpImpostoPIS";
        tbpImpostoPIS.Padding = new Padding(3);
        tbpImpostoPIS.Size = new Size(1054, 545);
        tbpImpostoPIS.TabIndex = 1;
        tbpImpostoPIS.Text = "PIS";
        tbpImpostoPIS.UseVisualStyleBackColor = true;
        // 
        // ctPIS
        // 
        ctPIS.Dock = DockStyle.Fill;
        ctPIS.Location = new Point(3, 3);
        ctPIS.Name = "ctPIS";
        ctPIS.Size = new Size(1048, 539);
        ctPIS.TabIndex = 0;
        ctPIS.TipoPIS = TiposPIS.PISAliq;
        // 
        // tbpImpostoCOFINS
        // 
        tbpImpostoCOFINS.Controls.Add(ctCOFINS);
        tbpImpostoCOFINS.Location = new Point(4, 34);
        tbpImpostoCOFINS.Name = "tbpImpostoCOFINS";
        tbpImpostoCOFINS.Padding = new Padding(3);
        tbpImpostoCOFINS.Size = new Size(1054, 545);
        tbpImpostoCOFINS.TabIndex = 2;
        tbpImpostoCOFINS.Text = "COFINS";
        tbpImpostoCOFINS.UseVisualStyleBackColor = true;
        // 
        // ctCOFINS
        // 
        ctCOFINS.Dock = DockStyle.Fill;
        ctCOFINS.Location = new Point(3, 3);
        ctCOFINS.Name = "ctCOFINS";
        ctCOFINS.Size = new Size(1048, 539);
        ctCOFINS.TabIndex = 0;
        ctCOFINS.TipoCOFINS = TiposCOFINS.COFINSAliq;
        // 
        // txtCFOP
        // 
        txtCFOP.CharacterCasing = CharacterCasing.Upper;
        txtCFOP.Location = new Point(145, 33);
        txtCFOP.Margin = new Padding(4, 5, 4, 5);
        txtCFOP.Name = "txtCFOP";
        txtCFOP.Size = new Size(130, 31);
        txtCFOP.TabIndex = 7;
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(145, 3);
        label17.Margin = new Padding(4, 0, 4, 0);
        label17.Name = "label17";
        label17.Size = new Size(64, 25);
        label17.TabIndex = 6;
        label17.Text = "CFOP*";
        // 
        // txtNCM
        // 
        txtNCM.CharacterCasing = CharacterCasing.Upper;
        txtNCM.Location = new Point(7, 33);
        txtNCM.Margin = new Padding(4, 5, 4, 5);
        txtNCM.Name = "txtNCM";
        txtNCM.Size = new Size(130, 31);
        txtNCM.TabIndex = 5;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(7, 3);
        label16.Margin = new Padding(4, 0, 4, 0);
        label16.Name = "label16";
        label16.Size = new Size(60, 25);
        label16.TabIndex = 4;
        label16.Text = "NCM*";
        // 
        // tbpPesagemBalanca
        // 
        tbpPesagemBalanca.Controls.Add(chbxPesar);
        tbpPesagemBalanca.Controls.Add(chbxGerarDadosAuxiliaresBalanca);
        tbpPesagemBalanca.Controls.Add(label12);
        tbpPesagemBalanca.Controls.Add(txtCodigoAuxiliarBalanca);
        tbpPesagemBalanca.Location = new Point(4, 34);
        tbpPesagemBalanca.Margin = new Padding(4, 5, 4, 5);
        tbpPesagemBalanca.Name = "tbpPesagemBalanca";
        tbpPesagemBalanca.Padding = new Padding(4, 5, 4, 5);
        tbpPesagemBalanca.Size = new Size(1074, 658);
        tbpPesagemBalanca.TabIndex = 2;
        tbpPesagemBalanca.Text = "Pesagem e balança";
        tbpPesagemBalanca.UseVisualStyleBackColor = true;
        // 
        // chbxPesar
        // 
        chbxPesar.AutoSize = true;
        chbxPesar.Location = new Point(426, 38);
        chbxPesar.Margin = new Padding(4, 5, 4, 5);
        chbxPesar.Name = "chbxPesar";
        chbxPesar.Size = new Size(87, 29);
        chbxPesar.TabIndex = 24;
        chbxPesar.Text = "Pesar?";
        chbxPesar.UseVisualStyleBackColor = true;
        // 
        // chbxGerarDadosAuxiliaresBalanca
        // 
        chbxGerarDadosAuxiliaresBalanca.AutoSize = true;
        chbxGerarDadosAuxiliaresBalanca.Location = new Point(216, 38);
        chbxGerarDadosAuxiliaresBalanca.Margin = new Padding(4, 5, 4, 5);
        chbxGerarDadosAuxiliaresBalanca.Name = "chbxGerarDadosAuxiliaresBalanca";
        chbxGerarDadosAuxiliaresBalanca.Size = new Size(211, 29);
        chbxGerarDadosAuxiliaresBalanca.TabIndex = 23;
        chbxGerarDadosAuxiliaresBalanca.Text = "Gerar dados auxiliares";
        chbxGerarDadosAuxiliaresBalanca.UseVisualStyleBackColor = true;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(9, 10);
        label12.Margin = new Padding(4, 0, 4, 0);
        label12.Name = "label12";
        label12.Size = new Size(205, 25);
        label12.TabIndex = 22;
        label12.Text = "Código auxiliar (balança)";
        // 
        // txtCodigoAuxiliarBalanca
        // 
        txtCodigoAuxiliarBalanca.CharacterCasing = CharacterCasing.Upper;
        txtCodigoAuxiliarBalanca.Location = new Point(4, 35);
        txtCodigoAuxiliarBalanca.Margin = new Padding(4, 5, 4, 5);
        txtCodigoAuxiliarBalanca.Name = "txtCodigoAuxiliarBalanca";
        txtCodigoAuxiliarBalanca.Size = new Size(201, 31);
        txtCodigoAuxiliarBalanca.TabIndex = 20;
        // 
        // txtBuscarIdCodigoBarrasCodigoReferencia
        // 
        txtBuscarIdCodigoBarrasCodigoReferencia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtBuscarIdCodigoBarrasCodigoReferencia.Location = new Point(9, 37);
        txtBuscarIdCodigoBarrasCodigoReferencia.Margin = new Padding(4, 5, 4, 5);
        txtBuscarIdCodigoBarrasCodigoReferencia.Name = "txtBuscarIdCodigoBarrasCodigoReferencia";
        txtBuscarIdCodigoBarrasCodigoReferencia.Size = new Size(651, 31);
        txtBuscarIdCodigoBarrasCodigoReferencia.TabIndex = 0;
        txtBuscarIdCodigoBarrasCodigoReferencia.KeyPress += TxtBuscarIdCodigoBarrasCodigoReferencia_KeyPress;
        // 
        // btnNovo
        // 
        btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnNovo.Location = new Point(417, 877);
        btnNovo.Margin = new Padding(4, 5, 4, 5);
        btnNovo.Name = "btnNovo";
        btnNovo.Size = new Size(107, 38);
        btnNovo.TabIndex = 18;
        btnNovo.Text = "Novo";
        btnNovo.UseVisualStyleBackColor = true;
        btnNovo.Click += BtnNovo_Click;
        // 
        // btnSalvar
        // 
        btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSalvar.Location = new Point(764, 877);
        btnSalvar.Margin = new Padding(4, 5, 4, 5);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(107, 38);
        btnSalvar.TabIndex = 21;
        btnSalvar.Text = "Salvar";
        btnSalvar.UseVisualStyleBackColor = true;
        btnSalvar.Click += BtnSalvar_Click;
        // 
        // btnExcluir
        // 
        btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnExcluir.Location = new Point(649, 877);
        btnExcluir.Margin = new Padding(4, 5, 4, 5);
        btnExcluir.Name = "btnExcluir";
        btnExcluir.Size = new Size(107, 38);
        btnExcluir.TabIndex = 20;
        btnExcluir.Text = "Excluir";
        btnExcluir.UseVisualStyleBackColor = true;
        btnExcluir.Click += BtnExcluir_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.Location = new Point(880, 877);
        btnCancelar.Margin = new Padding(4, 5, 4, 5);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(107, 38);
        btnCancelar.TabIndex = 22;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // btnVoltar
        // 
        btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnVoltar.Location = new Point(996, 877);
        btnVoltar.Margin = new Padding(4, 5, 4, 5);
        btnVoltar.Name = "btnVoltar";
        btnVoltar.Size = new Size(107, 38);
        btnVoltar.TabIndex = 23;
        btnVoltar.Text = "Voltar";
        btnVoltar.UseVisualStyleBackColor = true;
        btnVoltar.Click += BtnVoltar_Click;
        // 
        // btnEditar
        // 
        btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnEditar.Location = new Point(533, 877);
        btnEditar.Margin = new Padding(4, 5, 4, 5);
        btnEditar.Name = "btnEditar";
        btnEditar.Size = new Size(107, 38);
        btnEditar.TabIndex = 19;
        btnEditar.Text = "Editar";
        btnEditar.UseVisualStyleBackColor = true;
        btnEditar.Click += BtnEditar_Click;
        // 
        // gbxBusca
        // 
        gbxBusca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        gbxBusca.Controls.Add(chbxUsarCodigoReferencia);
        gbxBusca.Controls.Add(btnBuscarConsultaAvancada);
        gbxBusca.Controls.Add(txtBuscarIdCodigoBarrasCodigoReferencia);
        gbxBusca.Location = new Point(17, 20);
        gbxBusca.Margin = new Padding(4, 5, 4, 5);
        gbxBusca.Name = "gbxBusca";
        gbxBusca.Padding = new Padding(4, 5, 4, 5);
        gbxBusca.Size = new Size(1090, 107);
        gbxBusca.TabIndex = 16;
        gbxBusca.TabStop = false;
        gbxBusca.Text = "Buscar por Id/código de barras";
        // 
        // chbxUsarCodigoReferencia
        // 
        chbxUsarCodigoReferencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        chbxUsarCodigoReferencia.AutoSize = true;
        chbxUsarCodigoReferencia.Location = new Point(668, 40);
        chbxUsarCodigoReferencia.Margin = new Padding(4, 5, 4, 5);
        chbxUsarCodigoReferencia.Name = "chbxUsarCodigoReferencia";
        chbxUsarCodigoReferencia.Size = new Size(240, 29);
        chbxUsarCodigoReferencia.TabIndex = 9;
        chbxUsarCodigoReferencia.Text = "Usar código de referência";
        chbxUsarCodigoReferencia.UseVisualStyleBackColor = true;
        // 
        // btnBuscarConsultaAvancada
        // 
        btnBuscarConsultaAvancada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBuscarConsultaAvancada.Location = new Point(917, 35);
        btnBuscarConsultaAvancada.Margin = new Padding(4, 5, 4, 5);
        btnBuscarConsultaAvancada.Name = "btnBuscarConsultaAvancada";
        btnBuscarConsultaAvancada.Size = new Size(164, 38);
        btnBuscarConsultaAvancada.TabIndex = 8;
        btnBuscarConsultaAvancada.Text = "Consulta avançada";
        btnBuscarConsultaAvancada.UseVisualStyleBackColor = true;
        btnBuscarConsultaAvancada.Click += BtnBuscarConsultaAvancada_Click;
        // 
        // cbbxItemPrincipal
        // 
        cbbxItemPrincipal.DropDownStyle = ComboBoxStyle.DropDownList;
        cbbxItemPrincipal.FormattingEnabled = true;
        cbbxItemPrincipal.Location = new Point(6, 30);
        cbbxItemPrincipal.Name = "cbbxItemPrincipal";
        cbbxItemPrincipal.Size = new Size(487, 33);
        cbbxItemPrincipal.TabIndex = 14;
        // 
        // FrmCadastroItens
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1120, 935);
        Controls.Add(gbxDados);
        Controls.Add(btnNovo);
        Controls.Add(btnSalvar);
        Controls.Add(btnExcluir);
        Controls.Add(btnCancelar);
        Controls.Add(btnVoltar);
        Controls.Add(btnEditar);
        Controls.Add(gbxBusca);
        DoubleBuffered = true;
        Margin = new Padding(4, 5, 4, 5);
        Name = "FrmCadastroProdutos";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Produto";
        Load += FrmCadastroProdutos_Load;
        gbxDados.ResumeLayout(false);
        tbcDados.ResumeLayout(false);
        tbpDadosPrincipais.ResumeLayout(false);
        tbpDadosPrincipais.PerformLayout();
        groupBox4.ResumeLayout(false);
        groupBox6.ResumeLayout(false);
        groupBox6.PerformLayout();
        groupBox5.ResumeLayout(false);
        groupBox5.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        tbpCustosPrecos.ResumeLayout(false);
        gbxCustoPrecoModo.ResumeLayout(false);
        gbxCustoPrecoModo.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        tbpImpostos.ResumeLayout(false);
        tbpImpostos.PerformLayout();
        tbcImpostos.ResumeLayout(false);
        tbpImpostoICMS.ResumeLayout(false);
        tbpImpostoPIS.ResumeLayout(false);
        tbpImpostoCOFINS.ResumeLayout(false);
        tbpPesagemBalanca.ResumeLayout(false);
        tbpPesagemBalanca.PerformLayout();
        gbxBusca.ResumeLayout(false);
        gbxBusca.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox gbxDados;
    private TabControl tbcDados;
    private TabPage tbpDadosPrincipais;
    private TextBox txtCodigoBarras;
    private Label label2;
    private Label label3;
    private TextBox txtCodigoReferencia;
    private Label label4;
    private TextBox txtDescricao;
    private TabPage tbpCustosPrecos;
    private TabPage tbpPesagemBalanca;
    private Label label12;
    private TextBox txtCodigoAuxiliarBalanca;
    private TextBox txtBuscarIdCodigoBarrasCodigoReferencia;
    private Button btnNovo;
    private Button btnSalvar;
    private Button btnExcluir;
    private Button btnCancelar;
    private Button btnVoltar;
    private Button btnEditar;
    private GroupBox gbxBusca;
    private CheckBox chbxUsarCodigoReferencia;
    private Button btnBuscarConsultaAvancada;
    private Label label1;
    private TextBox txtDescricaoPDV;
    private Label label5;
    private GroupBox groupBox1;
    private TextBox txtCustoReal;
    private Label label18;
    private TextBox txtMargemLucro;
    private Label label19;
    private TextBox txtPrecoFinal;
    private GroupBox groupBox3;
    private Label label9;
    private Label label10;
    private TextBox txtCustoReal3;
    private Label label11;
    private TextBox txtMargemLucro3;
    private TextBox txtPrecoFinal3;
    private GroupBox groupBox2;
    private Label label6;
    private Label label7;
    private TextBox txtCustoReal2;
    private Label label8;
    private TextBox txtMargemLucro2;
    private TextBox txtPrecoFinal2;
    private GroupBox gbxCustoPrecoModo;
    private RadioButton rbtnModoCustoPreco_DoisOuMais;
    private RadioButton rbtnModoCustoPreco_SomenteUm;
    private GroupBox groupBox5;
    private RadioButton rbtnProdutoModo_SolicitarPeso;
    private RadioButton rbtnProdutoModo_SolicitarPreco;
    private RadioButton rbtnProdutoModo_Padrao;
    private CheckBox chbxGerarDadosAuxiliaresBalanca;
    private CheckBox chbxPesar;
    private ComboBox cbbxUnidadeMedida;
    private Label label13;
    private GroupBox groupBox6;
    private Label label15;
    private TextBox txtEstoqueMinimo;
    private Label label14;
    private TextBox txtEstoqueAtual;
    private CheckBox chbxNotificarEstoqueBaixo;
    private CheckBox chbxGerenciarEstoque;
    private TabPage tbpImpostos;
    private TextBox txtNCM;
    private Label label16;
    private TextBox txtCFOP;
    private Label label17;
    private TabControl tbcImpostos;
    private TabPage tbpImpostoICMS;
    private TabPage tbpImpostoPIS;
    private TabPage tbpImpostoCOFINS;
    private Controles.ControleICMS ctICMS;
    private Controles.ControlePIS ctPIS;
    private Controles.ControleCOFINS ctCOFINS;
    private ComboBox cbbxTipo;
    private Label label20;
    private GroupBox groupBox4;
    private ComboBox cbbxItemPrincipal;
}