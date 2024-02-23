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
        btnSoliciteASenha = new Button();
        btnAguarde = new Button();
        SuspendLayout();
        // 
        // lbMensagem
        // 
        lbMensagem.BackColor = Color.DimGray;
        lbMensagem.Dock = DockStyle.Top;
        lbMensagem.ForeColor = Color.WhiteSmoke;
        lbMensagem.Location = new Point(0, 0);
        lbMensagem.Margin = new Padding(2, 0, 2, 0);
        lbMensagem.Name = "lbMensagem";
        lbMensagem.Size = new Size(560, 106);
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
        btnAprovar.Location = new Point(8, 108);
        btnAprovar.Margin = new Padding(2);
        btnAprovar.Name = "btnAprovar";
        btnAprovar.Size = new Size(78, 56);
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
        btnNaoAprovado.Location = new Point(91, 108);
        btnNaoAprovado.Margin = new Padding(2);
        btnNaoAprovado.Name = "btnNaoAprovado";
        btnNaoAprovado.Size = new Size(97, 56);
        btnNaoAprovado.TabIndex = 2;
        btnNaoAprovado.Text = "NÃO APROVAR";
        btnNaoAprovado.UseVisualStyleBackColor = false;
        btnNaoAprovado.Click += BtnNaoAprovado_Click;
        // 
        // btnSoliciteASenha
        // 
        btnSoliciteASenha.BackColor = Color.SaddleBrown;
        btnSoliciteASenha.FlatAppearance.BorderSize = 0;
        btnSoliciteASenha.FlatStyle = FlatStyle.Flat;
        btnSoliciteASenha.ForeColor = Color.WhiteSmoke;
        btnSoliciteASenha.Location = new Point(192, 108);
        btnSoliciteASenha.Margin = new Padding(2);
        btnSoliciteASenha.Name = "btnSoliciteASenha";
        btnSoliciteASenha.Size = new Size(97, 56);
        btnSoliciteASenha.TabIndex = 4;
        btnSoliciteASenha.Text = "SOLICITE A SENHA";
        btnSoliciteASenha.UseVisualStyleBackColor = false;
        btnSoliciteASenha.Click += btnSoliciteASenha_Click;
        // 
        // btnAguarde
        // 
        btnAguarde.BackColor = Color.SaddleBrown;
        btnAguarde.FlatAppearance.BorderSize = 0;
        btnAguarde.FlatStyle = FlatStyle.Flat;
        btnAguarde.ForeColor = Color.WhiteSmoke;
        btnAguarde.Location = new Point(293, 108);
        btnAguarde.Margin = new Padding(2);
        btnAguarde.Name = "btnAguarde";
        btnAguarde.Size = new Size(97, 56);
        btnAguarde.TabIndex = 5;
        btnAguarde.Text = "AGUARDE";
        btnAguarde.UseVisualStyleBackColor = false;
        btnAguarde.Click += btnAguarde_Click;
        // 
        // FrmSimuladorCartao
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(560, 171);
        Controls.Add(btnAguarde);
        Controls.Add(btnSoliciteASenha);
        Controls.Add(btnNaoAprovado);
        Controls.Add(btnAprovar);
        Controls.Add(lbMensagem);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        KeyPreview = true;
        Margin = new Padding(2);
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
    private Button btnSoliciteASenha;
    private Button btnAguarde;
}