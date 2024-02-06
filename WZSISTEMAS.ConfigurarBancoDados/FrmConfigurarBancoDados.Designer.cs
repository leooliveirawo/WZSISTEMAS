namespace WZSISTEMAS.ConfigurarBancoDados;

partial class FrmConfigurarBancoDados
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        groupBox1 = new GroupBox();
        rbtnAutenticacaoSQLServer = new RadioButton();
        rbtnAutenticacaoWindows = new RadioButton();
        groupBox2 = new GroupBox();
        lbSenha = new Label();
        txtSenha = new TextBox();
        label1 = new Label();
        txtNomeUsuario = new TextBox();
        chbxUsarCriptografia = new CheckBox();
        chbxPossuiCertificado = new CheckBox();
        groupBox3 = new GroupBox();
        rbtnModoLeituraEEscrita = new RadioButton();
        rbtnModoSomenteLeitura = new RadioButton();
        groupBox4 = new GroupBox();
        txtServidor = new TextBox();
        groupBox5 = new GroupBox();
        txtBancoDados = new TextBox();
        btnSalvar = new Button();
        btnImportar = new Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox5.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(rbtnAutenticacaoSQLServer);
        groupBox1.Controls.Add(rbtnAutenticacaoWindows);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(776, 72);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Tipo de conexão";
        // 
        // rbtnAutenticacaoSQLServer
        // 
        rbtnAutenticacaoSQLServer.AutoSize = true;
        rbtnAutenticacaoSQLServer.Location = new Point(257, 30);
        rbtnAutenticacaoSQLServer.Name = "rbtnAutenticacaoSQLServer";
        rbtnAutenticacaoSQLServer.Size = new Size(257, 29);
        rbtnAutenticacaoSQLServer.TabIndex = 3;
        rbtnAutenticacaoSQLServer.TabStop = true;
        rbtnAutenticacaoSQLServer.Text = "Autenticação do SQL Server";
        rbtnAutenticacaoSQLServer.UseVisualStyleBackColor = true;
        // 
        // rbtnAutenticacaoWindows
        // 
        rbtnAutenticacaoWindows.AutoSize = true;
        rbtnAutenticacaoWindows.Location = new Point(6, 30);
        rbtnAutenticacaoWindows.Name = "rbtnAutenticacaoWindows";
        rbtnAutenticacaoWindows.Size = new Size(245, 29);
        rbtnAutenticacaoWindows.TabIndex = 2;
        rbtnAutenticacaoWindows.TabStop = true;
        rbtnAutenticacaoWindows.Text = "Autenticação do Windows";
        rbtnAutenticacaoWindows.UseVisualStyleBackColor = true;
        rbtnAutenticacaoWindows.CheckedChanged += RbtnAutenticacaoWindows_CheckedChanged;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(lbSenha);
        groupBox2.Controls.Add(txtSenha);
        groupBox2.Controls.Add(label1);
        groupBox2.Controls.Add(txtNomeUsuario);
        groupBox2.Location = new Point(12, 90);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(776, 98);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Credenciais";
        // 
        // lbSenha
        // 
        lbSenha.AutoSize = true;
        lbSenha.Location = new Point(320, 27);
        lbSenha.Name = "lbSenha";
        lbSenha.Size = new Size(60, 25);
        lbSenha.TabIndex = 3;
        lbSenha.Text = "Senha";
        // 
        // txtSenha
        // 
        txtSenha.Location = new Point(320, 55);
        txtSenha.Name = "txtSenha";
        txtSenha.Size = new Size(309, 31);
        txtSenha.TabIndex = 2;
        txtSenha.UseSystemPasswordChar = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 27);
        label1.Name = "label1";
        label1.Size = new Size(149, 25);
        label1.TabIndex = 1;
        label1.Text = "Nome de usuário";
        // 
        // txtNomeUsuario
        // 
        txtNomeUsuario.Location = new Point(6, 55);
        txtNomeUsuario.Name = "txtNomeUsuario";
        txtNomeUsuario.Size = new Size(308, 31);
        txtNomeUsuario.TabIndex = 0;
        // 
        // chbxUsarCriptografia
        // 
        chbxUsarCriptografia.AutoSize = true;
        chbxUsarCriptografia.Location = new Point(349, 225);
        chbxUsarCriptografia.Name = "chbxUsarCriptografia";
        chbxUsarCriptografia.Size = new Size(169, 29);
        chbxUsarCriptografia.TabIndex = 2;
        chbxUsarCriptografia.Text = "Usar criptografia";
        chbxUsarCriptografia.UseVisualStyleBackColor = true;
        // 
        // chbxPossuiCertificado
        // 
        chbxPossuiCertificado.AutoSize = true;
        chbxPossuiCertificado.Location = new Point(524, 224);
        chbxPossuiCertificado.Name = "chbxPossuiCertificado";
        chbxPossuiCertificado.Size = new Size(175, 29);
        chbxPossuiCertificado.TabIndex = 3;
        chbxPossuiCertificado.Text = "Possui certificado";
        chbxPossuiCertificado.UseVisualStyleBackColor = true;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(rbtnModoLeituraEEscrita);
        groupBox3.Controls.Add(rbtnModoSomenteLeitura);
        groupBox3.Location = new Point(12, 194);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(331, 66);
        groupBox3.TabIndex = 4;
        groupBox3.TabStop = false;
        groupBox3.Text = "Modo de conexão";
        // 
        // rbtnModoLeituraEEscrita
        // 
        rbtnModoLeituraEEscrita.AutoSize = true;
        rbtnModoLeituraEEscrita.Location = new Point(173, 30);
        rbtnModoLeituraEEscrita.Name = "rbtnModoLeituraEEscrita";
        rbtnModoLeituraEEscrita.Size = new Size(158, 29);
        rbtnModoLeituraEEscrita.TabIndex = 1;
        rbtnModoLeituraEEscrita.TabStop = true;
        rbtnModoLeituraEEscrita.Text = "Leitura e escrita";
        rbtnModoLeituraEEscrita.UseVisualStyleBackColor = true;
        // 
        // rbtnModoSomenteLeitura
        // 
        rbtnModoSomenteLeitura.AutoSize = true;
        rbtnModoSomenteLeitura.Location = new Point(6, 30);
        rbtnModoSomenteLeitura.Name = "rbtnModoSomenteLeitura";
        rbtnModoSomenteLeitura.Size = new Size(161, 29);
        rbtnModoSomenteLeitura.TabIndex = 0;
        rbtnModoSomenteLeitura.TabStop = true;
        rbtnModoSomenteLeitura.Text = "Somente leitura";
        rbtnModoSomenteLeitura.UseVisualStyleBackColor = true;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(txtServidor);
        groupBox4.Location = new Point(12, 266);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(776, 69);
        groupBox4.TabIndex = 5;
        groupBox4.TabStop = false;
        groupBox4.Text = "Servidor";
        // 
        // txtServidor
        // 
        txtServidor.Location = new Point(6, 30);
        txtServidor.Name = "txtServidor";
        txtServidor.Size = new Size(520, 31);
        txtServidor.TabIndex = 1;
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(txtBancoDados);
        groupBox5.Location = new Point(12, 333);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new Size(776, 69);
        groupBox5.TabIndex = 6;
        groupBox5.TabStop = false;
        groupBox5.Text = "Banco de dados";
        // 
        // txtBancoDados
        // 
        txtBancoDados.Location = new Point(6, 30);
        txtBancoDados.Name = "txtBancoDados";
        txtBancoDados.Size = new Size(520, 31);
        txtBancoDados.TabIndex = 1;
        // 
        // btnSalvar
        // 
        btnSalvar.Location = new Point(558, 408);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(112, 34);
        btnSalvar.TabIndex = 7;
        btnSalvar.Text = "Salvar";
        btnSalvar.UseVisualStyleBackColor = true;
        btnSalvar.Click += BtnSalvar_Click;
        // 
        // btnImportar
        // 
        btnImportar.Location = new Point(676, 408);
        btnImportar.Name = "btnImportar";
        btnImportar.Size = new Size(112, 34);
        btnImportar.TabIndex = 8;
        btnImportar.Text = "Importar";
        btnImportar.UseVisualStyleBackColor = true;
        btnImportar.Click += BtnImportar_Click;
        // 
        // FrmConfigurarBancoDados
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 454);
        Controls.Add(btnImportar);
        Controls.Add(btnSalvar);
        Controls.Add(groupBox5);
        Controls.Add(groupBox4);
        Controls.Add(groupBox3);
        Controls.Add(chbxPossuiCertificado);
        Controls.Add(chbxUsarCriptografia);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FrmConfigurarBancoDados";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Configurar o banco de dados";
        Load += FrmConfigurarBancoDados_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        groupBox5.ResumeLayout(false);
        groupBox5.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private CheckBox chbxUsarCriptografia;
    private CheckBox chbxPossuiCertificado;
    private RadioButton rbtnAutenticacaoSQLServer;
    private RadioButton rbtnAutenticacaoWindows;
    private GroupBox groupBox3;
    private RadioButton rbtnModoLeituraEEscrita;
    private RadioButton rbtnModoSomenteLeitura;
    private Label lbSenha;
    private TextBox txtSenha;
    private Label label1;
    private TextBox txtNomeUsuario;
    private GroupBox groupBox4;
    private TextBox txtServidor;
    private GroupBox groupBox5;
    private TextBox txtBancoDados;
    private Button btnSalvar;
    private Button btnImportar;
}
