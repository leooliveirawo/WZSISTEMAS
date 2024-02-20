namespace WZSISTEMAS.Utiliarios
{
    partial class FrmConfigurarTerminal
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
            btnVoltar = new Button();
            gbxDados = new GroupBox();
            cbbxEmpresa = new ComboBox();
            label3 = new Label();
            txtIdentificacao = new TextBox();
            label2 = new Label();
            btnImportar = new Button();
            gbxDados.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoltar.Location = new Point(1000, 223);
            btnVoltar.Margin = new Padding(4, 5, 4, 5);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(107, 38);
            btnVoltar.TabIndex = 16;
            btnVoltar.Text = "Salvar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += BtnSalvar_Click;
            // 
            // gbxDados
            // 
            gbxDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxDados.Controls.Add(btnImportar);
            gbxDados.Controls.Add(cbbxEmpresa);
            gbxDados.Controls.Add(label3);
            gbxDados.Controls.Add(txtIdentificacao);
            gbxDados.Controls.Add(label2);
            gbxDados.Location = new Point(17, 14);
            gbxDados.Margin = new Padding(4, 5, 4, 5);
            gbxDados.Name = "gbxDados";
            gbxDados.Padding = new Padding(4, 5, 4, 5);
            gbxDados.Size = new Size(1086, 199);
            gbxDados.TabIndex = 17;
            gbxDados.TabStop = false;
            gbxDados.Text = "Dados do terminal";
            // 
            // cbbxEmpresa
            // 
            cbbxEmpresa.FormattingEnabled = true;
            cbbxEmpresa.Location = new Point(7, 135);
            cbbxEmpresa.Name = "cbbxEmpresa";
            cbbxEmpresa.Size = new Size(583, 33);
            cbbxEmpresa.TabIndex = 5;
            cbbxEmpresa.KeyPress += CbbxEmpresa_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 107);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 4;
            label3.Text = "Empresa";
            // 
            // txtIdentificacao
            // 
            txtIdentificacao.CharacterCasing = CharacterCasing.Upper;
            txtIdentificacao.Location = new Point(8, 64);
            txtIdentificacao.Margin = new Padding(4, 5, 4, 5);
            txtIdentificacao.Name = "txtIdentificacao";
            txtIdentificacao.ReadOnly = true;
            txtIdentificacao.Size = new Size(581, 31);
            txtIdentificacao.TabIndex = 3;
            txtIdentificacao.KeyPress += TxtIdentificacao_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 34);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 2;
            label2.Text = "Identificação";
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(611, 60);
            btnImportar.Margin = new Padding(4, 5, 4, 5);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(107, 38);
            btnImportar.TabIndex = 17;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += BtnImportar_Click;
            // 
            // FrmConfigurarTerminal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 275);
            Controls.Add(gbxDados);
            Controls.Add(btnVoltar);
            DoubleBuffered = true;
            Name = "FrmConfigurarTerminal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configurar o terminal";
            Load += FrmTerminal_Load;
            gbxDados.ResumeLayout(false);
            gbxDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
        private GroupBox gbxDados;
        private ComboBox cbbxEmpresa;
        private Label label3;
        private TextBox txtIdentificacao;
        private Label label2;
        private Button btnImportar;
    }
}