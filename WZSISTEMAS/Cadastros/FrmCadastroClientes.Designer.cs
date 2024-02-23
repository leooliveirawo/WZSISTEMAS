namespace WZSISTEMAS.Cadastros
{
    partial class FrmCadastroClientes
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
            gbxBusca = new GroupBox();
            btnBuscarConsultaAvancada = new Button();
            txtBuscarCPF_CNPJ = new TextBox();
            gbxDados = new GroupBox();
            tbcDados = new TabControl();
            tbpDadosPrincipais = new TabPage();
            label1 = new Label();
            cbbxTipo = new ComboBox();
            label2 = new Label();
            txtNomeCompleto_RazaoSocial = new TextBox();
            label3 = new Label();
            chbxNaoInformarDataNascimento = new CheckBox();
            txtCPF_CNPJ = new TextBox();
            label4 = new Label();
            txtRG_InscricaoEstadual = new TextBox();
            label5 = new Label();
            dtpDataNascimento = new DateTimePicker();
            tbpLocalizacao = new TabPage();
            btnConsultarCEP = new Button();
            cbbxUF = new ComboBox();
            txtReferencia = new TextBox();
            label6 = new Label();
            label17 = new Label();
            txtLogradouro = new TextBox();
            txtComplemento = new TextBox();
            label7 = new Label();
            label16 = new Label();
            txtLogradouroNumero = new TextBox();
            label8 = new Label();
            label11 = new Label();
            txtCEP = new TextBox();
            txtCidade = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtBairro = new TextBox();
            tbpContato = new TabPage();
            txtEmail = new TextBox();
            label12 = new Label();
            label15 = new Label();
            txtTelefone1 = new TextBox();
            txtTelefone3 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            txtTelefone2 = new TextBox();
            tbpConvenio = new TabPage();
            chbxAlterarConvenioDiaFechamentoVencimento = new CheckBox();
            label19 = new Label();
            txtConvenioLimite = new TextBox();
            label18 = new Label();
            cbbxConvenioDiaVencimentoFechamento = new ComboBox();
            gbxConvenioModo = new GroupBox();
            rbtnConvenioModoInativo = new RadioButton();
            rbtnConvenioModoBloqueado = new RadioButton();
            rbtnConvenioModoAtivo = new RadioButton();
            btnNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnVoltar = new Button();
            gbxBusca.SuspendLayout();
            gbxDados.SuspendLayout();
            tbcDados.SuspendLayout();
            tbpDadosPrincipais.SuspendLayout();
            tbpLocalizacao.SuspendLayout();
            tbpContato.SuspendLayout();
            tbpConvenio.SuspendLayout();
            gbxConvenioModo.SuspendLayout();
            SuspendLayout();
            // 
            // gbxBusca
            // 
            gbxBusca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxBusca.Controls.Add(btnBuscarConsultaAvancada);
            gbxBusca.Controls.Add(txtBuscarCPF_CNPJ);
            gbxBusca.Location = new Point(9, 12);
            gbxBusca.Name = "gbxBusca";
            gbxBusca.Size = new Size(765, 52);
            gbxBusca.TabIndex = 0;
            gbxBusca.TabStop = false;
            gbxBusca.Text = "Buscar por CPF/CNPJ";
            // 
            // btnBuscarConsultaAvancada
            // 
            btnBuscarConsultaAvancada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarConsultaAvancada.Location = new Point(645, 20);
            btnBuscarConsultaAvancada.Name = "btnBuscarConsultaAvancada";
            btnBuscarConsultaAvancada.Size = new Size(115, 23);
            btnBuscarConsultaAvancada.TabIndex = 8;
            btnBuscarConsultaAvancada.Text = "Consulta avançada";
            btnBuscarConsultaAvancada.UseVisualStyleBackColor = true;
            btnBuscarConsultaAvancada.Click += BtnBuscarConsultaAvancada_Click;
            // 
            // txtBuscarCPF_CNPJ
            // 
            txtBuscarCPF_CNPJ.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarCPF_CNPJ.Location = new Point(6, 22);
            txtBuscarCPF_CNPJ.Name = "txtBuscarCPF_CNPJ";
            txtBuscarCPF_CNPJ.Size = new Size(634, 23);
            txtBuscarCPF_CNPJ.TabIndex = 0;
            txtBuscarCPF_CNPJ.KeyPress += TxtBuscarCPF_CNPJ_KeyPress;
            // 
            // gbxDados
            // 
            gbxDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxDados.Controls.Add(tbcDados);
            gbxDados.Location = new Point(9, 70);
            gbxDados.Name = "gbxDados";
            gbxDados.Size = new Size(765, 451);
            gbxDados.TabIndex = 1;
            gbxDados.TabStop = false;
            gbxDados.Text = "Dados do cliente";
            // 
            // tbcDados
            // 
            tbcDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbcDados.Controls.Add(tbpDadosPrincipais);
            tbcDados.Controls.Add(tbpLocalizacao);
            tbcDados.Controls.Add(tbpContato);
            tbcDados.Controls.Add(tbpConvenio);
            tbcDados.Location = new Point(5, 19);
            tbcDados.Margin = new Padding(2);
            tbcDados.Name = "tbcDados";
            tbcDados.SelectedIndex = 0;
            tbcDados.Size = new Size(750, 427);
            tbcDados.TabIndex = 33;
            // 
            // tbpDadosPrincipais
            // 
            tbpDadosPrincipais.AutoScroll = true;
            tbpDadosPrincipais.Controls.Add(label1);
            tbpDadosPrincipais.Controls.Add(cbbxTipo);
            tbpDadosPrincipais.Controls.Add(label2);
            tbpDadosPrincipais.Controls.Add(txtNomeCompleto_RazaoSocial);
            tbpDadosPrincipais.Controls.Add(label3);
            tbpDadosPrincipais.Controls.Add(chbxNaoInformarDataNascimento);
            tbpDadosPrincipais.Controls.Add(txtCPF_CNPJ);
            tbpDadosPrincipais.Controls.Add(label4);
            tbpDadosPrincipais.Controls.Add(txtRG_InscricaoEstadual);
            tbpDadosPrincipais.Controls.Add(label5);
            tbpDadosPrincipais.Controls.Add(dtpDataNascimento);
            tbpDadosPrincipais.Location = new Point(4, 24);
            tbpDadosPrincipais.Margin = new Padding(2);
            tbpDadosPrincipais.Name = "tbpDadosPrincipais";
            tbpDadosPrincipais.Padding = new Padding(2);
            tbpDadosPrincipais.Size = new Size(742, 399);
            tbpDadosPrincipais.TabIndex = 0;
            tbpDadosPrincipais.Text = "Dados principais";
            tbpDadosPrincipais.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 2);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo *";
            // 
            // cbbxTipo
            // 
            cbbxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbxTipo.FormattingEnabled = true;
            cbbxTipo.Location = new Point(5, 20);
            cbbxTipo.Name = "cbbxTipo";
            cbbxTipo.Size = new Size(121, 23);
            cbbxTipo.TabIndex = 1;
            cbbxTipo.SelectedIndexChanged += CbbxTipo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 2);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome completo/Razão social *";
            // 
            // txtNomeCompleto_RazaoSocial
            // 
            txtNomeCompleto_RazaoSocial.CharacterCasing = CharacterCasing.Upper;
            txtNomeCompleto_RazaoSocial.Location = new Point(130, 20);
            txtNomeCompleto_RazaoSocial.Name = "txtNomeCompleto_RazaoSocial";
            txtNomeCompleto_RazaoSocial.Size = new Size(327, 23);
            txtNomeCompleto_RazaoSocial.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 41);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF/CNPJ *";
            // 
            // chbxNaoInformarDataNascimento
            // 
            chbxNaoInformarDataNascimento.AutoSize = true;
            chbxNaoInformarDataNascimento.Location = new Point(130, 124);
            chbxNaoInformarDataNascimento.Name = "chbxNaoInformarDataNascimento";
            chbxNaoInformarDataNascimento.Size = new Size(97, 19);
            chbxNaoInformarDataNascimento.TabIndex = 10;
            chbxNaoInformarDataNascimento.Text = "Não informar";
            chbxNaoInformarDataNascimento.UseVisualStyleBackColor = true;
            chbxNaoInformarDataNascimento.CheckedChanged += ChbxNaoInformarDataNascimento_CheckedChanged;
            // 
            // txtCPF_CNPJ
            // 
            txtCPF_CNPJ.CharacterCasing = CharacterCasing.Upper;
            txtCPF_CNPJ.Location = new Point(130, 59);
            txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            txtCPF_CNPJ.Size = new Size(197, 23);
            txtCPF_CNPJ.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 81);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 6;
            label4.Text = "RG/Inscrição estadual";
            // 
            // txtRG_InscricaoEstadual
            // 
            txtRG_InscricaoEstadual.CharacterCasing = CharacterCasing.Upper;
            txtRG_InscricaoEstadual.Location = new Point(130, 99);
            txtRG_InscricaoEstadual.Name = "txtRG_InscricaoEstadual";
            txtRG_InscricaoEstadual.Size = new Size(223, 23);
            txtRG_InscricaoEstadual.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 81);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 8;
            label5.Text = "Data de nascimento";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(358, 99);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(99, 23);
            dtpDataNascimento.TabIndex = 9;
            // 
            // tbpLocalizacao
            // 
            tbpLocalizacao.AutoScroll = true;
            tbpLocalizacao.Controls.Add(btnConsultarCEP);
            tbpLocalizacao.Controls.Add(cbbxUF);
            tbpLocalizacao.Controls.Add(txtReferencia);
            tbpLocalizacao.Controls.Add(label6);
            tbpLocalizacao.Controls.Add(label17);
            tbpLocalizacao.Controls.Add(txtLogradouro);
            tbpLocalizacao.Controls.Add(txtComplemento);
            tbpLocalizacao.Controls.Add(label7);
            tbpLocalizacao.Controls.Add(label16);
            tbpLocalizacao.Controls.Add(txtLogradouroNumero);
            tbpLocalizacao.Controls.Add(label8);
            tbpLocalizacao.Controls.Add(label11);
            tbpLocalizacao.Controls.Add(txtCEP);
            tbpLocalizacao.Controls.Add(txtCidade);
            tbpLocalizacao.Controls.Add(label9);
            tbpLocalizacao.Controls.Add(label10);
            tbpLocalizacao.Controls.Add(txtBairro);
            tbpLocalizacao.Location = new Point(4, 24);
            tbpLocalizacao.Margin = new Padding(2);
            tbpLocalizacao.Name = "tbpLocalizacao";
            tbpLocalizacao.Padding = new Padding(2);
            tbpLocalizacao.Size = new Size(742, 399);
            tbpLocalizacao.TabIndex = 1;
            tbpLocalizacao.Text = "Localização";
            tbpLocalizacao.UseVisualStyleBackColor = true;
            // 
            // btnConsultarCEP
            // 
            btnConsultarCEP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultarCEP.Image = Properties.Resources.Consulta_CEP;
            btnConsultarCEP.Location = new Point(421, 60);
            btnConsultarCEP.Name = "btnConsultarCEP";
            btnConsultarCEP.Size = new Size(22, 19);
            btnConsultarCEP.TabIndex = 16;
            btnConsultarCEP.UseVisualStyleBackColor = true;
            btnConsultarCEP.Click += BtnConsultarCEP_Click;
            // 
            // cbbxUF
            // 
            cbbxUF.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbxUF.FormattingEnabled = true;
            cbbxUF.Location = new Point(282, 187);
            cbbxUF.Margin = new Padding(2);
            cbbxUF.Name = "cbbxUF";
            cbbxUF.Size = new Size(129, 23);
            cbbxUF.TabIndex = 21;
            // 
            // txtReferencia
            // 
            txtReferencia.CharacterCasing = CharacterCasing.Upper;
            txtReferencia.Location = new Point(3, 103);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(408, 23);
            txtReferencia.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 2);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 10;
            label6.Text = "Logradouro";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 85);
            label17.Name = "label17";
            label17.Size = new Size(62, 15);
            label17.TabIndex = 32;
            label17.Text = "Referência";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Location = new Point(3, 20);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(327, 23);
            txtLogradouro.TabIndex = 11;
            // 
            // txtComplemento
            // 
            txtComplemento.CharacterCasing = CharacterCasing.Upper;
            txtComplemento.Location = new Point(3, 59);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(311, 23);
            txtComplemento.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 2);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 12;
            label7.Text = "Nº";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 41);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 16;
            label16.Text = "Complemento";
            // 
            // txtLogradouroNumero
            // 
            txtLogradouroNumero.CharacterCasing = CharacterCasing.Upper;
            txtLogradouroNumero.Location = new Point(336, 20);
            txtLogradouroNumero.Name = "txtLogradouroNumero";
            txtLogradouroNumero.Size = new Size(107, 23);
            txtLogradouroNumero.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(320, 42);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 14;
            label8.Text = "CEP";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(282, 169);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 20;
            label11.Text = "Estado (UF)";
            // 
            // txtCEP
            // 
            txtCEP.CharacterCasing = CharacterCasing.Upper;
            txtCEP.Location = new Point(320, 60);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(94, 23);
            txtCEP.TabIndex = 15;
            // 
            // txtCidade
            // 
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.Location = new Point(-1, 187);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(280, 23);
            txtCidade.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 125);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 16;
            label9.Text = "Bairro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 169);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 18;
            label10.Text = "Cidade";
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(3, 143);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(408, 23);
            txtBairro.TabIndex = 18;
            // 
            // tbpContato
            // 
            tbpContato.Controls.Add(txtEmail);
            tbpContato.Controls.Add(label12);
            tbpContato.Controls.Add(label15);
            tbpContato.Controls.Add(txtTelefone1);
            tbpContato.Controls.Add(txtTelefone3);
            tbpContato.Controls.Add(label13);
            tbpContato.Controls.Add(label14);
            tbpContato.Controls.Add(txtTelefone2);
            tbpContato.Location = new Point(4, 24);
            tbpContato.Margin = new Padding(2);
            tbpContato.Name = "tbpContato";
            tbpContato.Padding = new Padding(2);
            tbpContato.Size = new Size(742, 399);
            tbpContato.TabIndex = 2;
            tbpContato.Text = "Contato";
            tbpContato.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(3, 64);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(408, 23);
            txtEmail.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 2);
            label12.Name = "label12";
            label12.Size = new Size(68, 15);
            label12.TabIndex = 22;
            label12.Text = "Telefone (1)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 46);
            label15.Name = "label15";
            label15.Size = new Size(41, 15);
            label15.TabIndex = 28;
            label15.Text = "E-mail";
            // 
            // txtTelefone1
            // 
            txtTelefone1.CharacterCasing = CharacterCasing.Upper;
            txtTelefone1.Location = new Point(3, 20);
            txtTelefone1.Name = "txtTelefone1";
            txtTelefone1.Size = new Size(121, 23);
            txtTelefone1.TabIndex = 23;
            // 
            // txtTelefone3
            // 
            txtTelefone3.CharacterCasing = CharacterCasing.Upper;
            txtTelefone3.Location = new Point(257, 20);
            txtTelefone3.Name = "txtTelefone3";
            txtTelefone3.Size = new Size(121, 23);
            txtTelefone3.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(130, 2);
            label13.Name = "label13";
            label13.Size = new Size(68, 15);
            label13.TabIndex = 24;
            label13.Text = "Telefone (2)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(257, 2);
            label14.Name = "label14";
            label14.Size = new Size(68, 15);
            label14.TabIndex = 26;
            label14.Text = "Telefone (3)";
            // 
            // txtTelefone2
            // 
            txtTelefone2.CharacterCasing = CharacterCasing.Upper;
            txtTelefone2.Location = new Point(130, 20);
            txtTelefone2.Name = "txtTelefone2";
            txtTelefone2.Size = new Size(121, 23);
            txtTelefone2.TabIndex = 25;
            // 
            // tbpConvenio
            // 
            tbpConvenio.Controls.Add(chbxAlterarConvenioDiaFechamentoVencimento);
            tbpConvenio.Controls.Add(label19);
            tbpConvenio.Controls.Add(txtConvenioLimite);
            tbpConvenio.Controls.Add(label18);
            tbpConvenio.Controls.Add(cbbxConvenioDiaVencimentoFechamento);
            tbpConvenio.Controls.Add(gbxConvenioModo);
            tbpConvenio.Location = new Point(4, 24);
            tbpConvenio.Margin = new Padding(2);
            tbpConvenio.Name = "tbpConvenio";
            tbpConvenio.Padding = new Padding(2);
            tbpConvenio.Size = new Size(742, 399);
            tbpConvenio.TabIndex = 3;
            tbpConvenio.Text = "Convenio";
            tbpConvenio.UseVisualStyleBackColor = true;
            // 
            // chbxAlterarConvenioDiaFechamentoVencimento
            // 
            chbxAlterarConvenioDiaFechamentoVencimento.AutoSize = true;
            chbxAlterarConvenioDiaFechamentoVencimento.Location = new Point(159, 70);
            chbxAlterarConvenioDiaFechamentoVencimento.Margin = new Padding(2);
            chbxAlterarConvenioDiaFechamentoVencimento.Name = "chbxAlterarConvenioDiaFechamentoVencimento";
            chbxAlterarConvenioDiaFechamentoVencimento.Size = new Size(238, 19);
            chbxAlterarConvenioDiaFechamentoVencimento.TabIndex = 10;
            chbxAlterarConvenioDiaFechamentoVencimento.Text = "Alterar data de fechamento/vencimento";
            chbxAlterarConvenioDiaFechamentoVencimento.UseVisualStyleBackColor = true;
            chbxAlterarConvenioDiaFechamentoVencimento.CheckedChanged += ChbxAlterarConvenio_CheckedChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 92);
            label19.Name = "label19";
            label19.Size = new Size(64, 15);
            label19.TabIndex = 8;
            label19.Text = "Limite (R$)";
            // 
            // txtConvenioLimite
            // 
            txtConvenioLimite.CharacterCasing = CharacterCasing.Upper;
            txtConvenioLimite.Location = new Point(3, 110);
            txtConvenioLimite.Name = "txtConvenioLimite";
            txtConvenioLimite.Size = new Size(223, 23);
            txtConvenioLimite.TabIndex = 9;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 51);
            label18.Name = "label18";
            label18.Size = new Size(147, 15);
            label18.TabIndex = 2;
            label18.Text = "Vencimento (Fechamento)";
            // 
            // cbbxConvenioDiaVencimentoFechamento
            // 
            cbbxConvenioDiaVencimentoFechamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbxConvenioDiaVencimentoFechamento.FormattingEnabled = true;
            cbbxConvenioDiaVencimentoFechamento.Location = new Point(3, 69);
            cbbxConvenioDiaVencimentoFechamento.Name = "cbbxConvenioDiaVencimentoFechamento";
            cbbxConvenioDiaVencimentoFechamento.Size = new Size(152, 23);
            cbbxConvenioDiaVencimentoFechamento.TabIndex = 3;
            // 
            // gbxConvenioModo
            // 
            gbxConvenioModo.Controls.Add(rbtnConvenioModoInativo);
            gbxConvenioModo.Controls.Add(rbtnConvenioModoBloqueado);
            gbxConvenioModo.Controls.Add(rbtnConvenioModoAtivo);
            gbxConvenioModo.Location = new Point(4, 4);
            gbxConvenioModo.Margin = new Padding(2);
            gbxConvenioModo.Name = "gbxConvenioModo";
            gbxConvenioModo.Padding = new Padding(2);
            gbxConvenioModo.Size = new Size(224, 46);
            gbxConvenioModo.TabIndex = 0;
            gbxConvenioModo.TabStop = false;
            gbxConvenioModo.Text = "ModoConexao";
            // 
            // rbtnConvenioModoInativo
            // 
            rbtnConvenioModoInativo.AutoSize = true;
            rbtnConvenioModoInativo.Location = new Point(154, 18);
            rbtnConvenioModoInativo.Margin = new Padding(2);
            rbtnConvenioModoInativo.Name = "rbtnConvenioModoInativo";
            rbtnConvenioModoInativo.Size = new Size(61, 19);
            rbtnConvenioModoInativo.TabIndex = 2;
            rbtnConvenioModoInativo.TabStop = true;
            rbtnConvenioModoInativo.Text = "Inativo";
            rbtnConvenioModoInativo.UseVisualStyleBackColor = true;
            // 
            // rbtnConvenioModoBloqueado
            // 
            rbtnConvenioModoBloqueado.AutoSize = true;
            rbtnConvenioModoBloqueado.Location = new Point(64, 18);
            rbtnConvenioModoBloqueado.Margin = new Padding(2);
            rbtnConvenioModoBloqueado.Name = "rbtnConvenioModoBloqueado";
            rbtnConvenioModoBloqueado.Size = new Size(82, 19);
            rbtnConvenioModoBloqueado.TabIndex = 1;
            rbtnConvenioModoBloqueado.TabStop = true;
            rbtnConvenioModoBloqueado.Text = "Bloqueado";
            rbtnConvenioModoBloqueado.UseVisualStyleBackColor = true;
            // 
            // rbtnConvenioModoAtivo
            // 
            rbtnConvenioModoAtivo.AutoSize = true;
            rbtnConvenioModoAtivo.Location = new Point(4, 18);
            rbtnConvenioModoAtivo.Margin = new Padding(2);
            rbtnConvenioModoAtivo.Name = "rbtnConvenioModoAtivo";
            rbtnConvenioModoAtivo.Size = new Size(53, 19);
            rbtnConvenioModoAtivo.TabIndex = 0;
            rbtnConvenioModoAtivo.TabStop = true;
            rbtnConvenioModoAtivo.Text = "Ativo";
            rbtnConvenioModoAtivo.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.Location = new Point(531, 527);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += BtnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.Location = new Point(612, 527);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.Location = new Point(693, 527);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Location = new Point(534, 527);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(616, 527);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoltar.Location = new Point(697, 527);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += BtnVoltar_Click;
            // 
            // FrmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnVoltar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(gbxDados);
            Controls.Add(gbxBusca);
            DoubleBuffered = true;
            Name = "FrmCadastroClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cliente";
            Load += FrmCadastroClientes_Load;
            gbxBusca.ResumeLayout(false);
            gbxBusca.PerformLayout();
            gbxDados.ResumeLayout(false);
            tbcDados.ResumeLayout(false);
            tbpDadosPrincipais.ResumeLayout(false);
            tbpDadosPrincipais.PerformLayout();
            tbpLocalizacao.ResumeLayout(false);
            tbpLocalizacao.PerformLayout();
            tbpContato.ResumeLayout(false);
            tbpContato.PerformLayout();
            tbpConvenio.ResumeLayout(false);
            tbpConvenio.PerformLayout();
            gbxConvenioModo.ResumeLayout(false);
            gbxConvenioModo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxBusca;
        private TextBox txtBuscarCPF_CNPJ;
        private GroupBox gbxDados;
        private ComboBox cbbxTipo;
        private Label label1;
        private DateTimePicker dtpDataNascimento;
        private Label label5;
        private TextBox txtRG_InscricaoEstadual;
        private Label label4;
        private TextBox txtCPF_CNPJ;
        private Label label3;
        private TextBox txtNomeCompleto_RazaoSocial;
        private Label label2;
        private TextBox txtLogradouroNumero;
        private Label label7;
        private TextBox txtLogradouro;
        private Label label6;
        private TextBox txtEmail;
        private Label label15;
        private TextBox txtTelefone3;
        private Label label14;
        private TextBox txtTelefone2;
        private Label label13;
        private TextBox txtTelefone1;
        private Label label12;
        private Label label11;
        private TextBox txtCidade;
        private Label label10;
        private TextBox txtBairro;
        private Label label9;
        private TextBox txtCEP;
        private Label label8;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnVoltar;
        private CheckBox chbxNaoInformarDataNascimento;
        private TextBox txtReferencia;
        private Label label17;
        private TextBox txtComplemento;
        private Label label16;
        private Button btnBuscarConsultaAvancada;
        private TabControl tbcDados;
        private TabPage tbpLocalizacao;
        private TabPage tbpContato;
        private TabPage tbpDadosPrincipais;
        private ComboBox cbbxUF;
        private TabPage tbpConvenio;
        private GroupBox gbxConvenioModo;
        private RadioButton rbtnConvenioModoBloqueado;
        private RadioButton rbtnConvenioModoAtivo;
        private RadioButton rbtnConvenioModoInativo;
        private Label label18;
        private ComboBox cbbxConvenioDiaVencimentoFechamento;
        private Label label19;
        private TextBox txtConvenioLimite;
        private CheckBox chbxAlterarConvenioDiaFechamentoVencimento;
        private Button btnConsultarCEP;
    }
}