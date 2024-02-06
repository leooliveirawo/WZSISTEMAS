namespace WZSISTEMAS.FrenteCaixa;

partial class FrmFrenteCaixaSelecionarPrecos
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
        groupBox1 = new GroupBox();
        label2 = new Label();
        label1 = new Label();
        rbtnPreco3 = new RadioButton();
        rbtnPreco2 = new RadioButton();
        rbtnPreco1 = new RadioButton();
        lbNomeProduto = new Label();
        panel1.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.WhiteSmoke;
        panel1.Controls.Add(groupBox1);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(10, 10);
        panel1.Name = "panel1";
        panel1.Size = new Size(535, 200);
        panel1.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(rbtnPreco3);
        groupBox1.Controls.Add(rbtnPreco2);
        groupBox1.Controls.Add(rbtnPreco1);
        groupBox1.Controls.Add(lbNomeProduto);
        groupBox1.Location = new Point(3, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(529, 194);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Seleciona um preço";
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(403, 166);
        label2.Name = "label2";
        label2.Size = new Size(120, 25);
        label2.TabIndex = 11;
        label2.Text = "VOLTAR (ESC)";
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(295, 166);
        label1.Name = "label1";
        label1.Size = new Size(102, 25);
        label1.TabIndex = 10;
        label1.Text = "OK (ENTER)";
        // 
        // rbtnPreco3
        // 
        rbtnPreco3.AutoSize = true;
        rbtnPreco3.Location = new Point(6, 125);
        rbtnPreco3.Name = "rbtnPreco3";
        rbtnPreco3.Size = new Size(143, 29);
        rbtnPreco3.TabIndex = 3;
        rbtnPreco3.TabStop = true;
        rbtnPreco3.Text = "(F3) - R$ 0,00";
        rbtnPreco3.UseVisualStyleBackColor = true;
        // 
        // rbtnPreco2
        // 
        rbtnPreco2.AutoSize = true;
        rbtnPreco2.Location = new Point(6, 90);
        rbtnPreco2.Name = "rbtnPreco2";
        rbtnPreco2.Size = new Size(143, 29);
        rbtnPreco2.TabIndex = 2;
        rbtnPreco2.TabStop = true;
        rbtnPreco2.Text = "(F2) - R$ 0,00";
        rbtnPreco2.UseVisualStyleBackColor = true;
        // 
        // rbtnPreco1
        // 
        rbtnPreco1.AutoSize = true;
        rbtnPreco1.Location = new Point(6, 55);
        rbtnPreco1.Name = "rbtnPreco1";
        rbtnPreco1.Size = new Size(143, 29);
        rbtnPreco1.TabIndex = 1;
        rbtnPreco1.TabStop = true;
        rbtnPreco1.Text = "(F1) - R$ 0,00";
        rbtnPreco1.UseVisualStyleBackColor = true;
        // 
        // lbNomeProduto
        // 
        lbNomeProduto.AutoSize = true;
        lbNomeProduto.Location = new Point(6, 27);
        lbNomeProduto.Name = "lbNomeProduto";
        lbNomeProduto.Size = new Size(159, 25);
        lbNomeProduto.TabIndex = 0;
        lbNomeProduto.Text = "Nome do produto";
        // 
        // FrmFrenteCaixaSelecionarPrecos
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DimGray;
        ClientSize = new Size(555, 220);
        Controls.Add(panel1);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Name = "FrmFrenteCaixaSelecionarPrecos";
        Padding = new Padding(10);
        StartPosition = FormStartPosition.CenterParent;
        Text = "Selecionar preço";
        Load += FrmFrenteCadastroSelecionarPrecos_Load;
        KeyDown += FrmFrenteCaixaSelecionarPrecos_KeyDown;
        KeyPress += FrmFrenteCadastroSelecionarPrecos_KeyPress;
        panel1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private GroupBox groupBox1;
    private Label lbNomeProduto;
    private RadioButton rbtnPreco1;
    private RadioButton rbtnPreco3;
    private RadioButton rbtnPreco2;
    private Label label2;
    private Label label1;
}