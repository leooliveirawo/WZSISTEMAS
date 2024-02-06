namespace WZSISTEMAS.Controles;

partial class ControlePISNT
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
        // ControlePISNT
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(txtPIS_CST);
        Controls.Add(label21);
        Name = "ControlePISNT";
        Size = new Size(604, 66);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtPIS_CST;
    private Label label21;
}
