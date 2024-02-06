namespace WZSISTEMAS;

partial class FrmSimuladorCartao
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
        lbMensagem = new Label();
        btnAprovar = new Button();
        btnNaoAprovado = new Button();
        SuspendLayout();
        // 
        // lbMensagem
        // 
        lbMensagem.BackColor = Color.DimGray;
        lbMensagem.Dock = DockStyle.Top;
        lbMensagem.ForeColor = Color.WhiteSmoke;
        lbMensagem.Location = new Point(0, 0);
        lbMensagem.Name = "lbMensagem";
        lbMensagem.Size = new Size(800, 177);
        lbMensagem.TabIndex = 0;
        lbMensagem.Text = "Mensagem";
        lbMensagem.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnAprovar
        // 
        btnAprovar.BackColor = Color.SeaGreen;
        btnAprovar.FlatAppearance.BorderSize = 0;
        btnAprovar.FlatStyle = FlatStyle.Flat;
        btnAprovar.ForeColor = Color.WhiteSmoke;
        btnAprovar.Location = new Point(12, 180);
        btnAprovar.Name = "btnAprovar";
        btnAprovar.Size = new Size(112, 93);
        btnAprovar.TabIndex = 1;
        btnAprovar.Text = "APROVAR";
        btnAprovar.UseVisualStyleBackColor = false;
        btnAprovar.Click += BtnAprovar_Click;
        // 
        // btnNaoAprovado
        // 
        btnNaoAprovado.BackColor = Color.DarkRed;
        btnNaoAprovado.FlatAppearance.BorderSize = 0;
        btnNaoAprovado.FlatStyle = FlatStyle.Flat;
        btnNaoAprovado.ForeColor = Color.WhiteSmoke;
        btnNaoAprovado.Location = new Point(130, 180);
        btnNaoAprovado.Name = "btnNaoAprovado";
        btnNaoAprovado.Size = new Size(139, 93);
        btnNaoAprovado.TabIndex = 2;
        btnNaoAprovado.Text = "NÃO APROVAR";
        btnNaoAprovado.UseVisualStyleBackColor = false;
        btnNaoAprovado.Click += BtnNaoAprovado_Click;
        // 
        // FrmSimuladorCartao
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 285);
        Controls.Add(btnNaoAprovado);
        Controls.Add(btnAprovar);
        Controls.Add(lbMensagem);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        KeyPreview = true;
        Name = "FrmSimuladorCartao";
        StartPosition = FormStartPosition.CenterParent;
        Text = "MÁQUINA DE CARTÃO";
        Load += FrmSimuladorCartao_Load;
        ResumeLayout(false);
    }

    #endregion

    private Label lbMensagem;
    private Button btnAprovar;
    private Button btnNaoAprovado;
}