namespace WZSISTEMAS.Caixas
{
    partial class FrmCaixaEntrada
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
            btnSuprir = new Button();
            txtValorSuprimento = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSuprir
            // 
            btnSuprir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSuprir.Location = new Point(676, 97);
            btnSuprir.Name = "btnSuprir";
            btnSuprir.Size = new Size(112, 34);
            btnSuprir.TabIndex = 3;
            btnSuprir.Text = "Suprir";
            btnSuprir.UseVisualStyleBackColor = true;
            btnSuprir.Click += BtnSuprir_Click;
            // 
            // txtValorSuprimento
            // 
            txtValorSuprimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValorSuprimento.Location = new Point(6, 30);
            txtValorSuprimento.Name = "txtValorSuprimento";
            txtValorSuprimento.Size = new Size(764, 31);
            txtValorSuprimento.TabIndex = 0;
            txtValorSuprimento.TextChanged += TxtValorSuprimento_TextChanged;
            txtValorSuprimento.KeyPress += TxtValorSuprimento_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtValorSuprimento);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 75);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informe o valor para suprimento do caixa (R$)";
            // 
            // FrmCaixaEntrada
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 143);
            Controls.Add(btnSuprir);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "FrmCaixaEntrada";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Suprimento - Caixa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSuprir;
        private TextBox txtValorSuprimento;
        private GroupBox groupBox1;
    }
}