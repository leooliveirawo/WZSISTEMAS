namespace WZSISTEMAS.FrenteCaixa;

partial class FrmFrenteCaixaFechamentoCartao
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
        lbMensagem = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.White;
        panel1.Controls.Add(lbMensagem);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(10, 10);
        panel1.Name = "panel1";
        panel1.Size = new Size(667, 368);
        panel1.TabIndex = 0;
        // 
        // lbMensagem
        // 
        lbMensagem.Dock = DockStyle.Fill;
        lbMensagem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbMensagem.Location = new Point(0, 0);
        lbMensagem.Name = "lbMensagem";
        lbMensagem.Size = new Size(667, 368);
        lbMensagem.TabIndex = 0;
        lbMensagem.Text = "AGUARDANDO...";
        lbMensagem.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FrmFrenteCaixaFechamentoCartao
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DimGray;
        ClientSize = new Size(687, 388);
        Controls.Add(panel1);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Name = "FrmFrenteCaixaFechamentoCartao";
        Padding = new Padding(10);
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cartão";
        FormClosing += FrmFrenteCaixaFechamentoCartao_FormClosing;
        Load += FrmFrenteCaixaFechamentoCartao_Load;
        KeyDown += FrmFrenteCaixaFechamentoCartao_KeyDown;
        KeyPress += FrmFrenteCaixaFechamentoCartao_KeyPress;
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label lbMensagem;
}