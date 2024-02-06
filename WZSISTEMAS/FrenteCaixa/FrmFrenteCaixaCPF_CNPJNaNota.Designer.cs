namespace WZSISTEMAS.FrenteCaixa
{
    partial class FrmFrenteCaixaCPF_CNPJNaNota
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtCPF_CNPJ = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 170);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(534, 136);
            label3.Name = "label3";
            label3.Size = new Size(181, 25);
            label3.TabIndex = 10;
            label3.Text = "NÃO INFORMAR (F4)";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(721, 136);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 9;
            label2.Text = "VOLTAR (ESC)";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(426, 136);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 8;
            label1.Text = "OK (ENTER)";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtCPF_CNPJ);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(829, 102);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "CPF/CNPJ na nota";
            // 
            // txtCPF_CNPJ
            // 
            txtCPF_CNPJ.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCPF_CNPJ.Location = new Point(6, 30);
            txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            txtCPF_CNPJ.Size = new Size(817, 31);
            txtCPF_CNPJ.TabIndex = 0;
            // 
            // FrmFrenteCaixaCPF_CNPJNaNota
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(873, 190);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FrmFrenteCaixaCPF_CNPJNaNota";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Informar CPF/CNPJ";
            Load += FrmFrenteCaixaCPF_CNPJNaNota_Load;
            KeyPress += FrmFrenteCaixaCPF_CNPJNaNota_KeyPress;
            KeyUp += FrmFrenteCaixaCPF_CNPJNaNota_KeyUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtCPF_CNPJ;
    }
}