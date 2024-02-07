namespace WZSISTEMAS.Pedidos
{
    partial class FrmPedidoEmAberto
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
            var dataGridViewCellStyle7 = new DataGridViewCellStyle();
            var dataGridViewCellStyle8 = new DataGridViewCellStyle();
            var dataGridViewCellStyle9 = new DataGridViewCellStyle();
            var dataGridViewCellStyle10 = new DataGridViewCellStyle();
            var dataGridViewCellStyle11 = new DataGridViewCellStyle();
            var dataGridViewCellStyle12 = new DataGridViewCellStyle();
            groupBox4 = new GroupBox();
            panel1 = new Panel();
            dgvPedidoItens = new DataGridView();
            clnVendaItemNumero = new DataGridViewTextBoxColumn();
            clnVendaItemCodBarrasCodRef = new DataGridViewTextBoxColumn();
            clnVendaItemDescricao = new DataGridViewTextBoxColumn();
            clnVendaItemUnd = new DataGridViewTextBoxColumn();
            clnVendaItemPrecoUnitario = new DataGridViewTextBoxColumn();
            clnVendaItemQntd = new DataGridViewTextBoxColumn();
            clnVendaItemTotal = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            dgvPedidos = new DataGridView();
            clnVendaId = new DataGridViewTextBoxColumn();
            clnVendaNumero = new DataGridViewTextBoxColumn();
            clnFuncionario = new DataGridViewTextBoxColumn();
            clnVendaTotal = new DataGridViewTextBoxColumn();
            clnVendaVolume = new DataGridViewTextBoxColumn();
            clnVendaRealizaEm = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            dtpFiltrarPorDataDe = new DateTimePicker();
            groupBox3 = new GroupBox();
            dtpFiltrarPorDataAte = new DateTimePicker();
            groupBox5 = new GroupBox();
            btnFiltrarPorData = new Button();
            btnSelecionar = new Button();
            gbxTerminalNumero = new GroupBox();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidoItens).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            groupBox4.ForeColor = Color.WhiteSmoke;
            groupBox4.Location = new Point(3, 360);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1090, 352);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ítens do pedido";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvPedidoItens);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(3, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 270);
            panel1.TabIndex = 1;
            // 
            // dgvPedidoItens
            // 
            dgvPedidoItens.AllowUserToAddRows = false;
            dgvPedidoItens.AllowUserToDeleteRows = false;
            dgvPedidoItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidoItens.BackgroundColor = Color.Silver;
            dgvPedidoItens.BorderStyle = BorderStyle.None;
            dgvPedidoItens.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.SteelBlue;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPedidoItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPedidoItens.ColumnHeadersHeight = 60;
            dgvPedidoItens.Columns.AddRange(new DataGridViewColumn[] { clnVendaItemNumero, clnVendaItemCodBarrasCodRef, clnVendaItemDescricao, clnVendaItemUnd, clnVendaItemPrecoUnitario, clnVendaItemQntd, clnVendaItemTotal });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPedidoItens.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPedidoItens.Dock = DockStyle.Fill;
            dgvPedidoItens.EnableHeadersVisualStyles = false;
            dgvPedidoItens.GridColor = Color.Silver;
            dgvPedidoItens.Location = new Point(0, 0);
            dgvPedidoItens.MultiSelect = false;
            dgvPedidoItens.Name = "dgvPedidoItens";
            dgvPedidoItens.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvPedidoItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvPedidoItens.RowHeadersVisible = false;
            dgvPedidoItens.RowHeadersWidth = 62;
            dgvPedidoItens.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvPedidoItens.RowTemplate.Height = 45;
            dgvPedidoItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidoItens.Size = new Size(1084, 270);
            dgvPedidoItens.TabIndex = 0;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1090, 351);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedidos";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPedidos);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 9F);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(3, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 269);
            panel2.TabIndex = 1;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.BackgroundColor = Color.Silver;
            dgvPedidos.BorderStyle = BorderStyle.None;
            dgvPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.SteelBlue;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvPedidos.ColumnHeadersHeight = 60;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { clnVendaId, clnVendaNumero, clnFuncionario, clnVendaTotal, clnVendaVolume, clnVendaRealizaEm });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvPedidos.DefaultCellStyle = dataGridViewCellStyle11;
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.EnableHeadersVisualStyles = false;
            dgvPedidos.GridColor = Color.Silver;
            dgvPedidos.Location = new Point(0, 0);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 62;
            dgvPedidos.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvPedidos.RowTemplate.Height = 45;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(1084, 269);
            dgvPedidos.TabIndex = 0;
            dgvPedidos.CellDoubleClick += DgvItens_CellDoubleClick;
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
            // clnFuncionario
            // 
            clnFuncionario.HeaderText = "Funcionário";
            clnFuncionario.MinimumWidth = 8;
            clnFuncionario.Name = "clnFuncionario";
            clnFuncionario.ReadOnly = true;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 1);
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
            gbxTerminalNumero.Font = new Font("Segoe UI", 15F);
            gbxTerminalNumero.ForeColor = Color.WhiteSmoke;
            gbxTerminalNumero.Location = new Point(464, 12);
            gbxTerminalNumero.Name = "gbxTerminalNumero";
            gbxTerminalNumero.Size = new Size(644, 105);
            gbxTerminalNumero.TabIndex = 6;
            gbxTerminalNumero.TabStop = false;
            gbxTerminalNumero.Text = "Nº do Terminal";
            // 
            // FrmPedidoEmAberto
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
            Name = "FrmPedidoEmAberto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pedidos em aberto";
            WindowState = FormWindowState.Maximized;
            Load += FrmFrenteCaixaEmEspera_Load;
            groupBox4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidoItens).EndInit();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Panel panel1;
        private DataGridView dgvPedidoItens;
        private GroupBox groupBox1;
        private Panel panel2;
        private DataGridView dgvPedidos;
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
        private DataGridViewTextBoxColumn clnVendaId;
        private DataGridViewTextBoxColumn clnVendaNumero;
        private DataGridViewTextBoxColumn clnFuncionario;
        private DataGridViewTextBoxColumn clnVendaTotal;
        private DataGridViewTextBoxColumn clnVendaVolume;
        private DataGridViewTextBoxColumn clnVendaRealizaEm;
    }
}