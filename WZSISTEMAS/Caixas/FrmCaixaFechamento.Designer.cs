namespace WZSISTEMAS.Caixas
{
    partial class FrmCaixaFechamento
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
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbEntradaDinheiro = new Label();
            lbEntradaCartaoDebito = new Label();
            lbEntradaCartaoCredito = new Label();
            lbEntradaCartaoConvenio = new Label();
            lbEntradaCartaoVoucher = new Label();
            lbEntradaOutros = new Label();
            label1 = new Label();
            groupBox7 = new GroupBox();
            lbSaldoFinal = new Label();
            lbEntradaCheque = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            lbAbertoEm = new Label();
            groupBox2 = new GroupBox();
            lbSaldoInicial = new Label();
            groupBox3 = new GroupBox();
            dgvMovimentacoes = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnMovimentacao = new DataGridViewTextBoxColumn();
            clnTipo = new DataGridViewTextBoxColumn();
            clnValor = new DataGridViewTextBoxColumn();
            clnDataHora = new DataGridViewTextBoxColumn();
            groupBox6 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbSaidaDinheiro = new Label();
            label28 = new Label();
            label19 = new Label();
            lbSaidaCheque = new Label();
            label20 = new Label();
            lbSaidaOutros = new Label();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).BeginInit();
            groupBox6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(150, 42);
            label2.TabIndex = 3;
            label2.Text = "Cartão Débito";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 84);
            label3.Name = "label3";
            label3.Size = new Size(150, 42);
            label3.TabIndex = 4;
            label3.Text = "Cartão Crédito";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 126);
            label5.Name = "label5";
            label5.Size = new Size(150, 42);
            label5.TabIndex = 6;
            label5.Text = "Cartão Convênio";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 168);
            label4.Name = "label4";
            label4.Size = new Size(150, 42);
            label4.TabIndex = 5;
            label4.Text = "Cartão Voucher";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 210);
            label6.Name = "label6";
            label6.Size = new Size(150, 42);
            label6.TabIndex = 7;
            label6.Text = "Cheque";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 252);
            label7.Name = "label7";
            label7.Size = new Size(150, 42);
            label7.TabIndex = 8;
            label7.Text = "Outros";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEntradaDinheiro
            // 
            lbEntradaDinheiro.Dock = DockStyle.Fill;
            lbEntradaDinheiro.Location = new Point(159, 0);
            lbEntradaDinheiro.Name = "lbEntradaDinheiro";
            lbEntradaDinheiro.Size = new Size(150, 42);
            lbEntradaDinheiro.TabIndex = 9;
            lbEntradaDinheiro.Text = "R$ 0,00";
            lbEntradaDinheiro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEntradaCartaoDebito
            // 
            lbEntradaCartaoDebito.Dock = DockStyle.Fill;
            lbEntradaCartaoDebito.Location = new Point(159, 42);
            lbEntradaCartaoDebito.Name = "lbEntradaCartaoDebito";
            lbEntradaCartaoDebito.Size = new Size(150, 42);
            lbEntradaCartaoDebito.TabIndex = 10;
            lbEntradaCartaoDebito.Text = "R$ 0,00";
            lbEntradaCartaoDebito.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEntradaCartaoCredito
            // 
            lbEntradaCartaoCredito.Dock = DockStyle.Fill;
            lbEntradaCartaoCredito.Location = new Point(159, 84);
            lbEntradaCartaoCredito.Name = "lbEntradaCartaoCredito";
            lbEntradaCartaoCredito.Size = new Size(150, 42);
            lbEntradaCartaoCredito.TabIndex = 11;
            lbEntradaCartaoCredito.Text = "R$ 0,00";
            lbEntradaCartaoCredito.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEntradaCartaoConvenio
            // 
            lbEntradaCartaoConvenio.Dock = DockStyle.Fill;
            lbEntradaCartaoConvenio.Location = new Point(159, 126);
            lbEntradaCartaoConvenio.Name = "lbEntradaCartaoConvenio";
            lbEntradaCartaoConvenio.Size = new Size(150, 42);
            lbEntradaCartaoConvenio.TabIndex = 12;
            lbEntradaCartaoConvenio.Text = "R$ 0,00";
            lbEntradaCartaoConvenio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEntradaCartaoVoucher
            // 
            lbEntradaCartaoVoucher.Dock = DockStyle.Fill;
            lbEntradaCartaoVoucher.Location = new Point(159, 168);
            lbEntradaCartaoVoucher.Name = "lbEntradaCartaoVoucher";
            lbEntradaCartaoVoucher.Size = new Size(150, 42);
            lbEntradaCartaoVoucher.TabIndex = 13;
            lbEntradaCartaoVoucher.Text = "R$ 0,00";
            lbEntradaCartaoVoucher.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEntradaOutros
            // 
            lbEntradaOutros.Dock = DockStyle.Fill;
            lbEntradaOutros.Location = new Point(159, 252);
            lbEntradaOutros.Name = "lbEntradaOutros";
            lbEntradaOutros.Size = new Size(150, 42);
            lbEntradaOutros.TabIndex = 15;
            lbEntradaOutros.Text = "R$ 0,00";
            lbEntradaOutros.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 42);
            label1.TabIndex = 2;
            label1.Text = "Dinheiro";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lbSaldoFinal);
            groupBox7.Location = new Point(586, 13);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(280, 97);
            groupBox7.TabIndex = 25;
            groupBox7.TabStop = false;
            groupBox7.Text = "Saldo final";
            // 
            // lbSaldoFinal
            // 
            lbSaldoFinal.Dock = DockStyle.Fill;
            lbSaldoFinal.Location = new Point(3, 27);
            lbSaldoFinal.Name = "lbSaldoFinal";
            lbSaldoFinal.Size = new Size(274, 67);
            lbSaldoFinal.TabIndex = 1;
            lbSaldoFinal.Text = "R$ 0,00";
            lbSaldoFinal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEntradaCheque
            // 
            lbEntradaCheque.Dock = DockStyle.Fill;
            lbEntradaCheque.Location = new Point(159, 210);
            lbEntradaCheque.Name = "lbEntradaCheque";
            lbEntradaCheque.Size = new Size(150, 42);
            lbEntradaCheque.TabIndex = 14;
            lbEntradaCheque.Text = "R$ 0,00";
            lbEntradaCheque.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(lbEntradaDinheiro, 1, 0);
            tableLayoutPanel1.Controls.Add(lbEntradaCartaoDebito, 1, 1);
            tableLayoutPanel1.Controls.Add(lbEntradaCartaoCredito, 1, 2);
            tableLayoutPanel1.Controls.Add(lbEntradaCartaoConvenio, 1, 3);
            tableLayoutPanel1.Controls.Add(lbEntradaCartaoVoucher, 1, 4);
            tableLayoutPanel1.Controls.Add(lbEntradaCheque, 1, 5);
            tableLayoutPanel1.Controls.Add(lbEntradaOutros, 1, 6);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Size = new Size(312, 296);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbAbertoEm);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 97);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aberto em";
            // 
            // lbAbertoEm
            // 
            lbAbertoEm.Dock = DockStyle.Fill;
            lbAbertoEm.Location = new Point(3, 27);
            lbAbertoEm.Name = "lbAbertoEm";
            lbAbertoEm.Size = new Size(276, 67);
            lbAbertoEm.TabIndex = 0;
            lbAbertoEm.Text = "00:00:00 Dia Mes Ano";
            lbAbertoEm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbSaldoInicial);
            groupBox2.Location = new Point(300, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 97);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Saldo inicial";
            // 
            // lbSaldoInicial
            // 
            lbSaldoInicial.Dock = DockStyle.Fill;
            lbSaldoInicial.Location = new Point(3, 27);
            lbSaldoInicial.Name = "lbSaldoInicial";
            lbSaldoInicial.Size = new Size(274, 67);
            lbSaldoInicial.TabIndex = 1;
            lbSaldoInicial.Text = "R$ 0,00";
            lbSaldoInicial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dgvMovimentacoes);
            groupBox3.Location = new Point(15, 116);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(763, 807);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Movimentações";
            // 
            // dgvMovimentacoes
            // 
            dgvMovimentacoes.AllowUserToAddRows = false;
            dgvMovimentacoes.AllowUserToDeleteRows = false;
            dgvMovimentacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMovimentacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimentacoes.ColumnHeadersHeight = 45;
            dgvMovimentacoes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnMovimentacao, clnTipo, clnValor, clnDataHora });
            dgvMovimentacoes.Location = new Point(3, 27);
            dgvMovimentacoes.MultiSelect = false;
            dgvMovimentacoes.Name = "dgvMovimentacoes";
            dgvMovimentacoes.ReadOnly = true;
            dgvMovimentacoes.RowHeadersVisible = false;
            dgvMovimentacoes.RowHeadersWidth = 62;
            dgvMovimentacoes.RowTemplate.Height = 42;
            dgvMovimentacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimentacoes.Size = new Size(757, 777);
            dgvMovimentacoes.TabIndex = 0;
            // 
            // clnId
            // 
            clnId.HeaderText = "Id";
            clnId.MinimumWidth = 8;
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Visible = false;
            // 
            // clnMovimentacao
            // 
            clnMovimentacao.HeaderText = "Movimentação";
            clnMovimentacao.MinimumWidth = 8;
            clnMovimentacao.Name = "clnMovimentacao";
            clnMovimentacao.ReadOnly = true;
            // 
            // clnTipo
            // 
            clnTipo.HeaderText = "Tipo";
            clnTipo.MinimumWidth = 8;
            clnTipo.Name = "clnTipo";
            clnTipo.ReadOnly = true;
            // 
            // clnValor
            // 
            clnValor.HeaderText = "Valor (R$)";
            clnValor.MinimumWidth = 8;
            clnValor.Name = "clnValor";
            clnValor.ReadOnly = true;
            // 
            // clnDataHora
            // 
            clnDataHora.HeaderText = "Data/Hora";
            clnDataHora.MinimumWidth = 8;
            clnDataHora.Name = "clnDataHora";
            clnDataHora.ReadOnly = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tableLayoutPanel2);
            groupBox6.Location = new Point(6, 362);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(318, 156);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Saídas";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lbSaidaDinheiro, 1, 0);
            tableLayoutPanel2.Controls.Add(label28, 0, 0);
            tableLayoutPanel2.Controls.Add(label19, 0, 1);
            tableLayoutPanel2.Controls.Add(lbSaidaCheque, 1, 1);
            tableLayoutPanel2.Controls.Add(label20, 0, 2);
            tableLayoutPanel2.Controls.Add(lbSaidaOutros, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 27);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.Size = new Size(312, 126);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lbSaidaDinheiro
            // 
            lbSaidaDinheiro.Dock = DockStyle.Fill;
            lbSaidaDinheiro.Location = new Point(159, 0);
            lbSaidaDinheiro.Name = "lbSaidaDinheiro";
            lbSaidaDinheiro.Size = new Size(150, 42);
            lbSaidaDinheiro.TabIndex = 9;
            lbSaidaDinheiro.Text = "R$ 0,00";
            lbSaidaDinheiro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            label28.Dock = DockStyle.Fill;
            label28.Location = new Point(3, 0);
            label28.Name = "label28";
            label28.Size = new Size(150, 42);
            label28.TabIndex = 2;
            label28.Text = "Dinheiro";
            label28.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            label19.Location = new Point(3, 42);
            label19.Name = "label19";
            label19.Size = new Size(150, 42);
            label19.TabIndex = 7;
            label19.Text = "Cheque";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbSaidaCheque
            // 
            lbSaidaCheque.Location = new Point(159, 42);
            lbSaidaCheque.Name = "lbSaidaCheque";
            lbSaidaCheque.Size = new Size(150, 42);
            lbSaidaCheque.TabIndex = 14;
            lbSaidaCheque.Text = "R$ 0,00";
            lbSaidaCheque.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.Location = new Point(3, 84);
            label20.Name = "label20";
            label20.Size = new Size(150, 42);
            label20.TabIndex = 8;
            label20.Text = "Outros";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbSaidaOutros
            // 
            lbSaidaOutros.Location = new Point(159, 84);
            lbSaidaOutros.Name = "lbSaidaOutros";
            lbSaidaOutros.Size = new Size(150, 42);
            lbSaidaOutros.TabIndex = 15;
            lbSaidaOutros.Text = "R$ 0,00";
            lbSaidaOutros.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(784, 116);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(324, 537);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Detalhes";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tableLayoutPanel1);
            groupBox5.Location = new Point(6, 30);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(318, 326);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Entradas";
            // 
            // FrmCaixaFechamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 935);
            Controls.Add(groupBox7);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            DoubleBuffered = true;
            Name = "FrmCaixaFechamento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalhes de fechamento";
            TopMost = false;
            Load += FrmDetalhesFechamentoCaixa_Load;
            groupBox7.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).EndInit();
            groupBox6.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label lbEntradaDinheiro;
        private Label lbEntradaCartaoDebito;
        private Label lbEntradaCartaoCredito;
        private Label lbEntradaCartaoConvenio;
        private Label lbEntradaCartaoVoucher;
        private Label lbEntradaOutros;
        private Label label1;
        private GroupBox groupBox7;
        private Label lbSaldoFinal;
        private Label lbEntradaCheque;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Label lbAbertoEm;
        private GroupBox groupBox2;
        private Label lbSaldoInicial;
        private GroupBox groupBox3;
        private DataGridView dgvMovimentacoes;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnMovimentacao;
        private DataGridViewTextBoxColumn clnTipo;
        private DataGridViewTextBoxColumn clnValor;
        private GroupBox groupBox6;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbSaidaDinheiro;
        private Label label28;
        private Label label19;
        private Label lbSaidaCheque;
        private Label label20;
        private Label lbSaidaOutros;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private DataGridViewTextBoxColumn clnDataHora;
    }
}