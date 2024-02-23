namespace WZSISTEMAS.Consultas
{
    partial class FrmConsultaAvancadaClientes
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
            txtFiltrarPorNomeCompleto_RazaoSocial = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvCadastros = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnTipo = new DataGridViewTextBoxColumn();
            clnNomeCompleto_RazaoSocial = new DataGridViewTextBoxColumn();
            clnCPF_CNPJ = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCadastros).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtFiltrarPorNomeCompleto_RazaoSocial);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 65);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros para consulta";
            // 
            // txtFiltrarPorNomeCompleto_RazaoSocial
            // 
            txtFiltrarPorNomeCompleto_RazaoSocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFiltrarPorNomeCompleto_RazaoSocial.CharacterCasing = CharacterCasing.Upper;
            txtFiltrarPorNomeCompleto_RazaoSocial.Location = new Point(6, 37);
            txtFiltrarPorNomeCompleto_RazaoSocial.Name = "txtFiltrarPorNomeCompleto_RazaoSocial";
            txtFiltrarPorNomeCompleto_RazaoSocial.Size = new Size(749, 23);
            txtFiltrarPorNomeCompleto_RazaoSocial.TabIndex = 1;
            txtFiltrarPorNomeCompleto_RazaoSocial.KeyPress += TxtFiltrarPorNomeCompleto_RazaoSocial_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome completo/Razão social";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dgvCadastros);
            groupBox2.Location = new Point(12, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(760, 466);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cadastros";
            // 
            // dgvCadastros
            // 
            dgvCadastros.AllowUserToAddRows = false;
            dgvCadastros.AllowUserToDeleteRows = false;
            dgvCadastros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCadastros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvCadastros.ColumnHeadersHeight = 65;
            dgvCadastros.Columns.AddRange(new DataGridViewColumn[] { clnId, clnTipo, clnNomeCompleto_RazaoSocial, clnCPF_CNPJ });
            dgvCadastros.Dock = DockStyle.Fill;
            dgvCadastros.Location = new Point(3, 19);
            dgvCadastros.MultiSelect = false;
            dgvCadastros.Name = "dgvCadastros";
            dgvCadastros.ReadOnly = true;
            dgvCadastros.RowHeadersVisible = false;
            dgvCadastros.RowHeadersWidth = 62;
            dgvCadastros.RowTemplate.Height = 32;
            dgvCadastros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCadastros.Size = new Size(754, 444);
            dgvCadastros.TabIndex = 0;
            dgvCadastros.CellDoubleClick += DgvCadastros_CellDoubleClick;
            // 
            // clnId
            // 
            clnId.HeaderText = "Id";
            clnId.MinimumWidth = 8;
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnTipo
            // 
            clnTipo.HeaderText = "Tipo";
            clnTipo.MinimumWidth = 8;
            clnTipo.Name = "clnTipo";
            clnTipo.ReadOnly = true;
            // 
            // clnNomeCompleto_RazaoSocial
            // 
            clnNomeCompleto_RazaoSocial.HeaderText = "Nome completo/Razão social";
            clnNomeCompleto_RazaoSocial.MinimumWidth = 8;
            clnNomeCompleto_RazaoSocial.Name = "clnNomeCompleto_RazaoSocial";
            clnNomeCompleto_RazaoSocial.ReadOnly = true;
            // 
            // clnCPF_CNPJ
            // 
            clnCPF_CNPJ.HeaderText = "CPF/CNPJ";
            clnCPF_CNPJ.MinimumWidth = 8;
            clnCPF_CNPJ.Name = "clnCPF_CNPJ";
            clnCPF_CNPJ.ReadOnly = true;
            // 
            // FrmConsultaAvancadaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "FrmConsultaAvancadaClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Consulta avançada de cliente";
            Load += FrmConsultaAvancadaClientes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCadastros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvCadastros;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnTipo;
        private DataGridViewTextBoxColumn clnNomeCompleto_RazaoSocial;
        private DataGridViewTextBoxColumn clnCPF_CNPJ;
        private TextBox txtFiltrarPorNomeCompleto_RazaoSocial;
        private Label label1;
    }
}