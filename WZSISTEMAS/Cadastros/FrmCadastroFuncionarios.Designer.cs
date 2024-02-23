namespace WZSISTEMAS.Cadastros
{
    partial class FrmCadastroFuncionarios
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
            txtReferencia = new TextBox();
            label17 = new Label();
            txtComplemento = new TextBox();
            label16 = new Label();
            chbxNaoInformarDataNascimento = new CheckBox();
            txtEmail = new TextBox();
            label15 = new Label();
            txtTelefone3 = new TextBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            label14 = new Label();
            txtTelefone2 = new TextBox();
            label13 = new Label();
            txtTelefone1 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            txtCidade = new TextBox();
            label10 = new Label();
            txtBairro = new TextBox();
            btnVoltar = new Button();
            btnEditar = new Button();
            label9 = new Label();
            gbxBusca = new GroupBox();
            btnBuscarConsultaAvancada = new Button();
            txtBuscarCPF = new TextBox();
            btnCancelar = new Button();
            gbxDados = new GroupBox();
            tbcDados = new TabControl();
            tbpDadosPrincipais = new TabPage();
            txtNomeCompleto = new TextBox();
            cbbxCargo = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtCPF = new TextBox();
            label4 = new Label();
            txtRG = new TextBox();
            label5 = new Label();
            dtpDataNascimento = new DateTimePicker();
            tbpLocalizacao = new TabPage();
            btnConsultarCEP = new Button();
            cbbxUF = new ComboBox();
            label6 = new Label();
            txtLogradouro = new TextBox();
            label7 = new Label();
            txtLogradouroNumero = new TextBox();
            label8 = new Label();
            txtCEP = new TextBox();
            tbpContato = new TabPage();
            tbpUsuario = new TabPage();
            gbxAlterarSenha = new GroupBox();
            chbxAlterarSenha = new CheckBox();
            label21 = new Label();
            txtConfirmeNovaSenha = new TextBox();
            txtNovaSenha = new TextBox();
            label22 = new Label();
            txtSenhaAtual = new TextBox();
            label23 = new Label();
            gbxSenha = new GroupBox();
            label18 = new Label();
            txtConfirmeASenha = new TextBox();
            txtSenha = new TextBox();
            label19 = new Label();
            txtNomeUsuario = new TextBox();
            label20 = new Label();
            menuStrip1 = new MenuStrip();
            cargosToolStripMenuItem = new ToolStripMenuItem();
            gbxBusca.SuspendLayout();
            gbxDados.SuspendLayout();
            tbcDados.SuspendLayout();
            tbpDadosPrincipais.SuspendLayout();
            tbpLocalizacao.SuspendLayout();
            tbpContato.SuspendLayout();
            tbpUsuario.SuspendLayout();
            gbxAlterarSenha.SuspendLayout();
            gbxSenha.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.Location = new Point(291, 526);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 10;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += BtnNovo_Click;
            // 
            // txtReferencia
            // 
            txtReferencia.CharacterCasing = CharacterCasing.Upper;
            txtReferencia.Location = new Point(3, 109);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(408, 23);
            txtReferencia.TabIndex = 16;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 91);
            label17.Name = "label17";
            label17.Size = new Size(62, 15);
            label17.TabIndex = 32;
            label17.Text = "Referência";
            // 
            // txtComplemento
            // 
            txtComplemento.CharacterCasing = CharacterCasing.Upper;
            txtComplemento.Location = new Point(3, 65);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(295, 23);
            txtComplemento.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 47);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 16;
            label16.Text = "Complemento";
            // 
            // chbxNaoInformarDataNascimento
            // 
            chbxNaoInformarDataNascimento.AutoSize = true;
            chbxNaoInformarDataNascimento.Location = new Point(335, 66);
            chbxNaoInformarDataNascimento.Name = "chbxNaoInformarDataNascimento";
            chbxNaoInformarDataNascimento.Size = new Size(97, 19);
            chbxNaoInformarDataNascimento.TabIndex = 10;
            chbxNaoInformarDataNascimento.Text = "Não informar";
            chbxNaoInformarDataNascimento.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(3, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(408, 23);
            txtEmail.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 47);
            label15.Name = "label15";
            label15.Size = new Size(41, 15);
            label15.TabIndex = 28;
            label15.Text = "E-mail";
            // 
            // txtTelefone3
            // 
            txtTelefone3.CharacterCasing = CharacterCasing.Upper;
            txtTelefone3.Location = new Point(257, 21);
            txtTelefone3.Name = "txtTelefone3";
            txtTelefone3.Size = new Size(121, 23);
            txtTelefone3.TabIndex = 22;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Location = new Point(534, 526);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.Location = new Point(454, 526);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(257, 3);
            label14.Name = "label14";
            label14.Size = new Size(68, 15);
            label14.TabIndex = 26;
            label14.Text = "Telefone (3)";
            // 
            // txtTelefone2
            // 
            txtTelefone2.CharacterCasing = CharacterCasing.Upper;
            txtTelefone2.Location = new Point(130, 21);
            txtTelefone2.Name = "txtTelefone2";
            txtTelefone2.Size = new Size(121, 23);
            txtTelefone2.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(130, 3);
            label13.Name = "label13";
            label13.Size = new Size(68, 15);
            label13.TabIndex = 24;
            label13.Text = "Telefone (2)";
            // 
            // txtTelefone1
            // 
            txtTelefone1.CharacterCasing = CharacterCasing.Upper;
            txtTelefone1.Location = new Point(3, 21);
            txtTelefone1.Name = "txtTelefone1";
            txtTelefone1.Size = new Size(121, 23);
            txtTelefone1.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 3);
            label12.Name = "label12";
            label12.Size = new Size(68, 15);
            label12.TabIndex = 22;
            label12.Text = "Telefone (1)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(282, 179);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 20;
            label11.Text = "Estado (UF)";
            // 
            // txtCidade
            // 
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.Location = new Point(3, 197);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(276, 23);
            txtCidade.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 179);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 18;
            label10.Text = "Cidade";
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(3, 153);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(408, 23);
            txtBairro.TabIndex = 17;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoltar.Location = new Point(697, 526);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += BtnVoltar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.Location = new Point(373, 526);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += BtnEditar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 135);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 16;
            label9.Text = "Bairro";
            // 
            // gbxBusca
            // 
            gbxBusca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxBusca.Controls.Add(btnBuscarConsultaAvancada);
            gbxBusca.Controls.Add(txtBuscarCPF);
            gbxBusca.Location = new Point(18, 41);
            gbxBusca.Name = "gbxBusca";
            gbxBusca.Size = new Size(754, 64);
            gbxBusca.TabIndex = 8;
            gbxBusca.TabStop = false;
            gbxBusca.Text = "Buscar por CPF";
            // 
            // btnBuscarConsultaAvancada
            // 
            btnBuscarConsultaAvancada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarConsultaAvancada.Location = new Point(633, 22);
            btnBuscarConsultaAvancada.Name = "btnBuscarConsultaAvancada";
            btnBuscarConsultaAvancada.Size = new Size(115, 23);
            btnBuscarConsultaAvancada.TabIndex = 8;
            btnBuscarConsultaAvancada.Text = "Consulta avançada";
            btnBuscarConsultaAvancada.UseVisualStyleBackColor = true;
            btnBuscarConsultaAvancada.Click += BtnBuscarConsultaAvancada_Click;
            // 
            // txtBuscarCPF
            // 
            txtBuscarCPF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarCPF.Location = new Point(6, 22);
            txtBuscarCPF.Name = "txtBuscarCPF";
            txtBuscarCPF.Size = new Size(621, 23);
            txtBuscarCPF.TabIndex = 0;
            txtBuscarCPF.KeyPress += TxtBuscarCPF_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(616, 526);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // gbxDados
            // 
            gbxDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxDados.Controls.Add(tbcDados);
            gbxDados.Location = new Point(12, 111);
            gbxDados.Name = "gbxDados";
            gbxDados.Size = new Size(760, 409);
            gbxDados.TabIndex = 9;
            gbxDados.TabStop = false;
            gbxDados.Text = "Dados do funcionário";
            // 
            // tbcDados
            // 
            tbcDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbcDados.Controls.Add(tbpDadosPrincipais);
            tbcDados.Controls.Add(tbpLocalizacao);
            tbcDados.Controls.Add(tbpContato);
            tbcDados.Controls.Add(tbpUsuario);
            tbcDados.Location = new Point(6, 22);
            tbcDados.Name = "tbcDados";
            tbcDados.SelectedIndex = 0;
            tbcDados.Size = new Size(748, 387);
            tbcDados.TabIndex = 34;
            // 
            // tbpDadosPrincipais
            // 
            tbpDadosPrincipais.AutoScroll = true;
            tbpDadosPrincipais.Controls.Add(txtNomeCompleto);
            tbpDadosPrincipais.Controls.Add(cbbxCargo);
            tbpDadosPrincipais.Controls.Add(label2);
            tbpDadosPrincipais.Controls.Add(label1);
            tbpDadosPrincipais.Controls.Add(label3);
            tbpDadosPrincipais.Controls.Add(txtCPF);
            tbpDadosPrincipais.Controls.Add(label4);
            tbpDadosPrincipais.Controls.Add(txtRG);
            tbpDadosPrincipais.Controls.Add(label5);
            tbpDadosPrincipais.Controls.Add(chbxNaoInformarDataNascimento);
            tbpDadosPrincipais.Controls.Add(dtpDataNascimento);
            tbpDadosPrincipais.Location = new Point(4, 24);
            tbpDadosPrincipais.Name = "tbpDadosPrincipais";
            tbpDadosPrincipais.Padding = new Padding(3);
            tbpDadosPrincipais.Size = new Size(740, 359);
            tbpDadosPrincipais.TabIndex = 0;
            tbpDadosPrincipais.Text = "Dados principais";
            tbpDadosPrincipais.UseVisualStyleBackColor = true;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.CharacterCasing = CharacterCasing.Upper;
            txtNomeCompleto.Location = new Point(3, 21);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(256, 23);
            txtNomeCompleto.TabIndex = 3;
            // 
            // cbbxCargo
            // 
            cbbxCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbxCargo.FormattingEnabled = true;
            cbbxCargo.Location = new Point(6, 104);
            cbbxCargo.Name = "cbbxCargo";
            cbbxCargo.Size = new Size(207, 23);
            cbbxCargo.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome completo *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 86);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 33;
            label1.Text = "Cargo *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 3);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF *";
            // 
            // txtCPF
            // 
            txtCPF.CharacterCasing = CharacterCasing.Upper;
            txtCPF.Location = new Point(263, 21);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(168, 23);
            txtCPF.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 47);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 6;
            label4.Text = "RG";
            // 
            // txtRG
            // 
            txtRG.CharacterCasing = CharacterCasing.Upper;
            txtRG.Location = new Point(3, 65);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(223, 23);
            txtRG.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 47);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 8;
            label5.Text = "Data de nascimento";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(232, 65);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(99, 23);
            dtpDataNascimento.TabIndex = 9;
            // 
            // tbpLocalizacao
            // 
            tbpLocalizacao.AutoScroll = true;
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
            tbpLocalizacao.Controls.Add(label11);
            tbpLocalizacao.Controls.Add(label9);
            tbpLocalizacao.Controls.Add(txtBairro);
            tbpLocalizacao.Controls.Add(label10);
            tbpLocalizacao.Controls.Add(txtCidade);
            tbpLocalizacao.Location = new Point(4, 24);
            tbpLocalizacao.Name = "tbpLocalizacao";
            tbpLocalizacao.Padding = new Padding(3);
            tbpLocalizacao.Size = new Size(740, 359);
            tbpLocalizacao.TabIndex = 1;
            tbpLocalizacao.Text = "Localização";
            tbpLocalizacao.UseVisualStyleBackColor = true;
            // 
            // btnConsultarCEP
            // 
            btnConsultarCEP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultarCEP.Image = Properties.Resources.Consulta_CEP;
            btnConsultarCEP.Location = new Point(1407, 65);
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
            cbbxUF.Location = new Point(282, 197);
            cbbxUF.Margin = new Padding(2);
            cbbxUF.Name = "cbbxUF";
            cbbxUF.Size = new Size(129, 23);
            cbbxUF.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 10;
            label6.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Location = new Point(3, 21);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(295, 23);
            txtLogradouro.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(304, 3);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 12;
            label7.Text = "Nº";
            // 
            // txtLogradouroNumero
            // 
            txtLogradouroNumero.CharacterCasing = CharacterCasing.Upper;
            txtLogradouroNumero.Location = new Point(304, 21);
            txtLogradouroNumero.Name = "txtLogradouroNumero";
            txtLogradouroNumero.Size = new Size(107, 23);
            txtLogradouroNumero.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(304, 47);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 14;
            label8.Text = "CEP";
            // 
            // txtCEP
            // 
            txtCEP.CharacterCasing = CharacterCasing.Upper;
            txtCEP.Location = new Point(304, 65);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(107, 23);
            txtCEP.TabIndex = 14;
            // 
            // tbpContato
            // 
            tbpContato.Controls.Add(label12);
            tbpContato.Controls.Add(txtEmail);
            tbpContato.Controls.Add(txtTelefone1);
            tbpContato.Controls.Add(label15);
            tbpContato.Controls.Add(label13);
            tbpContato.Controls.Add(txtTelefone3);
            tbpContato.Controls.Add(txtTelefone2);
            tbpContato.Controls.Add(label14);
            tbpContato.Location = new Point(4, 24);
            tbpContato.Name = "tbpContato";
            tbpContato.Padding = new Padding(3);
            tbpContato.Size = new Size(740, 359);
            tbpContato.TabIndex = 2;
            tbpContato.Text = "Contato";
            tbpContato.UseVisualStyleBackColor = true;
            // 
            // tbpUsuario
            // 
            tbpUsuario.Controls.Add(gbxAlterarSenha);
            tbpUsuario.Controls.Add(gbxSenha);
            tbpUsuario.Controls.Add(txtNomeUsuario);
            tbpUsuario.Controls.Add(label20);
            tbpUsuario.Location = new Point(4, 24);
            tbpUsuario.Margin = new Padding(2);
            tbpUsuario.Name = "tbpUsuario";
            tbpUsuario.Padding = new Padding(2);
            tbpUsuario.Size = new Size(740, 359);
            tbpUsuario.TabIndex = 3;
            tbpUsuario.Text = "Usuário";
            tbpUsuario.UseVisualStyleBackColor = true;
            // 
            // gbxAlterarSenha
            // 
            gbxAlterarSenha.Controls.Add(chbxAlterarSenha);
            gbxAlterarSenha.Controls.Add(label21);
            gbxAlterarSenha.Controls.Add(txtConfirmeNovaSenha);
            gbxAlterarSenha.Controls.Add(txtNovaSenha);
            gbxAlterarSenha.Controls.Add(label22);
            gbxAlterarSenha.Controls.Add(txtSenhaAtual);
            gbxAlterarSenha.Controls.Add(label23);
            gbxAlterarSenha.Location = new Point(5, 155);
            gbxAlterarSenha.Name = "gbxAlterarSenha";
            gbxAlterarSenha.Size = new Size(442, 138);
            gbxAlterarSenha.TabIndex = 6;
            gbxAlterarSenha.TabStop = false;
            gbxAlterarSenha.Text = "Alterar senha";
            // 
            // chbxAlterarSenha
            // 
            chbxAlterarSenha.AutoSize = true;
            chbxAlterarSenha.Location = new Point(220, 40);
            chbxAlterarSenha.Name = "chbxAlterarSenha";
            chbxAlterarSenha.Size = new Size(104, 19);
            chbxAlterarSenha.TabIndex = 40;
            chbxAlterarSenha.Text = "Alterar a senha";
            chbxAlterarSenha.UseVisualStyleBackColor = true;
            chbxAlterarSenha.CheckedChanged += ChbxAlterarSenha_CheckedChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(7, 64);
            label21.Name = "label21";
            label21.Size = new Size(77, 15);
            label21.TabIndex = 36;
            label21.Text = "Nova senha *";
            // 
            // txtConfirmeNovaSenha
            // 
            txtConfirmeNovaSenha.Location = new Point(219, 81);
            txtConfirmeNovaSenha.Name = "txtConfirmeNovaSenha";
            txtConfirmeNovaSenha.Size = new Size(207, 23);
            txtConfirmeNovaSenha.TabIndex = 39;
            txtConfirmeNovaSenha.UseSystemPasswordChar = true;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(6, 81);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(207, 23);
            txtNovaSenha.TabIndex = 37;
            txtNovaSenha.UseSystemPasswordChar = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(220, 64);
            label22.Name = "label22";
            label22.Size = new Size(137, 15);
            label22.TabIndex = 38;
            label22.Text = "Confirme a nova senha *";
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Location = new Point(6, 37);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.Size = new Size(207, 23);
            txtSenhaAtual.TabIndex = 7;
            txtSenhaAtual.UseSystemPasswordChar = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(7, 20);
            label23.Name = "label23";
            label23.Size = new Size(73, 15);
            label23.TabIndex = 6;
            label23.Text = "Senha atual*";
            // 
            // gbxSenha
            // 
            gbxSenha.Controls.Add(label18);
            gbxSenha.Controls.Add(txtConfirmeASenha);
            gbxSenha.Controls.Add(txtSenha);
            gbxSenha.Controls.Add(label19);
            gbxSenha.Location = new Point(5, 49);
            gbxSenha.Name = "gbxSenha";
            gbxSenha.Size = new Size(442, 100);
            gbxSenha.TabIndex = 4;
            gbxSenha.TabStop = false;
            gbxSenha.Text = "Senha";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(7, 20);
            label18.Name = "label18";
            label18.Size = new Size(47, 15);
            label18.TabIndex = 4;
            label18.Text = "Senha *";
            // 
            // txtConfirmeASenha
            // 
            txtConfirmeASenha.Location = new Point(219, 37);
            txtConfirmeASenha.Name = "txtConfirmeASenha";
            txtConfirmeASenha.Size = new Size(207, 23);
            txtConfirmeASenha.TabIndex = 35;
            txtConfirmeASenha.UseSystemPasswordChar = true;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(6, 37);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(207, 23);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(220, 20);
            label19.Name = "label19";
            label19.Size = new Size(108, 15);
            label19.TabIndex = 34;
            label19.Text = "Confirme a senha *";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(5, 20);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(408, 23);
            txtNomeUsuario.TabIndex = 3;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(5, 2);
            label20.Name = "label20";
            label20.Size = new Size(106, 15);
            label20.TabIndex = 5;
            label20.Text = "Nome de usuário *";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cargosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // cargosToolStripMenuItem
            // 
            cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            cargosToolStripMenuItem.Size = new Size(56, 22);
            cargosToolStripMenuItem.Text = "Cargos";
            cargosToolStripMenuItem.Click += CargosToolStripMenuItem_Click;
            // 
            // FrmCadastroFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(btnEditar);
            Controls.Add(gbxBusca);
            Controls.Add(btnCancelar);
            Controls.Add(gbxDados);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmCadastroFuncionarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Funcionário";
            Load += FrmCadastroFuncionarios_Load;
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
            tbpUsuario.ResumeLayout(false);
            tbpUsuario.PerformLayout();
            gbxAlterarSenha.ResumeLayout(false);
            gbxAlterarSenha.PerformLayout();
            gbxSenha.ResumeLayout(false);
            gbxSenha.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovo;
        private TextBox txtReferencia;
        private Label label17;
        private TextBox txtComplemento;
        private Label label16;
        private CheckBox chbxNaoInformarDataNascimento;
        private TextBox txtEmail;
        private Label label15;
        private TextBox txtTelefone3;
        private Button btnSalvar;
        private Button btnExcluir;
        private Label label14;
        private TextBox txtTelefone2;
        private Label label13;
        private TextBox txtTelefone1;
        private Label label12;
        private Label label11;
        private TextBox txtCidade;
        private Label label10;
        private TextBox txtBairro;
        private Button btnVoltar;
        private Button btnEditar;
        private Label label9;
        private GroupBox gbxBusca;
        private Button btnBuscarConsultaAvancada;
        private TextBox txtBuscarCPF;
        private Button btnCancelar;
        private GroupBox gbxDados;
        private TextBox txtCEP;
        private Label label8;
        private TextBox txtLogradouroNumero;
        private Label label7;
        private TextBox txtLogradouro;
        private Label label6;
        private DateTimePicker dtpDataNascimento;
        private Label label5;
        private TextBox txtRG;
        private Label label4;
        private TextBox txtCPF;
        private Label label3;
        private TextBox txtNomeCompleto;
        private Label label2;
        private ComboBox cbbxCargo;
        private Label label1;
        private TabControl tbcDados;
        private TabPage tbpDadosPrincipais;
        private TabPage tbpLocalizacao;
        private TabPage tbpContato;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cargosToolStripMenuItem;
        private TabPage tbpUsuario;
        private GroupBox gbxSenha;
        private Label label18;
        private TextBox txtConfirmeASenha;
        private TextBox txtSenha;
        private Label label19;
        private TextBox txtNomeUsuario;
        private Label label20;
        private GroupBox gbxAlterarSenha;
        private CheckBox chbxAlterarSenha;
        private Label label21;
        private TextBox txtConfirmeNovaSenha;
        private TextBox txtNovaSenha;
        private Label label22;
        private TextBox txtSenhaAtual;
        private Label label23;
        private ComboBox cbbxUF;
        private Button btnConsultarCEP;
    }
}