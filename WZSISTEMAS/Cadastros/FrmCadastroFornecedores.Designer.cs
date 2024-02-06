namespace WZSISTEMAS.Cadastros
{
    partial class FrmCadastroFornecedores
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
            btnNovo = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            btnEditar = new Button();
            gbxBusca = new GroupBox();
            btnBuscarConsultaAvancada = new Button();
            txtBuscarCNPJ = new TextBox();
            btnCancelar = new Button();
            gbxDados = new GroupBox();
            tbcDados = new TabControl();
            tbpDadosPrincipais = new TabPage();
            label2 = new Label();
            txtRazaoSocial = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtCNPJ = new TextBox();
            label4 = new Label();
            txtInscricaoEstadual = new TextBox();
            txtCodigoReferencia = new TextBox();
            tbpLocalizacao = new TabPage();
            cbbxUF = new ComboBox();
            label6 = new Label();
            txtReferencia = new TextBox();
            txtLogradouro = new TextBox();
            label17 = new Label();
            label7 = new Label();
            txtComplemento = new TextBox();
            txtLogradouroNumero = new TextBox();
            label16 = new Label();
            label8 = new Label();
            txtCEP = new TextBox();
            label9 = new Label();
            txtBairro = new TextBox();
            label10 = new Label();
            txtCidade = new TextBox();
            label11 = new Label();
            tbpEmitenteContato = new TabPage();
            label12 = new Label();
            txtEmail = new TextBox();
            txtTelefone1 = new TextBox();
            label15 = new Label();
            label13 = new Label();
            txtTelefone3 = new TextBox();
            txtTelefone2 = new TextBox();
            label14 = new Label();
            btnImportarXml = new Button();
            btnConsultarCEP = new Button();
            gbxBusca.SuspendLayout();
            gbxDados.SuspendLayout();
            tbcDados.SuspendLayout();
            tbpDadosPrincipais.SuspendLayout();
            tbpLocalizacao.SuspendLayout();
            tbpEmitenteContato.SuspendLayout();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.Location = new Point(417, 877);
            btnNovo.Margin = new Padding(4, 5, 4, 5);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(107, 38);
            btnNovo.TabIndex = 10;
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
            btnSalvar.TabIndex = 13;
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
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoltar.Location = new Point(996, 877);
            btnVoltar.Margin = new Padding(4, 5, 4, 5);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(107, 38);
            btnVoltar.TabIndex = 15;
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
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += BtnEditar_Click;
            // 
            // gbxBusca
            // 
            gbxBusca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxBusca.Controls.Add(btnBuscarConsultaAvancada);
            gbxBusca.Controls.Add(txtBuscarCNPJ);
            gbxBusca.Location = new Point(17, 20);
            gbxBusca.Margin = new Padding(4, 5, 4, 5);
            gbxBusca.Name = "gbxBusca";
            gbxBusca.Padding = new Padding(4, 5, 4, 5);
            gbxBusca.Size = new Size(1086, 107);
            gbxBusca.TabIndex = 8;
            gbxBusca.TabStop = false;
            gbxBusca.Text = "Buscar por CNPJ";
            // 
            // btnBuscarConsultaAvancada
            // 
            btnBuscarConsultaAvancada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarConsultaAvancada.Location = new Point(913, 37);
            btnBuscarConsultaAvancada.Margin = new Padding(4, 5, 4, 5);
            btnBuscarConsultaAvancada.Name = "btnBuscarConsultaAvancada";
            btnBuscarConsultaAvancada.Size = new Size(164, 38);
            btnBuscarConsultaAvancada.TabIndex = 8;
            btnBuscarConsultaAvancada.Text = "Consulta avançada";
            btnBuscarConsultaAvancada.UseVisualStyleBackColor = true;
            btnBuscarConsultaAvancada.Click += BtnBuscarConsultaAvancada_Click;
            // 
            // txtBuscarCNPJ
            // 
            txtBuscarCNPJ.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarCNPJ.Location = new Point(9, 37);
            txtBuscarCNPJ.Margin = new Padding(4, 5, 4, 5);
            txtBuscarCNPJ.Name = "txtBuscarCNPJ";
            txtBuscarCNPJ.Size = new Size(894, 31);
            txtBuscarCNPJ.TabIndex = 0;
            txtBuscarCNPJ.KeyPress += TxtBuscarCNPJ_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(880, 877);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 38);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // gbxDados
            // 
            gbxDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxDados.Controls.Add(tbcDados);
            gbxDados.Location = new Point(17, 137);
            gbxDados.Margin = new Padding(4, 5, 4, 5);
            gbxDados.Name = "gbxDados";
            gbxDados.Padding = new Padding(4, 5, 4, 5);
            gbxDados.Size = new Size(1086, 730);
            gbxDados.TabIndex = 9;
            gbxDados.TabStop = false;
            gbxDados.Text = "Dados do fornecedor";
            // 
            // tbcDados
            // 
            tbcDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbcDados.Controls.Add(tbpDadosPrincipais);
            tbcDados.Controls.Add(tbpLocalizacao);
            tbcDados.Controls.Add(tbpEmitenteContato);
            tbcDados.Location = new Point(7, 32);
            tbcDados.Name = "tbcDados";
            tbcDados.SelectedIndex = 0;
            tbcDados.Size = new Size(1072, 690);
            tbcDados.TabIndex = 34;
            // 
            // tbpDadosPrincipais
            // 
            tbpDadosPrincipais.Controls.Add(label2);
            tbpDadosPrincipais.Controls.Add(txtRazaoSocial);
            tbpDadosPrincipais.Controls.Add(label1);
            tbpDadosPrincipais.Controls.Add(label3);
            tbpDadosPrincipais.Controls.Add(txtCNPJ);
            tbpDadosPrincipais.Controls.Add(label4);
            tbpDadosPrincipais.Controls.Add(txtInscricaoEstadual);
            tbpDadosPrincipais.Controls.Add(txtCodigoReferencia);
            tbpDadosPrincipais.Location = new Point(4, 34);
            tbpDadosPrincipais.Name = "tbpDadosPrincipais";
            tbpDadosPrincipais.Padding = new Padding(3);
            tbpDadosPrincipais.Size = new Size(1064, 652);
            tbpDadosPrincipais.TabIndex = 0;
            tbpDadosPrincipais.Text = "Dados principais";
            tbpDadosPrincipais.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 3);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 2;
            label2.Text = "Razão social *";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.CharacterCasing = CharacterCasing.Upper;
            txtRazaoSocial.Location = new Point(7, 33);
            txtRazaoSocial.Margin = new Padding(4, 5, 4, 5);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(581, 31);
            txtRazaoSocial.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 8;
            label1.Text = "Código referência";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(596, 3);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 4;
            label3.Text = "CNPJ *";
            // 
            // txtCNPJ
            // 
            txtCNPJ.CharacterCasing = CharacterCasing.Upper;
            txtCNPJ.Location = new Point(596, 33);
            txtCNPJ.Margin = new Padding(4, 5, 4, 5);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(294, 31);
            txtCNPJ.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 69);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 6;
            label4.Text = "Inscrição estadual";
            // 
            // txtInscricaoEstadual
            // 
            txtInscricaoEstadual.CharacterCasing = CharacterCasing.Upper;
            txtInscricaoEstadual.Location = new Point(7, 99);
            txtInscricaoEstadual.Margin = new Padding(4, 5, 4, 5);
            txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            txtInscricaoEstadual.Size = new Size(317, 31);
            txtInscricaoEstadual.TabIndex = 7;
            // 
            // txtCodigoReferencia
            // 
            txtCodigoReferencia.CharacterCasing = CharacterCasing.Upper;
            txtCodigoReferencia.Location = new Point(332, 99);
            txtCodigoReferencia.Margin = new Padding(4, 5, 4, 5);
            txtCodigoReferencia.Name = "txtCodigoReferencia";
            txtCodigoReferencia.Size = new Size(294, 31);
            txtCodigoReferencia.TabIndex = 9;
            // 
            // tbpLocalizacao
            // 
            tbpLocalizacao.Controls.Add(btnConsultarCEP);
            tbpLocalizacao.Controls.Add(cbbxUF);
            tbpLocalizacao.Controls.Add(label6);
            tbpLocalizacao.Controls.Add(txtReferencia);
            tbpLocalizacao.Controls.Add(txtLogradouro);
            tbpLocalizacao.Controls.Add(label17);
            tbpLocalizacao.Controls.Add(label7);
            tbpLocalizacao.Controls.Add(txtComplemento);
            tbpLocalizacao.Controls.Add(txtLogradouroNumero);
            tbpLocalizacao.Controls.Add(label16);
            tbpLocalizacao.Controls.Add(label8);
            tbpLocalizacao.Controls.Add(txtCEP);
            tbpLocalizacao.Controls.Add(label9);
            tbpLocalizacao.Controls.Add(txtBairro);
            tbpLocalizacao.Controls.Add(label10);
            tbpLocalizacao.Controls.Add(txtCidade);
            tbpLocalizacao.Controls.Add(label11);
            tbpLocalizacao.Location = new Point(4, 34);
            tbpLocalizacao.Name = "tbpLocalizacao";
            tbpLocalizacao.Padding = new Padding(3);
            tbpLocalizacao.Size = new Size(1064, 652);
            tbpLocalizacao.TabIndex = 1;
            tbpLocalizacao.Text = "Localização";
            tbpLocalizacao.UseVisualStyleBackColor = true;
            // 
            // cbbxUF
            // 
            cbbxUF.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbxUF.FormattingEnabled = true;
            cbbxUF.Location = new Point(600, 297);
            cbbxUF.Name = "cbbxUF";
            cbbxUF.Size = new Size(182, 33);
            cbbxUF.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 3);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 10;
            label6.Text = "Logradouro";
            // 
            // txtReferencia
            // 
            txtReferencia.CharacterCasing = CharacterCasing.Upper;
            txtReferencia.Location = new Point(7, 165);
            txtReferencia.Margin = new Padding(4, 5, 4, 5);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(581, 31);
            txtReferencia.TabIndex = 17;
            // 
            // txtLogradouro
            // 
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Location = new Point(7, 33);
            txtLogradouro.Margin = new Padding(4, 5, 4, 5);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(581, 31);
            txtLogradouro.TabIndex = 11;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(4, 135);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(92, 25);
            label17.TabIndex = 32;
            label17.Text = "Referência";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(600, 8);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(33, 25);
            label7.TabIndex = 12;
            label7.Text = "Nº";
            // 
            // txtComplemento
            // 
            txtComplemento.CharacterCasing = CharacterCasing.Upper;
            txtComplemento.Location = new Point(7, 99);
            txtComplemento.Margin = new Padding(4, 5, 4, 5);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(581, 31);
            txtComplemento.TabIndex = 16;
            // 
            // txtLogradouroNumero
            // 
            txtLogradouroNumero.CharacterCasing = CharacterCasing.Upper;
            txtLogradouroNumero.Location = new Point(596, 33);
            txtLogradouroNumero.Margin = new Padding(4, 5, 4, 5);
            txtLogradouroNumero.Name = "txtLogradouroNumero";
            txtLogradouroNumero.Size = new Size(151, 31);
            txtLogradouroNumero.TabIndex = 13;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(7, 69);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(126, 25);
            label16.TabIndex = 16;
            label16.Text = "Complemento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(761, 8);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(42, 25);
            label8.TabIndex = 14;
            label8.Text = "CEP";
            // 
            // txtCEP
            // 
            txtCEP.CharacterCasing = CharacterCasing.Upper;
            txtCEP.Location = new Point(757, 33);
            txtCEP.Margin = new Padding(4, 5, 4, 5);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(133, 31);
            txtCEP.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 201);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(58, 25);
            label9.TabIndex = 16;
            label9.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(7, 231);
            txtBairro.Margin = new Padding(4, 5, 4, 5);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(581, 31);
            txtBairro.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 267);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(67, 25);
            label10.TabIndex = 18;
            label10.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.Location = new Point(7, 297);
            txtCidade.Margin = new Padding(4, 5, 4, 5);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(581, 31);
            txtCidade.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(596, 267);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(102, 25);
            label11.TabIndex = 20;
            label11.Text = "Estado (UF)";
            // 
            // tbpEmitenteContato
            // 
            tbpEmitenteContato.Controls.Add(label12);
            tbpEmitenteContato.Controls.Add(txtEmail);
            tbpEmitenteContato.Controls.Add(txtTelefone1);
            tbpEmitenteContato.Controls.Add(label15);
            tbpEmitenteContato.Controls.Add(label13);
            tbpEmitenteContato.Controls.Add(txtTelefone3);
            tbpEmitenteContato.Controls.Add(txtTelefone2);
            tbpEmitenteContato.Controls.Add(label14);
            tbpEmitenteContato.Location = new Point(4, 34);
            tbpEmitenteContato.Name = "tbpEmitenteContato";
            tbpEmitenteContato.Padding = new Padding(3);
            tbpEmitenteContato.Size = new Size(1064, 652);
            tbpEmitenteContato.TabIndex = 2;
            tbpEmitenteContato.Text = "Contato";
            tbpEmitenteContato.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 3);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(102, 25);
            label12.TabIndex = 22;
            label12.Text = "Telefone (1)";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(7, 109);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(581, 31);
            txtEmail.TabIndex = 29;
            // 
            // txtTelefone1
            // 
            txtTelefone1.CharacterCasing = CharacterCasing.Upper;
            txtTelefone1.Location = new Point(4, 33);
            txtTelefone1.Margin = new Padding(4, 5, 4, 5);
            txtTelefone1.Name = "txtTelefone1";
            txtTelefone1.Size = new Size(171, 31);
            txtTelefone1.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(7, 79);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(61, 25);
            label15.TabIndex = 28;
            label15.Text = "E-mail";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(183, 3);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(102, 25);
            label13.TabIndex = 24;
            label13.Text = "Telefone (2)";
            // 
            // txtTelefone3
            // 
            txtTelefone3.CharacterCasing = CharacterCasing.Upper;
            txtTelefone3.Location = new Point(362, 33);
            txtTelefone3.Margin = new Padding(4, 5, 4, 5);
            txtTelefone3.Name = "txtTelefone3";
            txtTelefone3.Size = new Size(171, 31);
            txtTelefone3.TabIndex = 27;
            // 
            // txtTelefone2
            // 
            txtTelefone2.CharacterCasing = CharacterCasing.Upper;
            txtTelefone2.Location = new Point(183, 33);
            txtTelefone2.Margin = new Padding(4, 5, 4, 5);
            txtTelefone2.Name = "txtTelefone2";
            txtTelefone2.Size = new Size(171, 31);
            txtTelefone2.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(362, 3);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(102, 25);
            label14.TabIndex = 26;
            label14.Text = "Telefone (3)";
            // 
            // btnImportarXml
            // 
            btnImportarXml.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImportarXml.Location = new Point(24, 877);
            btnImportarXml.Margin = new Padding(4, 5, 4, 5);
            btnImportarXml.Name = "btnImportarXml";
            btnImportarXml.Size = new Size(133, 38);
            btnImportarXml.TabIndex = 16;
            btnImportarXml.Text = "Importar Xml";
            btnImportarXml.UseVisualStyleBackColor = true;
            btnImportarXml.Click += BtnImportarXml_Click;
            // 
            // btnConsultarCEP
            // 
            btnConsultarCEP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultarCEP.Image = Properties.Resources.Consulta_CEP;
            btnConsultarCEP.Location = new Point(898, 33);
            btnConsultarCEP.Margin = new Padding(4, 5, 4, 5);
            btnConsultarCEP.Name = "btnConsultarCEP";
            btnConsultarCEP.Size = new Size(31, 31);
            btnConsultarCEP.TabIndex = 16;
            btnConsultarCEP.UseVisualStyleBackColor = true;
            btnConsultarCEP.Click += BtnConsultarCEP_Click;
            // 
            // FrmCadastroFornecedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 935);
            Controls.Add(btnImportarXml);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(btnEditar);
            Controls.Add(gbxBusca);
            Controls.Add(btnCancelar);
            Controls.Add(gbxDados);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmCadastroFornecedores";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fornecedor";
            Load += FrmCadastroFornecedores_Load;
            gbxBusca.ResumeLayout(false);
            gbxBusca.PerformLayout();
            gbxDados.ResumeLayout(false);
            tbcDados.ResumeLayout(false);
            tbpDadosPrincipais.ResumeLayout(false);
            tbpDadosPrincipais.PerformLayout();
            tbpLocalizacao.ResumeLayout(false);
            tbpLocalizacao.PerformLayout();
            tbpEmitenteContato.ResumeLayout(false);
            tbpEmitenteContato.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovo;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnVoltar;
        private Button btnEditar;
        private GroupBox gbxBusca;
        private Button btnBuscarConsultaAvancada;
        private TextBox txtBuscarCNPJ;
        private Button btnCancelar;
        private GroupBox gbxDados;
        private TabControl tbcDados;
        private TabPage tbpDadosPrincipais;
        private Label label2;
        private TextBox txtCodigoReferencia;
        private TextBox txtRazaoSocial;
        private Label label1;
        private Label label3;
        private TextBox txtCNPJ;
        private Label label4;
        private TextBox txtInscricaoEstadual;
        private TabPage tbpLocalizacao;
        private Label label6;
        private TextBox txtReferencia;
        private TextBox txtLogradouro;
        private Label label17;
        private Label label7;
        private TextBox txtComplemento;
        private TextBox txtLogradouroNumero;
        private Label label16;
        private Label label8;
        private TextBox txtCEP;
        private Label label9;
        private TextBox txtBairro;
        private Label label10;
        private TextBox txtCidade;
        private Label label11;
        private TabPage tbpEmitenteContato;
        private Label label12;
        private TextBox txtEmail;
        private TextBox txtTelefone1;
        private Label label15;
        private Label label13;
        private TextBox txtTelefone3;
        private TextBox txtTelefone2;
        private Label label14;
        private ComboBox cbbxUF;
        private Button btnImportarXml;
        private Button btnConsultarCEP;
    }
}