namespace WZSISTEMAS.Controles;

partial class ControleCOFINSAliq
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
        label23 = new Label();
        txtCOFINS_CST = new TextBox();
        label22 = new Label();
        txtCOFINS_vCOFINS = new TextBox();
        label35 = new Label();
        txtCOFINS_pCOFINS = new TextBox();
        txtCOFINS_vBC = new TextBox();
        label36 = new Label();
        SuspendLayout();
        // 
        // label23
        // 
        label23.AutoSize = true;
        label23.Location = new Point(4, 0);
        label23.Margin = new Padding(4, 0, 4, 0);
        label23.Name = "label23";
        label23.Size = new Size(42, 25);
        label23.TabIndex = 24;
        label23.Text = "CST";
        // 
        // txtCOFINS_CST
        // 
        txtCOFINS_CST.CharacterCasing = CharacterCasing.Upper;
        txtCOFINS_CST.Location = new Point(4, 30);
        txtCOFINS_CST.Margin = new Padding(4, 5, 4, 5);
        txtCOFINS_CST.Name = "txtCOFINS_CST";
        txtCOFINS_CST.Size = new Size(143, 31);
        txtCOFINS_CST.TabIndex = 25;
        // 
        // label22
        // 
        label22.AutoSize = true;
        label22.Location = new Point(457, 0);
        label22.Margin = new Padding(4, 0, 4, 0);
        label22.Name = "label22";
        label22.Size = new Size(83, 25);
        label22.TabIndex = 22;
        label22.Text = "vCOFINS";
        // 
        // txtCOFINS_vCOFINS
        // 
        txtCOFINS_vCOFINS.CharacterCasing = CharacterCasing.Upper;
        txtCOFINS_vCOFINS.Location = new Point(457, 30);
        txtCOFINS_vCOFINS.Margin = new Padding(4, 5, 4, 5);
        txtCOFINS_vCOFINS.Name = "txtCOFINS_vCOFINS";
        txtCOFINS_vCOFINS.Size = new Size(143, 31);
        txtCOFINS_vCOFINS.TabIndex = 23;
        // 
        // label35
        // 
        label35.AutoSize = true;
        label35.Location = new Point(155, 0);
        label35.Margin = new Padding(4, 0, 4, 0);
        label35.Name = "label35";
        label35.Size = new Size(42, 25);
        label35.TabIndex = 20;
        label35.Text = "vBC";
        // 
        // txtCOFINS_pCOFINS
        // 
        txtCOFINS_pCOFINS.CharacterCasing = CharacterCasing.Upper;
        txtCOFINS_pCOFINS.Location = new Point(306, 30);
        txtCOFINS_pCOFINS.Margin = new Padding(4, 5, 4, 5);
        txtCOFINS_pCOFINS.Name = "txtCOFINS_pCOFINS";
        txtCOFINS_pCOFINS.Size = new Size(143, 31);
        txtCOFINS_pCOFINS.TabIndex = 19;
        // 
        // txtCOFINS_vBC
        // 
        txtCOFINS_vBC.CharacterCasing = CharacterCasing.Upper;
        txtCOFINS_vBC.Location = new Point(155, 30);
        txtCOFINS_vBC.Margin = new Padding(4, 5, 4, 5);
        txtCOFINS_vBC.Name = "txtCOFINS_vBC";
        txtCOFINS_vBC.Size = new Size(143, 31);
        txtCOFINS_vBC.TabIndex = 21;
        // 
        // label36
        // 
        label36.AutoSize = true;
        label36.Location = new Point(306, 0);
        label36.Margin = new Padding(4, 0, 4, 0);
        label36.Name = "label36";
        label36.Size = new Size(85, 25);
        label36.TabIndex = 18;
        label36.Text = "pCOFINS";
        // 
        // ControleCOFINSAliq
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(label23);
        Controls.Add(txtCOFINS_CST);
        Controls.Add(label22);
        Controls.Add(txtCOFINS_vCOFINS);
        Controls.Add(label35);
        Controls.Add(txtCOFINS_pCOFINS);
        Controls.Add(txtCOFINS_vBC);
        Controls.Add(label36);
        Name = "ControleCOFINSAliq";
        Size = new Size(604, 66);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label23;
    private TextBox txtCOFINS_CST;
    private Label label22;
    private TextBox txtCOFINS_vCOFINS;
    private Label label35;
    private TextBox txtCOFINS_pCOFINS;
    private TextBox txtCOFINS_vBC;
    private Label label36;
}
