namespace WZSISTEMAS.Caixas
{
    partial class FrmCaixa
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
            lbAbertoEm = new Label();
            groupBox2 = new GroupBox();
            lbSaldoInicial = new Label();
            groupBox3 = new GroupBox();
            dgvMovimentacoes = new DataGridView();
            clnMovimentacao = new DataGridViewTextBoxColumn();
            clnTipo = new DataGridViewTextBoxColumn();
            clnValor = new DataGridViewTextBoxColumn();
            clnDataHora = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            groupBox6 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbSaidaDinheiro = new Label();
            label28 = new Label();
            label19 = new Label();
            lbSaidaCheque = new Label();
            label20 = new Label();
            lbSaidaOutros = new Label();
            groupBox5 = new GroupBox();
            chbxEntradasCanceladas = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
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
            lbEntradaCheque = new Label();
            lbEntradaOutros = new Label();
            label1 = new Label();
            groupBox7 = new GroupBox();
            lbSaldoFinal = new Label();
            btnEntrada = new Button();
            btnCancelar = new Button();
            btnFechar = new Button();
            btnSaida = new Button();
            groupBox8 = new GroupBox();
            lbSaldoDinheiro = new Label();
            groupBox9 = new GroupBox();
            lbNumeroTerminal = new Label();
            groupBox10 = new GroupBox();
            lbNumeroCaixa = new Label();
            chbxSaidasCanceladas = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).BeginInit();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbAbertoEm);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 97);
            groupBox1.TabIndex = 0;
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
            groupBox2.Location = new Point(300, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 97);
            groupBox2.TabIndex = 1;
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
            groupBox3.Location = new Point(15, 220);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(763, 655);
            groupBox3.TabIndex = 2;
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
            dgvMovimentacoes.Columns.AddRange(new DataGridViewColumn[] { clnMovimentacao, clnTipo, clnValor, clnDataHora });
            dgvMovimentacoes.Location = new Point(3, 27);
            dgvMovimentacoes.MultiSelect = false;
            dgvMovimentacoes.Name = "dgvMovimentacoes";
            dgvMovimentacoes.ReadOnly = true;
            dgvMovimentacoes.RowHeadersVisible = false;
            dgvMovimentacoes.RowHeadersWidth = 62;
            dgvMovimentacoes.RowTemplate.Height = 42;
            dgvMovimentacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimentacoes.Size = new Size(757, 625);
            dgvMovimentacoes.TabIndex = 0;
            dgvMovimentacoes.SelectionChanged += DgvMovimentacoes_SelectionChanged;
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
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(784, 115);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(324, 537);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Detalhes";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tableLayoutPanel2);
            groupBox6.Location = new Point(6, 393);
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
            lbSaidaDinheiro.ForeColor = Color.SeaGreen;
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
            lbSaidaCheque.ForeColor = Color.SeaGreen;
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
            lbSaidaOutros.ForeColor = Color.SeaGreen;
            lbSaidaOutros.Location = new Point(159, 84);
            lbSaidaOutros.Name = "lbSaidaOutros";
            lbSaidaOutros.Size = new Size(150, 42);
            lbSaidaOutros.TabIndex = 15;
            lbSaidaOutros.Text = "R$ 0,00";
            lbSaidaOutros.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(chbxEntradasCanceladas);
            groupBox5.Controls.Add(tableLayoutPanel1);
            groupBox5.Location = new Point(6, 30);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(318, 364);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Entradas";
            // 
            // chbxEntradasCanceladas
            // 
            chbxEntradasCanceladas.AutoSize = true;
            chbxEntradasCanceladas.Location = new Point(184, 328);
            chbxEntradasCanceladas.Name = "chbxEntradasCanceladas";
            chbxEntradasCanceladas.Size = new Size(128, 29);
            chbxEntradasCanceladas.TabIndex = 1;
            chbxEntradasCanceladas.Text = "Cancelados";
            chbxEntradasCanceladas.UseVisualStyleBackColor = true;
            chbxEntradasCanceladas.CheckedChanged += ChbxEntradasCanceladas_CheckedChanged;
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
            tableLayoutPanel1.Size = new Size(312, 297);
            tableLayoutPanel1.TabIndex = 0;
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
            lbEntradaDinheiro.ForeColor = Color.SeaGreen;
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
            lbEntradaCartaoDebito.ForeColor = Color.SeaGreen;
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
            lbEntradaCartaoCredito.ForeColor = Color.SeaGreen;
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
            lbEntradaCartaoConvenio.ForeColor = Color.SeaGreen;
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
            lbEntradaCartaoVoucher.ForeColor = Color.SeaGreen;
            lbEntradaCartaoVoucher.Location = new Point(159, 168);
            lbEntradaCartaoVoucher.Name = "lbEntradaCartaoVoucher";
            lbEntradaCartaoVoucher.Size = new Size(150, 42);
            lbEntradaCartaoVoucher.TabIndex = 13;
            lbEntradaCartaoVoucher.Text = "R$ 0,00";
            lbEntradaCartaoVoucher.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEntradaCheque
            // 
            lbEntradaCheque.Dock = DockStyle.Fill;
            lbEntradaCheque.ForeColor = Color.SeaGreen;
            lbEntradaCheque.Location = new Point(159, 210);
            lbEntradaCheque.Name = "lbEntradaCheque";
            lbEntradaCheque.Size = new Size(150, 42);
            lbEntradaCheque.TabIndex = 14;
            lbEntradaCheque.Text = "R$ 0,00";
            lbEntradaCheque.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEntradaOutros
            // 
            lbEntradaOutros.Dock = DockStyle.Fill;
            lbEntradaOutros.ForeColor = Color.SeaGreen;
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
            groupBox7.Location = new Point(586, 12);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(280, 97);
            groupBox7.TabIndex = 4;
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
            // btnEntrada
            // 
            btnEntrada.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEntrada.Location = new Point(884, 883);
            btnEntrada.Margin = new Padding(4, 5, 4, 5);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(107, 38);
            btnEntrada.TabIndex = 19;
            btnEntrada.Text = "Entrada (+)";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += BtnEntrada_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(769, 883);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 38);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.Location = new Point(653, 883);
            btnFechar.Margin = new Padding(4, 5, 4, 5);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(107, 38);
            btnFechar.TabIndex = 17;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += BtnFechar_Click;
            // 
            // btnSaida
            // 
            btnSaida.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaida.Location = new Point(1000, 883);
            btnSaida.Margin = new Padding(4, 5, 4, 5);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(107, 38);
            btnSaida.TabIndex = 20;
            btnSaida.Text = "Saida (-)";
            btnSaida.UseVisualStyleBackColor = true;
            btnSaida.Click += BtnSaida_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(lbSaldoDinheiro);
            groupBox8.Location = new Point(872, 12);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(236, 97);
            groupBox8.TabIndex = 21;
            groupBox8.TabStop = false;
            groupBox8.Text = "Saldo dinheiro";
            // 
            // lbSaldoDinheiro
            // 
            lbSaldoDinheiro.Dock = DockStyle.Fill;
            lbSaldoDinheiro.Location = new Point(3, 27);
            lbSaldoDinheiro.Name = "lbSaldoDinheiro";
            lbSaldoDinheiro.Size = new Size(230, 67);
            lbSaldoDinheiro.TabIndex = 1;
            lbSaldoDinheiro.Text = "R$ 0,00";
            lbSaldoDinheiro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(lbNumeroTerminal);
            groupBox9.Location = new Point(12, 117);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(282, 97);
            groupBox9.TabIndex = 22;
            groupBox9.TabStop = false;
            groupBox9.Text = "Nº do Terminal";
            // 
            // lbNumeroTerminal
            // 
            lbNumeroTerminal.Dock = DockStyle.Fill;
            lbNumeroTerminal.Location = new Point(3, 27);
            lbNumeroTerminal.Name = "lbNumeroTerminal";
            lbNumeroTerminal.Size = new Size(276, 67);
            lbNumeroTerminal.TabIndex = 0;
            lbNumeroTerminal.Text = "0";
            lbNumeroTerminal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(lbNumeroCaixa);
            groupBox10.Location = new Point(297, 115);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(282, 97);
            groupBox10.TabIndex = 23;
            groupBox10.TabStop = false;
            groupBox10.Text = "Nº do Caixa";
            // 
            // lbNumeroCaixa
            // 
            lbNumeroCaixa.Dock = DockStyle.Fill;
            lbNumeroCaixa.Location = new Point(3, 27);
            lbNumeroCaixa.Name = "lbNumeroCaixa";
            lbNumeroCaixa.Size = new Size(276, 67);
            lbNumeroCaixa.TabIndex = 0;
            lbNumeroCaixa.Text = "0";
            lbNumeroCaixa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chbxSaidasCanceladas
            // 
            chbxSaidasCanceladas.AutoSize = true;
            chbxSaidasCanceladas.Location = new Point(980, 670);
            chbxSaidasCanceladas.Name = "chbxSaidasCanceladas";
            chbxSaidasCanceladas.Size = new Size(128, 29);
            chbxSaidasCanceladas.TabIndex = 24;
            chbxSaidasCanceladas.Text = "Cancelados";
            chbxSaidasCanceladas.UseVisualStyleBackColor = true;
            chbxSaidasCanceladas.CheckedChanged += ChbxSaidasCanceladas_CheckedChanged;
            // 
            // FrmCaixa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 935);
            Controls.Add(chbxSaidasCanceladas);
            Controls.Add(groupBox10);
            Controls.Add(groupBox9);
            Controls.Add(groupBox8);
            Controls.Add(btnEntrada);
            Controls.Add(btnCancelar);
            Controls.Add(btnFechar);
            Controls.Add(btnSaida);
            Controls.Add(groupBox7);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "FrmCaixa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Caixa";
            Load += FrmCaixa_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbAbertoEm;
        private GroupBox groupBox2;
        private Label lbSaldoInicial;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label lbEntradaDinheiro;
        private GroupBox groupBox6;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbSaidaDinheiro;
        private Label label28;
        private Label label19;
        private Label lbSaidaCheque;
        private Label label20;
        private Label lbSaidaOutros;
        private Label lbEntradaCartaoDebito;
        private Label lbEntradaCartaoCredito;
        private Label lbEntradaCartaoConvenio;
        private Label lbEntradaCartaoVoucher;
        private Label lbEntradaCheque;
        private Label lbEntradaOutros;
        private GroupBox groupBox7;
        private Label lbSaldoFinal;
        private Button btnCancelar;
        private Button btnFechar;
        private Button btnEntrada;
        private Button btnSaida;
        private DataGridView dgvMovimentacoes;
        private GroupBox groupBox8;
        private Label lbSaldoDinheiro;
        private DataGridViewTextBoxColumn clnMovimentacao;
        private DataGridViewTextBoxColumn clnTipo;
        private DataGridViewTextBoxColumn clnValor;
        private DataGridViewTextBoxColumn clnDataHora;
        private CheckBox chbxEntradasCanceladas;
        private GroupBox groupBox9;
        private Label lbNumeroTerminal;
        private GroupBox groupBox10;
        private Label lbNumeroCaixa;
        private CheckBox chbxSaidasCanceladas;
    }
}