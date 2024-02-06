namespace WZSISTEMAS.Consultas
{
    partial class FrmConsultaAvancadaItens
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
            txtFiltrarPorDescricao = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvCadastros = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodBarrasCodRef = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnPreco = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCadastros).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtFiltrarPorDescricao);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1086, 167);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros para consulta";
            // 
            // txtFiltrarPorDescricao
            // 
            txtFiltrarPorDescricao.CharacterCasing = CharacterCasing.Upper;
            txtFiltrarPorDescricao.Location = new Point(9, 62);
            txtFiltrarPorDescricao.Margin = new Padding(4, 5, 4, 5);
            txtFiltrarPorDescricao.Name = "txtFiltrarPorDescricao";
            txtFiltrarPorDescricao.Size = new Size(803, 31);
            txtFiltrarPorDescricao.TabIndex = 1;
            txtFiltrarPorDescricao.KeyPress += TxtFiltrarPorDescricao_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "Descrição";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dgvCadastros);
            groupBox2.Location = new Point(17, 197);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1086, 718);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cadastros";
            // 
            // dgvCadastros
            // 
            dgvCadastros.AllowUserToAddRows = false;
            dgvCadastros.AllowUserToDeleteRows = false;
            dgvCadastros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCadastros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvCadastros.ColumnHeadersHeight = 45;
            dgvCadastros.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodBarrasCodRef, clnDescricao, clnPreco });
            dgvCadastros.Dock = DockStyle.Fill;
            dgvCadastros.Location = new Point(4, 29);
            dgvCadastros.Margin = new Padding(4, 5, 4, 5);
            dgvCadastros.MultiSelect = false;
            dgvCadastros.Name = "dgvCadastros";
            dgvCadastros.ReadOnly = true;
            dgvCadastros.RowHeadersVisible = false;
            dgvCadastros.RowHeadersWidth = 62;
            dgvCadastros.RowTemplate.Height = 32;
            dgvCadastros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCadastros.Size = new Size(1078, 684);
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
            // clnCodBarrasCodRef
            // 
            clnCodBarrasCodRef.HeaderText = "Cód.Barras (Cod.Ref)";
            clnCodBarrasCodRef.MinimumWidth = 8;
            clnCodBarrasCodRef.Name = "clnCodBarrasCodRef";
            clnCodBarrasCodRef.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.MinimumWidth = 8;
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            // 
            // clnPreco
            // 
            clnPreco.HeaderText = "Preço (R$)";
            clnPreco.MinimumWidth = 8;
            clnPreco.Name = "clnPreco";
            clnPreco.ReadOnly = true;
            // 
            // FrmConsultaAvancadaProdutos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 935);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            DoubleBuffered = true;
            Name = "FrmConsultaAvancadaProdutos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Consulta avançada de produto";
            Load += FrmConsultaAvancadaProdutos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCadastros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtFiltrarPorDescricao;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvCadastros;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBarrasCodRef;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnPreco;
    }
}