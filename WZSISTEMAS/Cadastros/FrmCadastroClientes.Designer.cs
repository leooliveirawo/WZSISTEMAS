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
            txtReferencia = new TextBox();
            label17 = new Label();
            txtComplemento = new TextBox();
            label16 = new Label();
            chbxNaoInformarDataNascimento = new CheckBox();
            txtEmail = new TextBox();
            label15 = new Label();
            txtTelefone3 = new TextBox();
            label14 = new Label();
            txtTelefone2 = new TextBox();
            label13 = new Label();
            txtTelefone1 = new TextBox();
            label12 = new Label();
            txtEstadoUF = new TextBox();
            label11 = new Label();
            txtCidade = new TextBox();
            label10 = new Label();
            txtBairro = new TextBox();
            label9 = new Label();
            txtCEP = new TextBox();
            label8 = new Label();
            txtLogradouroNumero = new TextBox();
            label7 = new Label();
            txtLogradouro = new TextBox();
            label6 = new Label();
            dtpDataNascimento = new DateTimePicker();
            label5 = new Label();
            txtRG_InscricaoEstadual = new TextBox();
            label4 = new Label();
            txtCPF_CNPJ = new TextBox();
            label3 = new Label();
            txtNomeCompleto_RazaoSocial = new TextBox();
            label2 = new Label();
            cbbxTipo = new ComboBox();
            label1 = new Label();
            btnNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnVoltar = new Button();
            gbxBusca.SuspendLayout();
            gbxDados.SuspendLayout();
            SuspendLayout();
            // 
            // gbxBusca
            // 
            gbxBusca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxBusca.Controls.Add(btnBuscarConsultaAvancada);
            gbxBusca.Controls.Add(txtBuscarCPF_CNPJ);
            gbxBusca.Location = new Point(12, 12);
            gbxBusca.Name = "gbxBusca";
            gbxBusca.Size = new Size(760, 64);
            gbxBusca.TabIndex = 0;
            gbxBusca.TabStop = false;
            gbxBusca.Text = "Buscar por CPF/CNPJ";
            // 
            // btnBuscarConsultaAvancada
            // 
            btnBuscarConsultaAvancada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarConsultaAvancada.Location = new Point(639, 22);
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
            txtBuscarCPF_CNPJ.Size = new Size(627, 23);
            txtBuscarCPF_CNPJ.TabIndex = 0;
            txtBuscarCPF_CNPJ.KeyPress += TxtBuscarCPF_CNPJ_KeyPress;
            // 
            // gbxDados
            // 
            gbxDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxDados.Controls.Add(txtReferencia);
            gbxDados.Controls.Add(label17);
            gbxDados.Controls.Add(txtComplemento);
            gbxDados.Controls.Add(label16);
            gbxDados.Controls.Add(chbxNaoInformarDataNascimento);
            gbxDados.Controls.Add(txtEmail);
            gbxDados.Controls.Add(label15);
            gbxDados.Controls.Add(txtTelefone3);
            gbxDados.Controls.Add(label14);
            gbxDados.Controls.Add(txtTelefone2);
            gbxDados.Controls.Add(label13);
            gbxDados.Controls.Add(txtTelefone1);
            gbxDados.Controls.Add(label12);
            gbxDados.Controls.Add(txtEstadoUF);
            gbxDados.Controls.Add(label11);
            gbxDados.Controls.Add(txtCidade);
            gbxDados.Controls.Add(label10);
            gbxDados.Controls.Add(txtBairro);
            gbxDados.Controls.Add(label9);
            gbxDados.Controls.Add(txtCEP);
            gbxDados.Controls.Add(label8);
            gbxDados.Controls.Add(txtLogradouroNumero);
            gbxDados.Controls.Add(label7);
            gbxDados.Controls.Add(txtLogradouro);
            gbxDados.Controls.Add(label6);
            gbxDados.Controls.Add(dtpDataNascimento);
            gbxDados.Controls.Add(label5);
            gbxDados.Controls.Add(txtRG_InscricaoEstadual);
            gbxDados.Controls.Add(label4);
            gbxDados.Controls.Add(txtCPF_CNPJ);
            gbxDados.Controls.Add(label3);
            gbxDados.Controls.Add(txtNomeCompleto_RazaoSocial);
            gbxDados.Controls.Add(label2);
            gbxDados.Controls.Add(cbbxTipo);
            gbxDados.Controls.Add(label1);
            gbxDados.Location = new Point(12, 82);
            gbxDados.Name = "gbxDados";
            gbxDados.Size = new Size(760, 438);
            gbxDados.TabIndex = 1;
            gbxDados.TabStop = false;
            gbxDados.Text = "Dados do cliente";
            // 
            // txtReferencia
            // 
            txtReferencia.CharacterCasing = CharacterCasing.Upper;
            txtReferencia.Location = new Point(133, 213);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(408, 23);
            txtReferencia.TabIndex = 17;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(133, 195);
            label17.Name = "label17";
            label17.Size = new Size(62, 15);
            label17.TabIndex = 32;
            label17.Text = "Referência";
            // 
            // txtComplemento
            // 
            txtComplemento.CharacterCasing = CharacterCasing.Upper;
            txtComplemento.Location = new Point(133, 169);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(408, 23);
            txtComplemento.TabIndex = 16;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(133, 151);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 16;
            label16.Text = "Complemento";
            // 
            // chbxNaoInformarDataNascimento
            // 
            chbxNaoInformarDataNascimento.AutoSize = true;
            chbxNaoInformarDataNascimento.Location = new Point(449, 83);
            chbxNaoInformarDataNascimento.Name = "chbxNaoInformarDataNascimento";
            chbxNaoInformarDataNascimento.Size = new Size(97, 19);
            chbxNaoInformarDataNascimento.TabIndex = 10;
            chbxNaoInformarDataNascimento.Text = "Não informar";
            chbxNaoInformarDataNascimento.UseVisualStyleBackColor = true;
            chbxNaoInformarDataNascimento.CheckedChanged += ChbxNaoInformarDataNascimento_CheckedChanged;
            // 
            // txtEmail
            // 
            txtEmail.CharacterCasing = CharacterCasing.Upper;
            txtEmail.Location = new Point(133, 389);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(408, 23);
            txtEmail.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(133, 371);
            label15.Name = "label15";
            label15.Size = new Size(41, 15);
            label15.TabIndex = 28;
            label15.Text = "E-mail";
            // 
            // txtTelefone3
            // 
            txtTelefone3.CharacterCasing = CharacterCasing.Upper;
            txtTelefone3.Location = new Point(387, 345);
            txtTelefone3.Name = "txtTelefone3";
            txtTelefone3.Size = new Size(121, 23);
            txtTelefone3.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(387, 327);
            label14.Name = "label14";
            label14.Size = new Size(68, 15);
            label14.TabIndex = 26;
            label14.Text = "Telefone (3)";
            // 
            // txtTelefone2
            // 
            txtTelefone2.CharacterCasing = CharacterCasing.Upper;
            txtTelefone2.Location = new Point(260, 345);
            txtTelefone2.Name = "txtTelefone2";
            txtTelefone2.Size = new Size(121, 23);
            txtTelefone2.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(260, 327);
            label13.Name = "label13";
            label13.Size = new Size(68, 15);
            label13.TabIndex = 24;
            label13.Text = "Telefone (2)";
            // 
            // txtTelefone1
            // 
            txtTelefone1.CharacterCasing = CharacterCasing.Upper;
            txtTelefone1.Location = new Point(133, 345);
            txtTelefone1.Name = "txtTelefone1";
            txtTelefone1.Size = new Size(121, 23);
            txtTelefone1.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(133, 327);
            label12.Name = "label12";
            label12.Size = new Size(68, 15);
            label12.TabIndex = 22;
            label12.Text = "Telefone (1)";
            // 
            // txtEstadoUF
            // 
            txtEstadoUF.CharacterCasing = CharacterCasing.Upper;
            txtEstadoUF.Location = new Point(547, 301);
            txtEstadoUF.Name = "txtEstadoUF";
            txtEstadoUF.Size = new Size(107, 23);
            txtEstadoUF.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(547, 283);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 20;
            label11.Text = "Estado (UF)";
            // 
            // txtCidade
            // 
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.Location = new Point(133, 301);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(408, 23);
            txtCidade.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(133, 283);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 18;
            label10.Text = "Cidade";
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(133, 257);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(408, 23);
            txtBairro.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(133, 239);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 16;
            label9.Text = "Bairro";
            // 
            // txtCEP
            // 
            txtCEP.CharacterCasing = CharacterCasing.Upper;
            txtCEP.Location = new Point(660, 125);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(94, 23);
            txtCEP.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(660, 107);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 14;
            label8.Text = "CEP";
            // 
            // txtLogradouroNumero
            // 
            txtLogradouroNumero.CharacterCasing = CharacterCasing.Upper;
            txtLogradouroNumero.Location = new Point(547, 125);
            txtLogradouroNumero.Name = "txtLogradouroNumero";
            txtLogradouroNumero.Size = new Size(107, 23);
            txtLogradouroNumero.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(547, 107);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 12;
            label7.Text = "Nº";
            // 
            // txtLogradouro
            // 
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Location = new Point(133, 125);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(408, 23);
            txtLogradouro.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 107);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 10;
            label6.Text = "Logradouro";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(362, 81);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(81, 23);
            dtpDataNascimento.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 63);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 8;
            label5.Text = "Data de nascimento";
            // 
            // txtRG_InscricaoEstadual
            // 
            txtRG_InscricaoEstadual.CharacterCasing = CharacterCasing.Upper;
            txtRG_InscricaoEstadual.Location = new Point(133, 81);
            txtRG_InscricaoEstadual.Name = "txtRG_InscricaoEstadual";
            txtRG_InscricaoEstadual.Size = new Size(223, 23);
            txtRG_InscricaoEstadual.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 63);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 6;
            label4.Text = "RG/Inscrição estadual";
            // 
            // txtCPF_CNPJ
            // 
            txtCPF_CNPJ.CharacterCasing = CharacterCasing.Upper;
            txtCPF_CNPJ.Location = new Point(547, 37);
            txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            txtCPF_CNPJ.Size = new Size(207, 23);
            txtCPF_CNPJ.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 19);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF/CNPJ *";
            // 
            // txtNomeCompleto_RazaoSocial
            // 
            txtNomeCompleto_RazaoSocial.CharacterCasing = CharacterCasing.Upper;
            txtNomeCompleto_RazaoSocial.Location = new Point(133, 37);
            txtNomeCompleto_RazaoSocial.Name = "txtNomeCompleto_RazaoSocial";
            txtNomeCompleto_RazaoSocial.Size = new Size(408, 23);
            txtNomeCompleto_RazaoSocial.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 19);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome completo/Razão social *";
            // 
            // cbbxTipo
            // 
            cbbxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbxTipo.FormattingEnabled = true;
            cbbxTipo.Items.AddRange(new object[] { "Pessoa fisca", "Pessoa juridica" });
            cbbxTipo.Location = new Point(6, 37);
            cbbxTipo.Name = "cbbxTipo";
            cbbxTipo.Size = new Size(121, 23);
            cbbxTipo.TabIndex = 1;
            cbbxTipo.SelectedIndexChanged += CbbxTipo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo *";
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.Location = new Point(292, 526);
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
            btnEditar.Location = new Point(373, 526);
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
            btnExcluir.Location = new Point(454, 526);
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
            btnSalvar.Location = new Point(535, 526);
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
            btnCancelar.Location = new Point(616, 526);
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
            btnVoltar.Location = new Point(697, 526);
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
            Name = "FrmCadastroClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cliente";
            Load += FrmCadastroClientes_Load;
            gbxBusca.ResumeLayout(false);
            gbxBusca.PerformLayout();
            gbxDados.ResumeLayout(false);
            gbxDados.PerformLayout();
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
        private TextBox txtEstadoUF;
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
    }
}