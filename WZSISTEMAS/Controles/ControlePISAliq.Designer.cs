﻿namespace WZSISTEMAS.Controles;

partial class ControlePISAliq
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
        label23 = new Label();
        txtPIS_pPIS = new TextBox();
        txtPIS_vBC = new TextBox();
        label24 = new Label();
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
        // label23
        // 
        label23.AutoSize = true;
        label23.Location = new Point(155, 0);
        label23.Margin = new Padding(4, 0, 4, 0);
        label23.Name = "label23";
        label23.Size = new Size(42, 25);
        label23.TabIndex = 21;
        label23.Text = "vBC";
        // 
        // txtPIS_pPIS
        // 
        txtPIS_pPIS.CharacterCasing = CharacterCasing.Upper;
        txtPIS_pPIS.Location = new Point(306, 30);
        txtPIS_pPIS.Margin = new Padding(4, 5, 4, 5);
        txtPIS_pPIS.Name = "txtPIS_pPIS";
        txtPIS_pPIS.Size = new Size(143, 31);
        txtPIS_pPIS.TabIndex = 20;
        // 
        // txtPIS_vBC
        // 
        txtPIS_vBC.CharacterCasing = CharacterCasing.Upper;
        txtPIS_vBC.Location = new Point(155, 30);
        txtPIS_vBC.Margin = new Padding(4, 5, 4, 5);
        txtPIS_vBC.Name = "txtPIS_vBC";
        txtPIS_vBC.Size = new Size(143, 31);
        txtPIS_vBC.TabIndex = 22;
        // 
        // label24
        // 
        label24.AutoSize = true;
        label24.Location = new Point(306, 0);
        label24.Margin = new Padding(4, 0, 4, 0);
        label24.Name = "label24";
        label24.Size = new Size(48, 25);
        label24.TabIndex = 19;
        label24.Text = "pPIS";
        // 
        // ControlePISAliq
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(txtPIS_CST);
        Controls.Add(label21);
        Controls.Add(txtPIS_vPIS);
        Controls.Add(label20);
        Controls.Add(label23);
        Controls.Add(txtPIS_pPIS);
        Controls.Add(txtPIS_vBC);
        Controls.Add(label24);
        Name = "ControlePISAliq";
        Size = new Size(604, 66);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtPIS_CST;
    private Label label21;
    private TextBox txtPIS_vPIS;
    private Label label20;
    private Label label23;
    private TextBox txtPIS_pPIS;
    private TextBox txtPIS_vBC;
    private Label label24;
}
