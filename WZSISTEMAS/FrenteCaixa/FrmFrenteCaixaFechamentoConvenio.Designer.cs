namespace WZSISTEMAS.FrenteCaixa;

partial class FrmFrenteCaixaFechamentoConvenio
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
        panel1 = new Panel();
        btnVoltar = new Button();
        btnConfirmar = new Button();
        groupBox3 = new GroupBox();
        lbValorTotal = new Label();
        groupBox2 = new GroupBox();
        lbParcela = new Label();
        nmduNumeroParcelas = new NumericUpDown();
        groupBox1 = new GroupBox();
        btnConsultar = new Button();
        label2 = new Label();
        txtNomeCompleto_RazaoSocial = new TextBox();
        label3 = new Label();
        txtCPF_CNPJ = new TextBox();
        panel1.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nmduNumeroParcelas).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.SeaGreen;
        panel1.Controls.Add(btnVoltar);
        panel1.Controls.Add(btnConfirmar);
        panel1.Controls.Add(groupBox3);
        panel1.Controls.Add(groupBox2);
        panel1.Controls.Add(groupBox1);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(10, 10);
        panel1.Name = "panel1";
        panel1.Size = new Size(1122, 416);
        panel1.TabIndex = 0;
        // 
        // btnVoltar
        // 
        btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnVoltar.ForeColor = Color.Black;
        btnVoltar.Location = new Point(1007, 379);
        btnVoltar.Name = "btnVoltar";
        btnVoltar.Size = new Size(112, 34);
        btnVoltar.TabIndex = 5;
        btnVoltar.Text = "Voltar";
        btnVoltar.UseVisualStyleBackColor = true;
        btnVoltar.Click += BtnVoltar_Click;
        // 
        // btnConfirmar
        // 
        btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnConfirmar.ForeColor = Color.Black;
        btnConfirmar.Location = new Point(889, 379);
        btnConfirmar.Name = "btnConfirmar";
        btnConfirmar.Size = new Size(112, 34);
        btnConfirmar.TabIndex = 4;
        btnConfirmar.Text = "Confirmar";
        btnConfirmar.UseVisualStyleBackColor = true;
        btnConfirmar.Click += BtnConfirmar_Click;
        // 
        // groupBox3
        // 
        groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBox3.Controls.Add(lbValorTotal);
        groupBox3.ForeColor = Color.WhiteSmoke;
        groupBox3.Location = new Point(6, 3);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(1110, 121);
        groupBox3.TabIndex = 3;
        groupBox3.TabStop = false;
        groupBox3.Text = "Total R$";
        // 
        // lbValorTotal
        // 
        lbValorTotal.Dock = DockStyle.Fill;
        lbValorTotal.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
        lbValorTotal.ForeColor = Color.WhiteSmoke;
        lbValorTotal.Location = new Point(3, 27);
        lbValorTotal.Name = "lbValorTotal";
        lbValorTotal.Size = new Size(1104, 91);
        lbValorTotal.TabIndex = 0;
        lbValorTotal.Text = "R$ 9999999,99";
        lbValorTotal.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(lbParcela);
        groupBox2.Controls.Add(nmduNumeroParcelas);
        groupBox2.ForeColor = Color.White;
        groupBox2.Location = new Point(9, 235);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(1110, 111);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "Parcelamento";
        // 
        // lbParcela
        // 
        lbParcela.AutoSize = true;
        lbParcela.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
        lbParcela.Location = new Point(193, 27);
        lbParcela.Name = "lbParcela";
        lbParcela.Size = new Size(185, 60);
        lbParcela.TabIndex = 2;
        lbParcela.Text = "R$ 0,00";
        // 
        // nmduNumeroParcelas
        // 
        nmduNumeroParcelas.Location = new Point(7, 46);
        nmduNumeroParcelas.Maximum = new decimal(new int[] { 56, 0, 0, 0 });
        nmduNumeroParcelas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nmduNumeroParcelas.Name = "nmduNumeroParcelas";
        nmduNumeroParcelas.Size = new Size(180, 31);
        nmduNumeroParcelas.TabIndex = 1;
        nmduNumeroParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
        nmduNumeroParcelas.ValueChanged += NmduNumeroParcelas_ValueChanged;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnConsultar);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(txtNomeCompleto_RazaoSocial);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(txtCPF_CNPJ);
        groupBox1.ForeColor = Color.White;
        groupBox1.Location = new Point(6, 130);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1110, 99);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Dados do cliente";
        // 
        // btnConsultar
        // 
        btnConsultar.ForeColor = Color.Black;
        btnConsultar.Location = new Point(885, 55);
        btnConsultar.Name = "btnConsultar";
        btnConsultar.Size = new Size(112, 34);
        btnConsultar.TabIndex = 10;
        btnConsultar.Text = "Consultar";
        btnConsultar.UseVisualStyleBackColor = true;
        btnConsultar.Click += BtnConsultar_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(7, 27);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(259, 25);
        label2.TabIndex = 6;
        label2.Text = "Nome completo/Razão social *";
        // 
        // txtNomeCompleto_RazaoSocial
        // 
        txtNomeCompleto_RazaoSocial.CharacterCasing = CharacterCasing.Upper;
        txtNomeCompleto_RazaoSocial.Enabled = false;
        txtNomeCompleto_RazaoSocial.ForeColor = Color.Black;
        txtNomeCompleto_RazaoSocial.Location = new Point(7, 57);
        txtNomeCompleto_RazaoSocial.Margin = new Padding(4, 5, 4, 5);
        txtNomeCompleto_RazaoSocial.Name = "txtNomeCompleto_RazaoSocial";
        txtNomeCompleto_RazaoSocial.Size = new Size(581, 31);
        txtNomeCompleto_RazaoSocial.TabIndex = 7;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(598, 27);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(101, 25);
        label3.TabIndex = 8;
        label3.Text = "CPF/CNPJ *";
        // 
        // txtCPF_CNPJ
        // 
        txtCPF_CNPJ.CharacterCasing = CharacterCasing.Upper;
        txtCPF_CNPJ.Enabled = false;
        txtCPF_CNPJ.ForeColor = Color.Black;
        txtCPF_CNPJ.Location = new Point(598, 57);
        txtCPF_CNPJ.Margin = new Padding(4, 5, 4, 5);
        txtCPF_CNPJ.Name = "txtCPF_CNPJ";
        txtCPF_CNPJ.Size = new Size(280, 31);
        txtCPF_CNPJ.TabIndex = 9;
        // 
        // FrmFrenteCaixaFechamentoConvenio
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DimGray;
        ClientSize = new Size(1142, 436);
        Controls.Add(panel1);
        DoubleBuffered = true;
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Name = "FrmFrenteCaixaFechamentoConvenio";
        Padding = new Padding(10);
        StartPosition = FormStartPosition.CenterParent;
        Text = "Convenio";
        Load += FrmFrenteCaixaFechamentoConvenio_Load;
        panel1.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nmduNumeroParcelas).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private GroupBox groupBox1;
    private Button btnConsultar;
    private Label label2;
    private TextBox txtNomeCompleto_RazaoSocial;
    private Label label3;
    private TextBox txtCPF_CNPJ;
    private GroupBox groupBox2;
    private NumericUpDown nmduNumeroParcelas;
    private Label lbParcela;
    private GroupBox groupBox3;
    private Label lbValorTotal;
    private Button btnVoltar;
    private Button btnConfirmar;
}