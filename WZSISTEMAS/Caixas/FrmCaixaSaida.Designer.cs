namespace WZSISTEMAS.Caixas
{
    partial class FrmCaixaSaida
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
            btnRetirar = new Button();
            txtValorRetirada = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lbValorDisponivelRetirada = new Label();
            cbbxTipoRetirada = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnRetirar
            // 
            btnRetirar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRetirar.Location = new Point(676, 257);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(112, 34);
            btnRetirar.TabIndex = 3;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += BtnRetirar_Click;
            // 
            // txtValorRetirada
            // 
            txtValorRetirada.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValorRetirada.Location = new Point(6, 30);
            txtValorRetirada.Name = "txtValorRetirada";
            txtValorRetirada.Size = new Size(764, 31);
            txtValorRetirada.TabIndex = 0;
            txtValorRetirada.TextChanged += TxtValorRetirada_TextChanged;
            txtValorRetirada.KeyPress += TxtValorRetirada_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtValorRetirada);
            groupBox1.Location = new Point(12, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 75);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informe o valor para retirada";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(cbbxTipoRetirada);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 150);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informe o tipo de retirada";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(lbValorDisponivelRetirada);
            groupBox3.Location = new Point(6, 69);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(764, 75);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Valor disponível para retirada";
            // 
            // lbValorDisponivelRetirada
            // 
            lbValorDisponivelRetirada.Dock = DockStyle.Fill;
            lbValorDisponivelRetirada.Location = new Point(3, 27);
            lbValorDisponivelRetirada.Name = "lbValorDisponivelRetirada";
            lbValorDisponivelRetirada.Size = new Size(758, 45);
            lbValorDisponivelRetirada.TabIndex = 0;
            lbValorDisponivelRetirada.Text = "R$ 0,00";
            lbValorDisponivelRetirada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbxTipoRetirada
            // 
            cbbxTipoRetirada.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbxTipoRetirada.FormattingEnabled = true;
            cbbxTipoRetirada.Location = new Point(6, 30);
            cbbxTipoRetirada.Name = "cbbxTipoRetirada";
            cbbxTipoRetirada.Size = new Size(339, 33);
            cbbxTipoRetirada.TabIndex = 0;
            cbbxTipoRetirada.SelectedIndexChanged += CbbxTipoRetirada_SelectedIndexChanged;
            // 
            // FrmCaixaSaida
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 303);
            Controls.Add(groupBox2);
            Controls.Add(btnRetirar);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "FrmCaixaSaida";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Retirada";
            Load += FrmCaixaRetirada_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnRetirar;
        private TextBox txtValorRetirada;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cbbxTipoRetirada;
        private GroupBox groupBox3;
        private Label lbValorDisponivelRetirada;
    }
}