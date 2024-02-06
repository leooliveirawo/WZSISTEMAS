namespace WZSISTEMAS.Controles
{
    partial class ControleCOFINSNT
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
            SuspendLayout();
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(4, 0);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(42, 25);
            label23.TabIndex = 26;
            label23.Text = "CST";
            // 
            // txtCOFINS_CST
            // 
            txtCOFINS_CST.CharacterCasing = CharacterCasing.Upper;
            txtCOFINS_CST.Location = new Point(4, 30);
            txtCOFINS_CST.Margin = new Padding(4, 5, 4, 5);
            txtCOFINS_CST.Name = "txtCOFINS_CST";
            txtCOFINS_CST.Size = new Size(143, 31);
            txtCOFINS_CST.TabIndex = 27;
            // 
            // ControleCOFINSST
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label23);
            Controls.Add(txtCOFINS_CST);
            Name = "ControleCOFINSST";
            Size = new Size(604, 66);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label23;
        private TextBox txtCOFINS_CST;
    }
}
