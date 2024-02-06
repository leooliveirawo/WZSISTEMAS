namespace WZSISTEMAS.Controles;

partial class ControleICMSSN900
{
    /// <summary> 
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Código gerado pelo Designer de Componentes

    /// <summary> 
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
        txtICMS_CSOSN = new TextBox();
        label20 = new Label();
        txtICMS_orig = new TextBox();
        label21 = new Label();
        txtICMS_pICMS = new TextBox();
        label54 = new Label();
        SuspendLayout();
        // 
        // txtICMS_CSOSN
        // 
        txtICMS_CSOSN.CharacterCasing = CharacterCasing.Upper;
        txtICMS_CSOSN.Location = new Point(155, 30);
        txtICMS_CSOSN.Margin = new Padding(4, 5, 4, 5);
        txtICMS_CSOSN.Name = "txtICMS_CSOSN";
        txtICMS_CSOSN.Size = new Size(143, 31);
        txtICMS_CSOSN.TabIndex = 113;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Location = new Point(155, 0);
        label20.Margin = new Padding(4, 0, 4, 0);
        label20.Name = "label20";
        label20.Size = new Size(70, 25);
        label20.TabIndex = 112;
        label20.Text = "CSOSN";
        // 
        // txtICMS_orig
        // 
        txtICMS_orig.CharacterCasing = CharacterCasing.Upper;
        txtICMS_orig.Location = new Point(4, 30);
        txtICMS_orig.Margin = new Padding(4, 5, 4, 5);
        txtICMS_orig.Name = "txtICMS_orig";
        txtICMS_orig.Size = new Size(143, 31);
        txtICMS_orig.TabIndex = 111;
        // 
        // label21
        // 
        label21.AutoSize = true;
        label21.Location = new Point(4, 0);
        label21.Margin = new Padding(4, 0, 4, 0);
        label21.Name = "label21";
        label21.Size = new Size(44, 25);
        label21.TabIndex = 110;
        label21.Text = "orig";
        // 
        // txtICMS_pICMS
        // 
        txtICMS_pICMS.CharacterCasing = CharacterCasing.Upper;
        txtICMS_pICMS.Location = new Point(306, 30);
        txtICMS_pICMS.Margin = new Padding(4, 5, 4, 5);
        txtICMS_pICMS.Name = "txtICMS_pICMS";
        txtICMS_pICMS.Size = new Size(143, 31);
        txtICMS_pICMS.TabIndex = 115;
        // 
        // label54
        // 
        label54.AutoSize = true;
        label54.Location = new Point(306, 0);
        label54.Margin = new Padding(4, 0, 4, 0);
        label54.Name = "label54";
        label54.Size = new Size(65, 25);
        label54.TabIndex = 114;
        label54.Text = "pICMS";
        // 
        // ControleICMSSN900
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(txtICMS_pICMS);
        Controls.Add(label54);
        Controls.Add(txtICMS_CSOSN);
        Controls.Add(label20);
        Controls.Add(txtICMS_orig);
        Controls.Add(label21);
        DoubleBuffered = true;
        Name = "ControleICMSSN900";
        Size = new Size(604, 66);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox txtICMS_CSOSN;
    private Label label20;
    private TextBox txtICMS_orig;
    private Label label21;
    private TextBox txtICMS_pICMS;
    private Label label54;
}
