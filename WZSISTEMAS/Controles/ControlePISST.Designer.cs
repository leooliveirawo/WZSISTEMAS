namespace WZSISTEMAS.Controles;

partial class ControlePISST
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
        txtPIS_vPIS = new TextBox();
        label20 = new Label();
        label23 = new Label();
        txtPIS_pPIS = new TextBox();
        txtPIS_vBC = new TextBox();
        label24 = new Label();
        label26 = new Label();
        txtPIS_vAliqProd = new TextBox();
        txtPIS_qBCProd = new TextBox();
        label27 = new Label();
        SuspendLayout();
        // 
        // txtPIS_vPIS
        // 
        txtPIS_vPIS.CharacterCasing = CharacterCasing.Upper;
        txtPIS_vPIS.Location = new Point(4, 96);
        txtPIS_vPIS.Margin = new Padding(4, 5, 4, 5);
        txtPIS_vPIS.Name = "txtPIS_vPIS";
        txtPIS_vPIS.Size = new Size(143, 31);
        txtPIS_vPIS.TabIndex = 32;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Location = new Point(4, 66);
        label20.Margin = new Padding(4, 0, 4, 0);
        label20.Name = "label20";
        label20.Size = new Size(46, 25);
        label20.TabIndex = 31;
        label20.Text = "vPIS";
        // 
        // label23
        // 
        label23.AutoSize = true;
        label23.Location = new Point(4, 0);
        label23.Margin = new Padding(4, 0, 4, 0);
        label23.Name = "label23";
        label23.Size = new Size(42, 25);
        label23.TabIndex = 29;
        label23.Text = "vBC";
        // 
        // txtPIS_pPIS
        // 
        txtPIS_pPIS.CharacterCasing = CharacterCasing.Upper;
        txtPIS_pPIS.Location = new Point(155, 30);
        txtPIS_pPIS.Margin = new Padding(4, 5, 4, 5);
        txtPIS_pPIS.Name = "txtPIS_pPIS";
        txtPIS_pPIS.Size = new Size(143, 31);
        txtPIS_pPIS.TabIndex = 28;
        // 
        // txtPIS_vBC
        // 
        txtPIS_vBC.CharacterCasing = CharacterCasing.Upper;
        txtPIS_vBC.Location = new Point(4, 30);
        txtPIS_vBC.Margin = new Padding(4, 5, 4, 5);
        txtPIS_vBC.Name = "txtPIS_vBC";
        txtPIS_vBC.Size = new Size(143, 31);
        txtPIS_vBC.TabIndex = 30;
        // 
        // label24
        // 
        label24.AutoSize = true;
        label24.Location = new Point(155, 0);
        label24.Margin = new Padding(4, 0, 4, 0);
        label24.Name = "label24";
        label24.Size = new Size(48, 25);
        label24.TabIndex = 27;
        label24.Text = "pPIS";
        // 
        // label26
        // 
        label26.AutoSize = true;
        label26.Location = new Point(306, 0);
        label26.Margin = new Padding(4, 0, 4, 0);
        label26.Name = "label26";
        label26.Size = new Size(82, 25);
        label26.TabIndex = 37;
        label26.Text = "qBCProd";
        // 
        // txtPIS_vAliqProd
        // 
        txtPIS_vAliqProd.CharacterCasing = CharacterCasing.Upper;
        txtPIS_vAliqProd.Location = new Point(457, 30);
        txtPIS_vAliqProd.Margin = new Padding(4, 5, 4, 5);
        txtPIS_vAliqProd.Name = "txtPIS_vAliqProd";
        txtPIS_vAliqProd.Size = new Size(143, 31);
        txtPIS_vAliqProd.TabIndex = 36;
        // 
        // txtPIS_qBCProd
        // 
        txtPIS_qBCProd.CharacterCasing = CharacterCasing.Upper;
        txtPIS_qBCProd.Location = new Point(306, 30);
        txtPIS_qBCProd.Margin = new Padding(4, 5, 4, 5);
        txtPIS_qBCProd.Name = "txtPIS_qBCProd";
        txtPIS_qBCProd.Size = new Size(143, 31);
        txtPIS_qBCProd.TabIndex = 38;
        // 
        // label27
        // 
        label27.AutoSize = true;
        label27.Location = new Point(457, 0);
        label27.Margin = new Padding(4, 0, 4, 0);
        label27.Name = "label27";
        label27.Size = new Size(90, 25);
        label27.TabIndex = 35;
        label27.Text = "vAliqProd";
        // 
        // ControlePISST
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(label26);
        Controls.Add(txtPIS_vAliqProd);
        Controls.Add(txtPIS_qBCProd);
        Controls.Add(label27);
        Controls.Add(txtPIS_vPIS);
        Controls.Add(label20);
        Controls.Add(label23);
        Controls.Add(txtPIS_pPIS);
        Controls.Add(txtPIS_vBC);
        Controls.Add(label24);
        Name = "ControlePISST";
        Size = new Size(604, 132);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox txtPIS_vPIS;
    private Label label20;
    private Label label23;
    private TextBox txtPIS_pPIS;
    private TextBox txtPIS_vBC;
    private Label label24;
    private Label label26;
    private TextBox txtPIS_vAliqProd;
    private TextBox txtPIS_qBCProd;
    private Label label27;
}
