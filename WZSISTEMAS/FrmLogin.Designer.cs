namespace WZSISTEMAS
{
    partial class FrmLogin
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
            groupBox1 = new GroupBox();
            cbbxNomeUsuario = new ComboBox();
            chbxMostrarSenha = new CheckBox();
            txtSenha = new TextBox();
            lbSenha = new Label();
            txtNomeUsuario = new TextBox();
            label15 = new Label();
            btnEntrar = new Button();
            chbxSalvarCredenciais = new CheckBox();
            msDesenvolvedor = new MenuStrip();
            tsmiDesenvolvedor = new ToolStripMenuItem();
            tsmiManutencaoPreencherBancoDados = new ToolStripMenuItem();
            chbxAutenticacaoAutomatica = new CheckBox();
            groupBox1.SuspendLayout();
            msDesenvolvedor.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(cbbxNomeUsuario);
            groupBox1.Controls.Add(chbxMostrarSenha);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(lbSenha);
            groupBox1.Controls.Add(txtNomeUsuario);
            groupBox1.Controls.Add(label15);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1096, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrar";
            // 
            // cbbxNomeUsuario
            // 
            cbbxNomeUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbxNomeUsuario.FormattingEnabled = true;
            cbbxNomeUsuario.Location = new Point(7, 55);
            cbbxNomeUsuario.Name = "cbbxNomeUsuario";
            cbbxNomeUsuario.Size = new Size(1083, 33);
            cbbxNomeUsuario.TabIndex = 35;
            cbbxNomeUsuario.SelectedIndexChanged += CbbxNomeUsuario_SelectedIndexChanged;
            // 
            // chbxMostrarSenha
            // 
            chbxMostrarSenha.AutoSize = true;
            chbxMostrarSenha.Location = new Point(939, 125);
            chbxMostrarSenha.Name = "chbxMostrarSenha";
            chbxMostrarSenha.Size = new Size(151, 29);
            chbxMostrarSenha.TabIndex = 34;
            chbxMostrarSenha.Text = "Mostrar senha";
            chbxMostrarSenha.UseVisualStyleBackColor = true;
            chbxMostrarSenha.CheckedChanged += ChbxMostrarSenha_CheckedChanged;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(7, 123);
            txtSenha.Margin = new Padding(4, 5, 4, 5);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(925, 31);
            txtSenha.TabIndex = 33;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(7, 93);
            lbSenha.Margin = new Padding(4, 0, 4, 0);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(60, 25);
            lbSenha.TabIndex = 32;
            lbSenha.Text = "Senha";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeUsuario.Location = new Point(7, 57);
            txtNomeUsuario.Margin = new Padding(4, 5, 4, 5);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(1082, 31);
            txtNomeUsuario.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(7, 27);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(149, 25);
            label15.TabIndex = 30;
            label15.Text = "Nome de usuário";
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEntrar.Location = new Point(996, 283);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(112, 34);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += BtnEntrar_Click;
            // 
            // chbxSalvarCredenciais
            // 
            chbxSalvarCredenciais.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chbxSalvarCredenciais.AutoSize = true;
            chbxSalvarCredenciais.Location = new Point(814, 287);
            chbxSalvarCredenciais.Name = "chbxSalvarCredenciais";
            chbxSalvarCredenciais.Size = new Size(176, 29);
            chbxSalvarCredenciais.TabIndex = 35;
            chbxSalvarCredenciais.Text = "Salvar credenciais";
            chbxSalvarCredenciais.UseVisualStyleBackColor = true;
            chbxSalvarCredenciais.CheckedChanged += ChbxSalvarCredenciais_CheckedChanged;
            // 
            // msDesenvolvedor
            // 
            msDesenvolvedor.ImageScalingSize = new Size(24, 24);
            msDesenvolvedor.Items.AddRange(new ToolStripItem[] { tsmiDesenvolvedor });
            msDesenvolvedor.Location = new Point(0, 0);
            msDesenvolvedor.Name = "msDesenvolvedor";
            msDesenvolvedor.Size = new Size(1120, 33);
            msDesenvolvedor.TabIndex = 36;
            msDesenvolvedor.Text = "menuStrip1";
            // 
            // tsmiDesenvolvedor
            // 
            tsmiDesenvolvedor.DropDownItems.AddRange(new ToolStripItem[] { tsmiManutencaoPreencherBancoDados });
            tsmiDesenvolvedor.Name = "tsmiDesenvolvedor";
            tsmiDesenvolvedor.Size = new Size(147, 29);
            tsmiDesenvolvedor.Text = "Desenvolvedor";
            // 
            // tsmiManutencaoPreencherBancoDados
            // 
            tsmiManutencaoPreencherBancoDados.Name = "tsmiManutencaoPreencherBancoDados";
            tsmiManutencaoPreencherBancoDados.Size = new Size(325, 34);
            tsmiManutencaoPreencherBancoDados.Text = "Preencher banco de dados";
            tsmiManutencaoPreencherBancoDados.Click += TsmiManutencaoPreencherBancoDados_Click;
            // 
            // chbxAutenticacaoAutomatica
            // 
            chbxAutenticacaoAutomatica.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chbxAutenticacaoAutomatica.AutoSize = true;
            chbxAutenticacaoAutomatica.Location = new Point(12, 287);
            chbxAutenticacaoAutomatica.Name = "chbxAutenticacaoAutomatica";
            chbxAutenticacaoAutomatica.Size = new Size(233, 29);
            chbxAutenticacaoAutomatica.TabIndex = 37;
            chbxAutenticacaoAutomatica.Text = "Autenticação automática";
            chbxAutenticacaoAutomatica.UseVisualStyleBackColor = true;
            chbxAutenticacaoAutomatica.CheckedChanged += ChbxAutenticacaoAutomatica_CheckedChanged;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 329);
            Controls.Add(chbxAutenticacaoAutomatica);
            Controls.Add(chbxSalvarCredenciais);
            Controls.Add(btnEntrar);
            Controls.Add(groupBox1);
            Controls.Add(msDesenvolvedor);
            DoubleBuffered = true;
            MainMenuStrip = msDesenvolvedor;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            msDesenvolvedor.ResumeLayout(false);
            msDesenvolvedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEntrar;
        private TextBox txtNomeUsuario;
        private Label label15;
        private CheckBox chbxMostrarSenha;
        private TextBox txtSenha;
        private Label lbSenha;
        private CheckBox chbxSalvarCredenciais;
        private MenuStrip msDesenvolvedor;
        private ToolStripMenuItem tsmiDesenvolvedor;
        private ToolStripMenuItem tsmiManutencaoPreencherBancoDados;
        private ComboBox cbbxNomeUsuario;
        private CheckBox chbxAutenticacaoAutomatica;
    }
}