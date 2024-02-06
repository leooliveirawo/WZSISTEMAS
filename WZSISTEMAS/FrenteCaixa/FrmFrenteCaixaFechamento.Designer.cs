namespace WZSISTEMAS.FrenteCaixa
{
    partial class FrmFrenteCaixaFechamento
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox4 = new GroupBox();
            panel1 = new Panel();
            dgvItensVenda = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnIndex = new DataGridViewTextBoxColumn();
            clnFormaPagamento = new DataGridViewTextBoxColumn();
            clnValorPago = new DataGridViewTextBoxColumn();
            gbxVendaNumero = new GroupBox();
            gbxValorRestanteTroco = new GroupBox();
            lbValorRestanteTroco = new Label();
            gbxValorPago = new GroupBox();
            lbValorPago = new Label();
            groupBox1 = new GroupBox();
            lbValorTotal = new Label();
            gbxValorAPagar = new GroupBox();
            groupBox6 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label16 = new Label();
            label6 = new Label();
            label15 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtValorAPagar = new TextBox();
            groupBox2 = new GroupBox();
            lbCPF_CNPJ = new Label();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
            gbxVendaNumero.SuspendLayout();
            gbxValorRestanteTroco.SuspendLayout();
            gbxValorPago.SuspendLayout();
            groupBox1.SuspendLayout();
            gbxValorAPagar.SuspendLayout();
            groupBox6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(panel1);
            groupBox4.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.WhiteSmoke;
            groupBox4.Location = new Point(393, 139);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(715, 784);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Itens da venda";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvItensVenda);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(3, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 702);
            panel1.TabIndex = 1;
            // 
            // dgvItensVenda
            // 
            dgvItensVenda.AllowUserToAddRows = false;
            dgvItensVenda.AllowUserToDeleteRows = false;
            dgvItensVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItensVenda.BackgroundColor = Color.Silver;
            dgvItensVenda.BorderStyle = BorderStyle.None;
            dgvItensVenda.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItensVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvItensVenda.ColumnHeadersHeight = 60;
            dgvItensVenda.Columns.AddRange(new DataGridViewColumn[] { clnId, clnIndex, clnFormaPagamento, clnValorPago });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvItensVenda.DefaultCellStyle = dataGridViewCellStyle2;
            dgvItensVenda.Dock = DockStyle.Fill;
            dgvItensVenda.EnableHeadersVisualStyles = false;
            dgvItensVenda.GridColor = Color.Silver;
            dgvItensVenda.Location = new Point(0, 0);
            dgvItensVenda.MultiSelect = false;
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvItensVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvItensVenda.RowHeadersVisible = false;
            dgvItensVenda.RowHeadersWidth = 62;
            dgvItensVenda.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvItensVenda.RowTemplate.Height = 45;
            dgvItensVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensVenda.Size = new Size(709, 702);
            dgvItensVenda.TabIndex = 0;
            // 
            // clnId
            // 
            clnId.HeaderText = "Id";
            clnId.MinimumWidth = 8;
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Visible = false;
            // 
            // clnIndex
            // 
            clnIndex.HeaderText = "Nº";
            clnIndex.MinimumWidth = 8;
            clnIndex.Name = "clnIndex";
            clnIndex.ReadOnly = true;
            // 
            // clnFormaPagamento
            // 
            clnFormaPagamento.HeaderText = "Forma de pagamento";
            clnFormaPagamento.MinimumWidth = 8;
            clnFormaPagamento.Name = "clnFormaPagamento";
            clnFormaPagamento.ReadOnly = true;
            // 
            // clnValorPago
            // 
            clnValorPago.HeaderText = "Valor pago (R$)";
            clnValorPago.MinimumWidth = 8;
            clnValorPago.Name = "clnValorPago";
            clnValorPago.ReadOnly = true;
            // 
            // gbxVendaNumero
            // 
            gbxVendaNumero.Controls.Add(gbxValorRestanteTroco);
            gbxVendaNumero.Controls.Add(gbxValorPago);
            gbxVendaNumero.Controls.Add(groupBox1);
            gbxVendaNumero.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            gbxVendaNumero.ForeColor = Color.WhiteSmoke;
            gbxVendaNumero.Location = new Point(12, 12);
            gbxVendaNumero.Name = "gbxVendaNumero";
            gbxVendaNumero.Size = new Size(375, 440);
            gbxVendaNumero.TabIndex = 4;
            gbxVendaNumero.TabStop = false;
            gbxVendaNumero.Text = "Venda Nº";
            // 
            // gbxValorRestanteTroco
            // 
            gbxValorRestanteTroco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxValorRestanteTroco.Controls.Add(lbValorRestanteTroco);
            gbxValorRestanteTroco.ForeColor = Color.WhiteSmoke;
            gbxValorRestanteTroco.Location = new Point(6, 304);
            gbxValorRestanteTroco.Name = "gbxValorRestanteTroco";
            gbxValorRestanteTroco.Size = new Size(363, 121);
            gbxValorRestanteTroco.TabIndex = 2;
            gbxValorRestanteTroco.TabStop = false;
            gbxValorRestanteTroco.Text = "Total (Restante) R$";
            // 
            // lbValorRestanteTroco
            // 
            lbValorRestanteTroco.Dock = DockStyle.Fill;
            lbValorRestanteTroco.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lbValorRestanteTroco.ForeColor = Color.WhiteSmoke;
            lbValorRestanteTroco.Location = new Point(3, 47);
            lbValorRestanteTroco.Name = "lbValorRestanteTroco";
            lbValorRestanteTroco.Size = new Size(357, 71);
            lbValorRestanteTroco.TabIndex = 0;
            lbValorRestanteTroco.Text = "R$ 9999999,99";
            lbValorRestanteTroco.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gbxValorPago
            // 
            gbxValorPago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxValorPago.Controls.Add(lbValorPago);
            gbxValorPago.ForeColor = Color.WhiteSmoke;
            gbxValorPago.Location = new Point(6, 177);
            gbxValorPago.Name = "gbxValorPago";
            gbxValorPago.Size = new Size(363, 121);
            gbxValorPago.TabIndex = 1;
            gbxValorPago.TabStop = false;
            gbxValorPago.Text = "Total (Pago) R$";
            // 
            // lbValorPago
            // 
            lbValorPago.Dock = DockStyle.Fill;
            lbValorPago.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lbValorPago.ForeColor = Color.WhiteSmoke;
            lbValorPago.Location = new Point(3, 47);
            lbValorPago.Name = "lbValorPago";
            lbValorPago.Size = new Size(357, 71);
            lbValorPago.TabIndex = 0;
            lbValorPago.Text = "R$ 9999999,99";
            lbValorPago.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lbValorTotal);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(6, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total R$";
            // 
            // lbValorTotal
            // 
            lbValorTotal.Dock = DockStyle.Fill;
            lbValorTotal.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lbValorTotal.ForeColor = Color.WhiteSmoke;
            lbValorTotal.Location = new Point(3, 47);
            lbValorTotal.Name = "lbValorTotal";
            lbValorTotal.Size = new Size(357, 71);
            lbValorTotal.TabIndex = 0;
            lbValorTotal.Text = "R$ 9999999,99";
            lbValorTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gbxValorAPagar
            // 
            gbxValorAPagar.BackColor = Color.DarkRed;
            gbxValorAPagar.Controls.Add(groupBox6);
            gbxValorAPagar.Controls.Add(txtValorAPagar);
            gbxValorAPagar.ForeColor = Color.WhiteSmoke;
            gbxValorAPagar.Location = new Point(9, 458);
            gbxValorAPagar.Name = "gbxValorAPagar";
            gbxValorAPagar.Size = new Size(378, 441);
            gbxValorAPagar.TabIndex = 6;
            gbxValorAPagar.TabStop = false;
            gbxValorAPagar.Text = "Valor à pagar (R$)";
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox6.Controls.Add(tableLayoutPanel1);
            groupBox6.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.ForeColor = Color.WhiteSmoke;
            groupBox6.Location = new Point(6, 67);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(366, 368);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Comandos";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label16, 1, 7);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label15, 0, 7);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label8, 1, 3);
            tableLayoutPanel1.Controls.Add(label9, 0, 4);
            tableLayoutPanel1.Controls.Add(label10, 1, 4);
            tableLayoutPanel1.Controls.Add(label11, 0, 5);
            tableLayoutPanel1.Controls.Add(label12, 1, 5);
            tableLayoutPanel1.Controls.Add(label13, 0, 6);
            tableLayoutPanel1.Controls.Add(label14, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 47);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(360, 318);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label16
            // 
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.IndianRed;
            label16.Location = new Point(63, 280);
            label16.Name = "label16";
            label16.Size = new Size(294, 40);
            label16.TabIndex = 18;
            label16.Text = "Cancelar pagamento";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(3, 80);
            label6.Name = "label6";
            label6.Size = new Size(54, 40);
            label6.TabIndex = 7;
            label6.Text = "C";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.IndianRed;
            label15.Location = new Point(3, 280);
            label15.Name = "label15";
            label15.Size = new Size(54, 40);
            label15.TabIndex = 17;
            label15.Text = "F4";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 40);
            label4.TabIndex = 5;
            label4.Text = "D";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(63, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 40);
            label1.TabIndex = 0;
            label1.Text = "Dinheiro";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(63, 40);
            label3.Name = "label3";
            label3.Size = new Size(294, 40);
            label3.TabIndex = 2;
            label3.Text = "Cartão de débito";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(3, 40);
            label5.Name = "label5";
            label5.Size = new Size(54, 40);
            label5.TabIndex = 6;
            label5.Text = "B";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(63, 80);
            label7.Name = "label7";
            label7.Size = new Size(294, 40);
            label7.TabIndex = 8;
            label7.Text = "Cartão de crédito";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(3, 120);
            label2.Name = "label2";
            label2.Size = new Size(54, 40);
            label2.TabIndex = 9;
            label2.Text = "V";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(63, 120);
            label8.Name = "label8";
            label8.Size = new Size(294, 40);
            label8.TabIndex = 10;
            label8.Text = "Cartão Voucher";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(3, 160);
            label9.Name = "label9";
            label9.Size = new Size(54, 40);
            label9.TabIndex = 11;
            label9.Text = "T";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(63, 160);
            label10.Name = "label10";
            label10.Size = new Size(294, 40);
            label10.TabIndex = 12;
            label10.Text = "Cartão Convênio";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(3, 200);
            label11.Name = "label11";
            label11.Size = new Size(54, 40);
            label11.TabIndex = 13;
            label11.Text = "Q";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.SteelBlue;
            label12.Location = new Point(63, 200);
            label12.Name = "label12";
            label12.Size = new Size(294, 40);
            label12.TabIndex = 14;
            label12.Text = "Cheque";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.SteelBlue;
            label13.Location = new Point(3, 240);
            label13.Name = "label13";
            label13.Size = new Size(54, 40);
            label13.TabIndex = 15;
            label13.Text = "O";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.SteelBlue;
            label14.Location = new Point(63, 240);
            label14.Name = "label14";
            label14.Size = new Size(294, 40);
            label14.TabIndex = 16;
            label14.Text = "Outro";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtValorAPagar
            // 
            txtValorAPagar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValorAPagar.Location = new Point(6, 30);
            txtValorAPagar.Name = "txtValorAPagar";
            txtValorAPagar.Size = new Size(366, 31);
            txtValorAPagar.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lbCPF_CNPJ);
            groupBox2.ForeColor = Color.WhiteSmoke;
            groupBox2.Location = new Point(393, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(712, 121);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "CPF/CNPJ";
            // 
            // lbCPF_CNPJ
            // 
            lbCPF_CNPJ.Dock = DockStyle.Fill;
            lbCPF_CNPJ.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lbCPF_CNPJ.ForeColor = Color.WhiteSmoke;
            lbCPF_CNPJ.Location = new Point(3, 27);
            lbCPF_CNPJ.Name = "lbCPF_CNPJ";
            lbCPF_CNPJ.Size = new Size(706, 91);
            lbCPF_CNPJ.TabIndex = 0;
            lbCPF_CNPJ.Text = "Não informado";
            lbCPF_CNPJ.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmFrenteCaixaFechamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1120, 935);
            Controls.Add(groupBox2);
            Controls.Add(gbxValorAPagar);
            Controls.Add(groupBox4);
            Controls.Add(gbxVendaNumero);
            KeyPreview = true;
            Name = "FrmFrenteCaixaFechamento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fechamento - Frente de caixa";
            WindowState = FormWindowState.Maximized;
            Load += FrmFrenteCaixaFechamento_Load;
            KeyPress += FrmFrenteCaixaFechamento_KeyPress;
            KeyUp += FrmFrenteCaixaFechamento_KeyUp;
            groupBox4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).EndInit();
            gbxVendaNumero.ResumeLayout(false);
            gbxValorRestanteTroco.ResumeLayout(false);
            gbxValorPago.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            gbxValorAPagar.ResumeLayout(false);
            gbxValorAPagar.PerformLayout();
            groupBox6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Panel panel1;
        private DataGridView dgvItensVenda;
        private GroupBox gbxVendaNumero;
        private GroupBox groupBox1;
        private Label lbValorTotal;
        private GroupBox gbxValorRestanteTroco;
        private Label lbValorRestanteTroco;
        private GroupBox gbxValorPago;
        private Label lbValorPago;
        private GroupBox gbxValorAPagar;
        private TextBox txtValorAPagar;
        private GroupBox groupBox6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnIndex;
        private DataGridViewTextBoxColumn clnFormaPagamento;
        private DataGridViewTextBoxColumn clnValorPago;
        private Label label15;
        private Label label16;
        private GroupBox groupBox2;
        private Label lbCPF_CNPJ;
    }
}