namespace WZSISTEMAS.Controles;

partial class ControleCOFINS
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
        cbbxTipoCOFINS = new ComboBox();
        label37 = new Label();
        ctCOFINSAliq = new ControleCOFINSAliq();
        ctCOFINSQtde = new ControleCOFINSQtde();
        ctCOFINSNT = new ControleCOFINSNT();
        ctCOFINSOutr = new ControleCOFINSOutr();
        ctCOFINSST = new ControleCOFINSST();
        SuspendLayout();
        // 
        // cbbxTipoCOFINS
        // 
        cbbxTipoCOFINS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cbbxTipoCOFINS.DropDownStyle = ComboBoxStyle.DropDownList;
        cbbxTipoCOFINS.FormattingEnabled = true;
        cbbxTipoCOFINS.Location = new Point(3, 28);
        cbbxTipoCOFINS.Name = "cbbxTipoCOFINS";
        cbbxTipoCOFINS.Size = new Size(685, 33);
        cbbxTipoCOFINS.TabIndex = 3;
        cbbxTipoCOFINS.SelectedIndexChanged += CbbxTipoCOFINS_SelectedIndexChanged;
        // 
        // label37
        // 
        label37.AutoSize = true;
        label37.Location = new Point(3, 0);
        label37.Name = "label37";
        label37.Size = new Size(139, 25);
        label37.TabIndex = 2;
        label37.Text = "Tipo de COFINS";
        // 
        // ctCOFINSAliq
        // 
        ctCOFINSAliq.Location = new Point(3, 67);
        ctCOFINSAliq.Name = "ctCOFINSAliq";
        ctCOFINSAliq.Size = new Size(604, 66);
        ctCOFINSAliq.TabIndex = 4;
        // 
        // ctCOFINSQtde
        // 
        ctCOFINSQtde.Location = new Point(3, 67);
        ctCOFINSQtde.Name = "ctCOFINSQtde";
        ctCOFINSQtde.Size = new Size(604, 66);
        ctCOFINSQtde.TabIndex = 5;
        // 
        // ctCOFINSNT
        // 
        ctCOFINSNT.Location = new Point(3, 67);
        ctCOFINSNT.Name = "ctCOFINSNT";
        ctCOFINSNT.Size = new Size(604, 66);
        ctCOFINSNT.TabIndex = 6;
        // 
        // ctCOFINSOutr
        // 
        ctCOFINSOutr.Location = new Point(3, 67);
        ctCOFINSOutr.Name = "ctCOFINSOutr";
        ctCOFINSOutr.Size = new Size(604, 132);
        ctCOFINSOutr.TabIndex = 7;
        // 
        // controlecofinsst1
        // 
        ctCOFINSST.Location = new Point(3, 67);
        ctCOFINSST.Name = "controlecofinsst1";
        ctCOFINSST.Size = new Size(604, 132);
        ctCOFINSST.TabIndex = 8;
        // 
        // ControleCOFINS
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(ctCOFINSST);
        Controls.Add(ctCOFINSOutr);
        Controls.Add(ctCOFINSNT);
        Controls.Add(ctCOFINSQtde);
        Controls.Add(ctCOFINSAliq);
        Controls.Add(cbbxTipoCOFINS);
        Controls.Add(label37);
        Name = "ControleCOFINS";
        Size = new Size(691, 378);
        Load += ControleCOFINS_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox cbbxTipoCOFINS;
    private Label label37;
    private ControleCOFINSAliq ctCOFINSAliq;
    private ControleCOFINSQtde ctCOFINSQtde;
    private ControleCOFINSNT ctCOFINSNT;
    private ControleCOFINSOutr ctCOFINSOutr;
    private ControleCOFINSST ctCOFINSST;
}
