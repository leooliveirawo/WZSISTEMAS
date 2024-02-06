namespace WZSISTEMAS.FrenteCaixa
{
    partial class FrmFrenteCaixaEmAberto
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
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new DataGridViewCellStyle();
            var dataGridViewCellStyle3 = new DataGridViewCellStyle();
            var dataGridViewCellStyle4 = new DataGridViewCellStyle();
            var dataGridViewCellStyle5 = new DataGridViewCellStyle();
            var dataGridViewCellStyle6 = new DataGridViewCellStyle();
            gbxItemItens = new GroupBox();
            panel1 = new Panel();
            dgvItemItens = new DataGridView();
            clnVendaItemNumero = new DataGridViewTextBoxColumn();
            clnVendaItemCodBarrasCodRef = new DataGridViewTextBoxColumn();
            clnVendaItemDescricao = new DataGridViewTextBoxColumn();
            clnVendaItemUnd = new DataGridViewTextBoxColumn();
            clnVendaItemPrecoUnitario = new DataGridViewTextBoxColumn();
            clnVendaItemQntd = new DataGridViewTextBoxColumn();
            clnVendaItemTotal = new DataGridViewTextBoxColumn();
            gbxItens = new GroupBox();
            panel2 = new Panel();
            dgvItens = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            dtpFiltrarPorDataDe = new DateTimePicker();
            groupBox3 = new GroupBox();
            dtpFiltrarPorDataAte = new DateTimePicker();
            groupBox5 = new GroupBox();
            btnFiltrarPorData = new Button();
            btnSelecionar = new Button();
            gbxTerminalNumero = new GroupBox();
            lbCaixaNumero = new Label();
            clnVendaId = new DataGridViewTextBoxColumn();
            clnVendaNumero = new DataGridViewTextBoxColumn();
            clnOperadorFuncionario = new DataGridViewTextBoxColumn();
            clnVendaTotal = new DataGridViewTextBoxColumn();
            clnVendaVolume = new DataGridViewTextBoxColumn();
            clnVendaRealizaEm = new DataGridViewTextBoxColumn();
            gbxItemItens.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemItens).BeginInit();
            gbxItens.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            gbxTerminalNumero.SuspendLayout();
            SuspendLayout();
            // 
            // gbxItemItens
            // 
            gbxItemItens.Controls.Add(panel1);
            gbxItemItens.Dock = DockStyle.Fill;
            gbxItemItens.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            gbxItemItens.ForeColor = Color.WhiteSmoke;
            gbxItemItens.Location = new Point(3, 360);
            gbxItemItens.Name = "gbxItemItens";
            gbxItemItens.Size = new Size(1090, 352);
            gbxItemItens.TabIndex = 4;
            gbxItemItens.TabStop = false;
            gbxItemItens.Text = "Itens da venda";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvItemItens);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(3, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 270);
            panel1.TabIndex = 1;
            // 
            // dgvItemItens
            // 
            dgvItemItens.AllowUserToAddRows = false;
            dgvItemItens.AllowUserToDeleteRows = false;
            dgvItemItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItemItens.BackgroundColor = Color.Silver;
            dgvItemItens.BorderStyle = BorderStyle.None;
            dgvItemItens.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItemItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvItemItens.ColumnHeadersHeight = 60;
            dgvItemItens.Columns.AddRange(new DataGridViewColumn[] { clnVendaItemNumero, clnVendaItemCodBarrasCodRef, clnVendaItemDescricao, clnVendaItemUnd, clnVendaItemPrecoUnitario, clnVendaItemQntd, clnVendaItemTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvItemItens.DefaultCellStyle = dataGridViewCellStyle2;
            dgvItemItens.Dock = DockStyle.Fill;
            dgvItemItens.EnableHeadersVisualStyles = false;
            dgvItemItens.GridColor = Color.Silver;
            dgvItemItens.Location = new Point(0, 0);
            dgvItemItens.MultiSelect = false;
            dgvItemItens.Name = "dgvItemItens";
            dgvItemItens.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvItemItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvItemItens.RowHeadersVisible = false;
            dgvItemItens.RowHeadersWidth = 62;
            dgvItemItens.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvItemItens.RowTemplate.Height = 45;
            dgvItemItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItemItens.Size = new Size(1084, 270);
            dgvItemItens.TabIndex = 0;
            // 
            // clnVendaItemNumero
            // 
            clnVendaItemNumero.HeaderText = "Nº";
            clnVendaItemNumero.MinimumWidth = 8;
            clnVendaItemNumero.Name = "clnVendaItemNumero";
            clnVendaItemNumero.ReadOnly = true;
            // 
            // clnVendaItemCodBarrasCodRef
            // 
            clnVendaItemCodBarrasCodRef.HeaderText = "Cód.Barras (Cód.Ref)";
            clnVendaItemCodBarrasCodRef.MinimumWidth = 8;
            clnVendaItemCodBarrasCodRef.Name = "clnVendaItemCodBarrasCodRef";
            clnVendaItemCodBarrasCodRef.ReadOnly = true;
            // 
            // clnVendaItemDescricao
            // 
            clnVendaItemDescricao.HeaderText = "Descrição";
            clnVendaItemDescricao.MinimumWidth = 8;
            clnVendaItemDescricao.Name = "clnVendaItemDescricao";
            clnVendaItemDescricao.ReadOnly = true;
            // 
            // clnVendaItemUnd
            // 
            clnVendaItemUnd.HeaderText = "Und";
            clnVendaItemUnd.MinimumWidth = 8;
            clnVendaItemUnd.Name = "clnVendaItemUnd";
            clnVendaItemUnd.ReadOnly = true;
            // 
            // clnVendaItemPrecoUnitario
            // 
            clnVendaItemPrecoUnitario.HeaderText = "Unit (R$)";
            clnVendaItemPrecoUnitario.MinimumWidth = 8;
            clnVendaItemPrecoUnitario.Name = "clnVendaItemPrecoUnitario";
            clnVendaItemPrecoUnitario.ReadOnly = true;
            // 
            // clnVendaItemQntd
            // 
            clnVendaItemQntd.HeaderText = "Qntd";
            clnVendaItemQntd.MinimumWidth = 8;
            clnVendaItemQntd.Name = "clnVendaItemQntd";
            clnVendaItemQntd.ReadOnly = true;
            // 
            // clnVendaItemTotal
            // 
            clnVendaItemTotal.HeaderText = "Total (R$)";
            clnVendaItemTotal.MinimumWidth = 8;
            clnVendaItemTotal.Name = "clnVendaItemTotal";
            clnVendaItemTotal.ReadOnly = true;
            // 
            // gbxItens
            // 
            gbxItens.Controls.Add(panel2);
            gbxItens.Dock = DockStyle.Fill;
            gbxItens.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            gbxItens.ForeColor = Color.WhiteSmoke;
            gbxItens.Location = new Point(3, 3);
            gbxItens.Name = "gbxItens";
            gbxItens.Size = new Size(1090, 351);
            gbxItens.TabIndex = 5;
            gbxItens.TabStop = false;
            gbxItens.Text = "Vendas";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvItens);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 9F);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(3, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 269);
            panel2.TabIndex = 1;
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.AllowUserToDeleteRows = false;
            dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItens.BackgroundColor = Color.Silver;
            dgvItens.BorderStyle = BorderStyle.None;
            dgvItens.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvItens.ColumnHeadersHeight = 60;
            dgvItens.Columns.AddRange(new DataGridViewColumn[] { clnVendaId, clnVendaNumero, clnOperadorFuncionario, clnVendaTotal, clnVendaVolume, clnVendaRealizaEm });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvItens.DefaultCellStyle = dataGridViewCellStyle5;
            dgvItens.Dock = DockStyle.Fill;
            dgvItens.EnableHeadersVisualStyles = false;
            dgvItens.GridColor = Color.Silver;
            dgvItens.Location = new Point(0, 0);
            dgvItens.MultiSelect = false;
            dgvItens.Name = "dgvItens";
            dgvItens.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvItens.RowHeadersVisible = false;
            dgvItens.RowHeadersWidth = 62;
            dgvItens.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvItens.RowTemplate.Height = 45;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.Size = new Size(1084, 269);
            dgvItens.TabIndex = 0;
            dgvItens.CellDoubleClick += DgvItens_CellDoubleClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(gbxItens, 0, 0);
            tableLayoutPanel1.Controls.Add(gbxItemItens, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 168);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1096, 715);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpFiltrarPorDataDe);
            groupBox2.Font = new Font("Segoe UI", 15F);
            groupBox2.ForeColor = Color.WhiteSmoke;
            groupBox2.Location = new Point(6, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(154, 90);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "De";
            // 
            // dtpFiltrarPorDataDe
            // 
            dtpFiltrarPorDataDe.Font = new Font("Segoe UI", 9F);
            dtpFiltrarPorDataDe.Format = DateTimePickerFormat.Short;
            dtpFiltrarPorDataDe.Location = new Point(6, 46);
            dtpFiltrarPorDataDe.Name = "dtpFiltrarPorDataDe";
            dtpFiltrarPorDataDe.ShowUpDown = true;
            dtpFiltrarPorDataDe.Size = new Size(138, 31);
            dtpFiltrarPorDataDe.TabIndex = 0;
            dtpFiltrarPorDataDe.KeyPress += DtpFiltrarPorData_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpFiltrarPorDataAte);
            groupBox3.Font = new Font("Segoe UI", 15F);
            groupBox3.ForeColor = Color.WhiteSmoke;
            groupBox3.Location = new Point(166, 46);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(154, 90);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Até";
            // 
            // dtpFiltrarPorDataAte
            // 
            dtpFiltrarPorDataAte.Font = new Font("Segoe UI", 9F);
            dtpFiltrarPorDataAte.Format = DateTimePickerFormat.Short;
            dtpFiltrarPorDataAte.Location = new Point(6, 46);
            dtpFiltrarPorDataAte.Name = "dtpFiltrarPorDataAte";
            dtpFiltrarPorDataAte.ShowUpDown = true;
            dtpFiltrarPorDataAte.Size = new Size(138, 31);
            dtpFiltrarPorDataAte.TabIndex = 0;
            dtpFiltrarPorDataAte.KeyPress += DtpFiltrarPorData_KeyPress;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnFiltrarPorData);
            groupBox5.Controls.Add(groupBox2);
            groupBox5.Controls.Add(groupBox3);
            groupBox5.Font = new Font("Segoe UI", 15F);
            groupBox5.ForeColor = Color.WhiteSmoke;
            groupBox5.Location = new Point(12, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(446, 150);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Filtrar por data";
            // 
            // btnFiltrarPorData
            // 
            btnFiltrarPorData.Font = new Font("Segoe UI", 9F);
            btnFiltrarPorData.ForeColor = Color.Black;
            btnFiltrarPorData.Location = new Point(326, 89);
            btnFiltrarPorData.Name = "btnFiltrarPorData";
            btnFiltrarPorData.Size = new Size(112, 34);
            btnFiltrarPorData.TabIndex = 5;
            btnFiltrarPorData.Text = "Filtrar";
            btnFiltrarPorData.UseVisualStyleBackColor = true;
            btnFiltrarPorData.Click += BtnFiltrarPorData_Click;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSelecionar.Location = new Point(996, 889);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(112, 34);
            btnSelecionar.TabIndex = 5;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += BtnSelecionar_Click;
            // 
            // gbxTerminalNumero
            // 
            gbxTerminalNumero.Controls.Add(lbCaixaNumero);
            gbxTerminalNumero.Font = new Font("Segoe UI", 15F);
            gbxTerminalNumero.ForeColor = Color.WhiteSmoke;
            gbxTerminalNumero.Location = new Point(464, 12);
            gbxTerminalNumero.Name = "gbxTerminalNumero";
            gbxTerminalNumero.Size = new Size(644, 105);
            gbxTerminalNumero.TabIndex = 6;
            gbxTerminalNumero.TabStop = false;
            gbxTerminalNumero.Text = "Nº do Terminal";
            // 
            // lbCaixaNumero
            // 
            lbCaixaNumero.Dock = DockStyle.Fill;
            lbCaixaNumero.Location = new Point(3, 43);
            lbCaixaNumero.Name = "lbCaixaNumero";
            lbCaixaNumero.Size = new Size(638, 59);
            lbCaixaNumero.TabIndex = 1;
            lbCaixaNumero.Text = "Nº do Caixa";
            lbCaixaNumero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clnVendaId
            // 
            clnVendaId.HeaderText = "Id";
            clnVendaId.MinimumWidth = 8;
            clnVendaId.Name = "clnVendaId";
            clnVendaId.ReadOnly = true;
            clnVendaId.Visible = false;
            // 
            // clnVendaNumero
            // 
            clnVendaNumero.HeaderText = "Nº";
            clnVendaNumero.MinimumWidth = 8;
            clnVendaNumero.Name = "clnVendaNumero";
            clnVendaNumero.ReadOnly = true;
            // 
            // clnOperadorFuncionario
            // 
            clnOperadorFuncionario.HeaderText = "Operador";
            clnOperadorFuncionario.MinimumWidth = 8;
            clnOperadorFuncionario.Name = "clnOperadorFuncionario";
            clnOperadorFuncionario.ReadOnly = true;
            // 
            // clnVendaTotal
            // 
            clnVendaTotal.HeaderText = "Total (R$)";
            clnVendaTotal.MinimumWidth = 8;
            clnVendaTotal.Name = "clnVendaTotal";
            clnVendaTotal.ReadOnly = true;
            // 
            // clnVendaVolume
            // 
            clnVendaVolume.HeaderText = "Volume";
            clnVendaVolume.MinimumWidth = 8;
            clnVendaVolume.Name = "clnVendaVolume";
            clnVendaVolume.ReadOnly = true;
            // 
            // clnVendaRealizaEm
            // 
            clnVendaRealizaEm.HeaderText = "Aberta em";
            clnVendaRealizaEm.MinimumWidth = 8;
            clnVendaRealizaEm.Name = "clnVendaRealizaEm";
            clnVendaRealizaEm.ReadOnly = true;
            // 
            // FrmFrenteCaixaEmAberto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1120, 935);
            Controls.Add(gbxTerminalNumero);
            Controls.Add(btnSelecionar);
            Controls.Add(groupBox5);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Name = "FrmFrenteCaixaEmAberto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vendas em espera";
            WindowState = FormWindowState.Maximized;
            Load += FrmFrenteCaixaEmEspera_Load;
            gbxItemItens.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItemItens).EndInit();
            gbxItens.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            gbxTerminalNumero.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxItemItens;
        private Panel panel1;
        private DataGridView dgvItemItens;
        private GroupBox gbxItens;
        private Panel panel2;
        private DataGridView dgvItens;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private DateTimePicker dtpFiltrarPorDataDe;
        private GroupBox groupBox3;
        private DateTimePicker dtpFiltrarPorDataAte;
        private GroupBox groupBox5;
        private Button btnFiltrarPorData;
        private Button btnSelecionar;
        private DataGridViewTextBoxColumn clnVendaItemNumero;
        private DataGridViewTextBoxColumn clnVendaItemCodBarrasCodRef;
        private DataGridViewTextBoxColumn clnVendaItemDescricao;
        private DataGridViewTextBoxColumn clnVendaItemUnd;
        private DataGridViewTextBoxColumn clnVendaItemPrecoUnitario;
        private DataGridViewTextBoxColumn clnVendaItemQntd;
        private DataGridViewTextBoxColumn clnVendaItemTotal;
        private GroupBox gbxTerminalNumero;
        private Label lbCaixaNumero;
        private DataGridViewTextBoxColumn clnVendaId;
        private DataGridViewTextBoxColumn clnVendaNumero;
        private DataGridViewTextBoxColumn clnOperadorFuncionario;
        private DataGridViewTextBoxColumn clnVendaTotal;
        private DataGridViewTextBoxColumn clnVendaVolume;
        private DataGridViewTextBoxColumn clnVendaRealizaEm;
    }
}