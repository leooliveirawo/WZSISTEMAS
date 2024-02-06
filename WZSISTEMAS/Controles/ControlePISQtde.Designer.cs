namespace WZSISTEMAS.Controles;

partial class ControlePISQtde
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
        txtPIS_CST = new TextBox();
        label21 = new Label();
        txtPIS_vPIS = new TextBox();
        label20 = new Label();
        label26 = new Label();
        txtPIS_vAliqProd = new TextBox();
        txtPIS_qBCProd = new TextBox();
        label27 = new Label();
        SuspendLayout();
        // 
        // txtPIS_CST
        // 
        txtPIS_CST.CharacterCasing = CharacterCasing.Upper;
        txtPIS_CST.Location = new Point(4, 30);
        txtPIS_CST.Margin = new Padding(4, 5, 4, 5);
        txtPIS_CST.Name = "txtPIS_CST";
        txtPIS_CST.Size = new Size(143, 31);
        txtPIS_CST.TabIndex = 26;
        // 
        // label21
        // 
        label21.AutoSize = true;
        label21.Location = new Point(4, 0);
        label21.Margin = new Padding(4, 0, 4, 0);
        label21.Name = "label21";
        label21.Size = new Size(42, 25);
        label21.TabIndex = 25;
        label21.Text = "CST";
        // 
        // txtPIS_vPIS
        // 
        txtPIS_vPIS.CharacterCasing = CharacterCasing.Upper;
        txtPIS_vPIS.Location = new Point(457, 30);
        txtPIS_vPIS.Margin = new Padding(4, 5, 4, 5);
        txtPIS_vPIS.Name = "txtPIS_vPIS";
        txtPIS_vPIS.Size = new Size(143, 31);
        txtPIS_vPIS.TabIndex = 24;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Location = new Point(457, 0);
        label20.Margin = new Padding(4, 0, 4, 0);
        label20.Name = "label20";
        label20.Size = new Size(46, 25);
        label20.TabIndex = 23;
        label20.Text = "vPIS";
        // 
        // label26
        // 
        label26.AutoSize = true;
        label26.Location = new Point(155, 0);
        label26.Margin = new Padding(4, 0, 4, 0);
        label26.Name = "label26";
        label26.Size = new Size(82, 25);
        label26.TabIndex = 29;
        label26.Text = "qBCProd";
        // 
        // txtPIS_vAliqProd
        // 
        txtPIS_vAliqProd.CharacterCasing = CharacterCasing.Upper;
        txtPIS_vAliqProd.Location = new Point(306, 30);
        txtPIS_vAliqProd.Margin = new Padding(4, 5, 4, 5);
        txtPIS_vAliqProd.Name = "txtPIS_vAliqProd";
        txtPIS_vAliqProd.Size = new Size(143, 31);
        txtPIS_vAliqProd.TabIndex = 28;
        // 
        // txtPIS_qBCProd
        // 
        txtPIS_qBCProd.CharacterCasing = CharacterCasing.Upper;
        txtPIS_qBCProd.Location = new Point(155, 30);
        txtPIS_qBCProd.Margin = new Padding(4, 5, 4, 5);
        txtPIS_qBCProd.Name = "txtPIS_qBCProd";
        txtPIS_qBCProd.Size = new Size(143, 31);
        txtPIS_qBCProd.TabIndex = 30;
        // 
        // label27
        // 
        label27.AutoSize = true;
        label27.Location = new Point(306, 0);
        label27.Margin = new Padding(4, 0, 4, 0);
        label27.Name = "label27";
        label27.Size = new Size(90, 25);
        label27.TabIndex = 27;
        label27.Text = "vAliqProd";
        // 
        // ControlePISQtde
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(label26);
        Controls.Add(txtPIS_vAliqProd);
        Controls.Add(txtPIS_qBCProd);
        Controls.Add(label27);
        Controls.Add(txtPIS_CST);
        Controls.Add(label21);
        Controls.Add(txtPIS_vPIS);
        Controls.Add(label20);
        Name = "ControlePISQtde";
        Size = new Size(604, 66);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtPIS_CST;
    private Label label21;
    private TextBox txtPIS_vPIS;
    private Label label20;
    private Label label26;
    private TextBox txtPIS_vAliqProd;
    private TextBox txtPIS_qBCProd;
    private Label label27;
}
