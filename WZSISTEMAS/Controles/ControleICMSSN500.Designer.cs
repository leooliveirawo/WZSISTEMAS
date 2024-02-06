namespace WZSISTEMAS.Controles;

partial class ControleICMSSN500
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
        txtICMS_vICMSSTRet = new TextBox();
        label55 = new Label();
        txtICMS_vBCSTRet = new TextBox();
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
        // txtICMS_vICMSSTRet
        // 
        txtICMS_vICMSSTRet.CharacterCasing = CharacterCasing.Upper;
        txtICMS_vICMSSTRet.Location = new Point(457, 30);
        txtICMS_vICMSSTRet.Margin = new Padding(4, 5, 4, 5);
        txtICMS_vICMSSTRet.Name = "txtICMS_vICMSSTRet";
        txtICMS_vICMSSTRet.Size = new Size(143, 31);
        txtICMS_vICMSSTRet.TabIndex = 117;
        // 
        // label55
        // 
        label55.AutoSize = true;
        label55.Location = new Point(457, 0);
        label55.Margin = new Padding(4, 0, 4, 0);
        label55.Name = "label55";
        label55.Size = new Size(107, 25);
        label55.TabIndex = 116;
        label55.Text = "vICMSSTRet";
        // 
        // txtICMS_vBCSTRet
        // 
        txtICMS_vBCSTRet.CharacterCasing = CharacterCasing.Upper;
        txtICMS_vBCSTRet.Location = new Point(306, 30);
        txtICMS_vBCSTRet.Margin = new Padding(4, 5, 4, 5);
        txtICMS_vBCSTRet.Name = "txtICMS_vBCSTRet";
        txtICMS_vBCSTRet.Size = new Size(143, 31);
        txtICMS_vBCSTRet.TabIndex = 115;
        // 
        // label54
        // 
        label54.AutoSize = true;
        label54.Location = new Point(306, 0);
        label54.Margin = new Padding(4, 0, 4, 0);
        label54.Name = "label54";
        label54.Size = new Size(86, 25);
        label54.TabIndex = 114;
        label54.Text = "vBCSTRet";
        // 
        // ControleICMSSN500
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(txtICMS_vICMSSTRet);
        Controls.Add(label55);
        Controls.Add(txtICMS_vBCSTRet);
        Controls.Add(label54);
        Controls.Add(txtICMS_CSOSN);
        Controls.Add(label20);
        Controls.Add(txtICMS_orig);
        Controls.Add(label21);
        DoubleBuffered = true;
        Name = "ControleICMSSN500";
        Size = new Size(604, 66);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox txtICMS_CSOSN;
    private Label label20;
    private TextBox txtICMS_orig;
    private Label label21;
    private TextBox txtICMS_vICMSSTRet;
    private Label label55;
    private TextBox txtICMS_vBCSTRet;
    private Label label54;
}
