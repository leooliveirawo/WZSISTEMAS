namespace WZSISTEMAS.Controles;

partial class ControlePIS
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
        cbbxTipoPIS = new ComboBox();
        label25 = new Label();
        ctPISAliq = new ControlePISAliq();
        ctPISNT = new ControlePISNT();
        ctPISOutr = new ControlePISOutr();
        ctPISQtde = new ControlePISQtde();
        ctPISST = new ControlePISST();
        SuspendLayout();
        // 
        // cbbxPISTipo
        // 
        cbbxTipoPIS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cbbxTipoPIS.DropDownStyle = ComboBoxStyle.DropDownList;
        cbbxTipoPIS.FormattingEnabled = true;
        cbbxTipoPIS.Location = new Point(3, 28);
        cbbxTipoPIS.Name = "cbbxPISTipo";
        cbbxTipoPIS.Size = new Size(612, 33);
        cbbxTipoPIS.TabIndex = 3;
        // 
        // label25
        // 
        label25.AutoSize = true;
        label25.Location = new Point(3, 0);
        label25.Name = "label25";
        label25.Size = new Size(102, 25);
        label25.TabIndex = 2;
        label25.Text = "Tipo de PIS";
        // 
        // ctPISAliq
        // 
        ctPISAliq.Location = new Point(3, 67);
        ctPISAliq.Name = "ctPISAliq";
        ctPISAliq.Size = new Size(604, 66);
        ctPISAliq.TabIndex = 4;
        // 
        // ctPISNT
        // 
        ctPISNT.Location = new Point(3, 67);
        ctPISNT.Name = "ctPISNT";
        ctPISNT.Size = new Size(604, 66);
        ctPISNT.TabIndex = 5;
        // 
        // ctPISOutr
        // 
        ctPISOutr.Location = new Point(3, 67);
        ctPISOutr.Name = "ctPISOutr";
        ctPISOutr.Size = new Size(604, 132);
        ctPISOutr.TabIndex = 6;
        // 
        // ctPISQtde
        // 
        ctPISQtde.Location = new Point(3, 67);
        ctPISQtde.Name = "ctPISQtde";
        ctPISQtde.Size = new Size(604, 66);
        ctPISQtde.TabIndex = 7;
        // 
        // ctPISST
        // 
        ctPISST.Location = new Point(3, 67);
        ctPISST.Name = "ctPISST";
        ctPISST.Size = new Size(604, 132);
        ctPISST.TabIndex = 8;
        // 
        // ControlePIS
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(ctPISST);
        Controls.Add(ctPISOutr);
        Controls.Add(ctPISNT);
        Controls.Add(ctPISAliq);
        Controls.Add(cbbxTipoPIS);
        Controls.Add(label25);
        Controls.Add(ctPISQtde);
        Name = "ControlePIS";
        Size = new Size(618, 338);
        Load += ControlePIS_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox cbbxTipoPIS;
    private Label label25;
    private ControlePISAliq ctPISAliq;
    private ControlePISNT ctPISNT;
    private ControlePISOutr ctPISOutr;
    private ControlePISQtde ctPISQtde;
    private ControlePISST ctPISST;
}
