namespace WZSISTEMAS.Caixas
{
    partial class FrmCaixaAbertura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtSaldoInicial = new TextBox();
            btnAbrir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSaldoInicial);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 75);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informe o saldo inicial";
            // 
            // txtSaldoInicial
            // 
            txtSaldoInicial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSaldoInicial.Location = new Point(6, 30);
            txtSaldoInicial.Name = "txtSaldoInicial";
            txtSaldoInicial.Size = new Size(764, 31);
            txtSaldoInicial.TabIndex = 0;
            txtSaldoInicial.TextChanged += TxtSaldoInicial_TextChanged;
            txtSaldoInicial.KeyPress += TxtSaldoInicial_KeyPress;
            // 
            // btnAbrir
            // 
            btnAbrir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAbrir.Location = new Point(676, 97);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(112, 34);
            btnAbrir.TabIndex = 1;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += BtnAbrir_Click;
            // 
            // FrmCaixaAbertura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 143);
            Controls.Add(btnAbrir);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCaixaAbertura";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Abrir caixa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSaldoInicial;
        private Button btnAbrir;
    }
}