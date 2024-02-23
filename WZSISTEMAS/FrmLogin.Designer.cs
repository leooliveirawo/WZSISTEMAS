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
            chbxAutenticacaoAutomatica = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cbbxNomeUsuario);
            groupBox1.Controls.Add(chbxMostrarSenha);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(lbSenha);
            groupBox1.Controls.Add(txtNomeUsuario);
            groupBox1.Controls.Add(label15);
            groupBox1.Location = new Point(8, 7);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(767, 523);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrar";
            // 
            // cbbxNomeUsuario
            // 
            cbbxNomeUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbxNomeUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbxNomeUsuario.FormattingEnabled = true;
            cbbxNomeUsuario.Location = new Point(5, 33);
            cbbxNomeUsuario.Margin = new Padding(2, 2, 2, 2);
            cbbxNomeUsuario.Name = "cbbxNomeUsuario";
            cbbxNomeUsuario.Size = new Size(487, 23);
            cbbxNomeUsuario.TabIndex = 35;
            cbbxNomeUsuario.SelectedIndexChanged += CbbxNomeUsuario_SelectedIndexChanged;
            // 
            // chbxMostrarSenha
            // 
            chbxMostrarSenha.AutoSize = true;
            chbxMostrarSenha.Location = new Point(657, 75);
            chbxMostrarSenha.Margin = new Padding(2, 2, 2, 2);
            chbxMostrarSenha.Name = "chbxMostrarSenha";
            chbxMostrarSenha.Size = new Size(101, 19);
            chbxMostrarSenha.TabIndex = 34;
            chbxMostrarSenha.Text = "Mostrar senha";
            chbxMostrarSenha.UseVisualStyleBackColor = true;
            chbxMostrarSenha.CheckedChanged += ChbxMostrarSenha_CheckedChanged;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(5, 74);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(486, 23);
            txtSenha.TabIndex = 33;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(5, 56);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 32;
            lbSenha.Text = "Senha";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeUsuario.Location = new Point(5, 34);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(486, 23);
            txtNomeUsuario.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 16);
            label15.Name = "label15";
            label15.Size = new Size(98, 15);
            label15.TabIndex = 30;
            label15.Text = "Nome de usuário";
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEntrar.Location = new Point(697, 534);
            btnEntrar.Margin = new Padding(2, 2, 2, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(78, 20);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += BtnEntrar_Click;
            // 
            // chbxSalvarCredenciais
            // 
            chbxSalvarCredenciais.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chbxSalvarCredenciais.AutoSize = true;
            chbxSalvarCredenciais.Location = new Point(573, 534);
            chbxSalvarCredenciais.Margin = new Padding(2, 2, 2, 2);
            chbxSalvarCredenciais.Name = "chbxSalvarCredenciais";
            chbxSalvarCredenciais.Size = new Size(119, 19);
            chbxSalvarCredenciais.TabIndex = 35;
            chbxSalvarCredenciais.Text = "Salvar credenciais";
            chbxSalvarCredenciais.UseVisualStyleBackColor = true;
            chbxSalvarCredenciais.CheckedChanged += ChbxSalvarCredenciais_CheckedChanged;
            // 
            // chbxAutenticacaoAutomatica
            // 
            chbxAutenticacaoAutomatica.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chbxAutenticacaoAutomatica.AutoSize = true;
            chbxAutenticacaoAutomatica.Location = new Point(8, 534);
            chbxAutenticacaoAutomatica.Margin = new Padding(2, 2, 2, 2);
            chbxAutenticacaoAutomatica.Name = "chbxAutenticacaoAutomatica";
            chbxAutenticacaoAutomatica.Size = new Size(159, 19);
            chbxAutenticacaoAutomatica.TabIndex = 37;
            chbxAutenticacaoAutomatica.Text = "Autenticação automática";
            chbxAutenticacaoAutomatica.UseVisualStyleBackColor = true;
            chbxAutenticacaoAutomatica.CheckedChanged += ChbxAutenticacaoAutomatica_CheckedChanged;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(chbxAutenticacaoAutomatica);
            Controls.Add(chbxSalvarCredenciais);
            Controls.Add(btnEntrar);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ComboBox cbbxNomeUsuario;
        private CheckBox chbxAutenticacaoAutomatica;
    }
}