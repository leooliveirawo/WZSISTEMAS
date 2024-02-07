namespace WZSISTEMAS.Pedidos
{
    partial class FrmPedidoManutencao
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
            btnImprimirNota = new Button();
            groupBox5 = new GroupBox();
            btnFiltrarPorData = new Button();
            groupBox2 = new GroupBox();
            dtpFiltrarPorDataDe = new DateTimePicker();
            groupBox3 = new GroupBox();
            dtpFiltrarPorDataAte = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            panel2 = new Panel();
            dgvPedidos = new DataGridView();
            groupBox6 = new GroupBox();
            panel1 = new Panel();
            dgvPedidoItens = new DataGridView();
            clnVendaItemNumero = new DataGridViewTextBoxColumn();
            clnItemCod = new DataGridViewTextBoxColumn();
            clnVendaItemCodBarrasCodRef = new DataGridViewTextBoxColumn();
            clnVendaItemDescricao = new DataGridViewTextBoxColumn();
            clnVendaItemUnd = new DataGridViewTextBoxColumn();
            clnVendaItemPrecoUnitario = new DataGridViewTextBoxColumn();
            clnVendaItemQntd = new DataGridViewTextBoxColumn();
            clnVendaItemTotal = new DataGridViewTextBoxColumn();
            btnImprimirCupom = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            rbtnVendasCanceladas = new RadioButton();
            rbtnVendasFinalizadas = new RadioButton();
            clnVendaId = new DataGridViewTextBoxColumn();
            clnItemTerminal = new DataGridViewTextBoxColumn();
            clnItemFuncionario = new DataGridViewTextBoxColumn();
            clnVendaTotal = new DataGridViewTextBoxColumn();
            clnVendaVolume = new DataGridViewTextBoxColumn();
            clnVendaRealizaEm = new DataGridViewTextBoxColumn();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            groupBox6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidoItens).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnImprimirNota
            // 
            btnImprimirNota.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImprimirNota.ForeColor = Color.Black;
            btnImprimirNota.Location = new Point(676, 851);
            btnImprimirNota.Name = "btnImprimirNota";
            btnImprimirNota.Size = new Size(129, 72);
            btnImprimirNota.TabIndex = 8;
            btnImprimirNota.Text = "Imprimir nota\r\n(NFE)";
            btnImprimirNota.UseVisualStyleBackColor = true;
            btnImprimirNota.Click += BtnImprimirNota_Click;
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
            groupBox5.TabIndex = 7;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox6, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 168);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1096, 677);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel2);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            groupBox4.ForeColor = Color.WhiteSmoke;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1090, 332);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pedidos";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPedidos);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 9F);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(3, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 250);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPedidos.ColumnHeadersHeight = 60;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { clnVendaId, clnItemTerminal, clnItemFuncionario, clnVendaTotal, clnVendaVolume, clnVendaRealizaEm });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.EnableHeadersVisualStyles = false;
            dgvPedidos.GridColor = Color.Silver;
            dgvPedidos.Location = new Point(0, 0);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 62;
            dgvPedidos.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvPedidos.RowTemplate.Height = 45;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(1084, 250);
            dgvPedidos.TabIndex = 0;
            dgvPedidos.CellClick += DgvVendas_CellClick;
            dgvPedidos.CellDoubleClick += DgvVendas_CellDoubleClick;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(panel1);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            groupBox6.ForeColor = Color.WhiteSmoke;
            groupBox6.Location = new Point(3, 341);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1090, 333);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Itens do pedido";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvPedidoItens);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(3, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 251);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPedidoItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPedidoItens.ColumnHeadersHeight = 60;
            dgvPedidoItens.Columns.AddRange(new DataGridViewColumn[] { clnVendaItemNumero, clnItemCod, clnVendaItemCodBarrasCodRef, clnVendaItemDescricao, clnVendaItemUnd, clnVendaItemPrecoUnitario, clnVendaItemQntd, clnVendaItemTotal });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPedidoItens.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPedidoItens.Dock = DockStyle.Fill;
            dgvPedidoItens.EnableHeadersVisualStyles = false;
            dgvPedidoItens.GridColor = Color.Silver;
            dgvPedidoItens.Location = new Point(0, 0);
            dgvPedidoItens.MultiSelect = false;
            dgvPedidoItens.Name = "dgvPedidoItens";
            dgvPedidoItens.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPedidoItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPedidoItens.RowHeadersVisible = false;
            dgvPedidoItens.RowHeadersWidth = 62;
            dgvPedidoItens.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvPedidoItens.RowTemplate.Height = 45;
            dgvPedidoItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidoItens.Size = new Size(1084, 251);
            dgvPedidoItens.TabIndex = 0;
            // 
            // clnVendaItemNumero
            // 
            clnVendaItemNumero.HeaderText = "Nº";
            clnVendaItemNumero.MinimumWidth = 8;
            clnVendaItemNumero.Name = "clnVendaItemNumero";
            clnVendaItemNumero.ReadOnly = true;
            // 
            // clnItemCod
            // 
            clnItemCod.HeaderText = "Cod";
            clnItemCod.MinimumWidth = 8;
            clnItemCod.Name = "clnItemCod";
            clnItemCod.ReadOnly = true;
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
            // btnImprimirCupom
            // 
            btnImprimirCupom.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImprimirCupom.ForeColor = Color.Black;
            btnImprimirCupom.Location = new Point(811, 851);
            btnImprimirCupom.Name = "btnImprimirCupom";
            btnImprimirCupom.Size = new Size(149, 72);
            btnImprimirCupom.TabIndex = 9;
            btnImprimirCupom.Text = "Imprimir cupom\r\n(não fiscal)";
            btnImprimirCupom.UseVisualStyleBackColor = true;
            btnImprimirCupom.Click += BtnImprimirCupom_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(966, 851);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 72);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar venda";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(rbtnVendasCanceladas);
            groupBox1.Controls.Add(rbtnVendasFinalizadas);
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(895, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 150);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedidos";
            // 
            // rbtnVendasCanceladas
            // 
            rbtnVendasCanceladas.AutoSize = true;
            rbtnVendasCanceladas.Location = new Point(6, 89);
            rbtnVendasCanceladas.Name = "rbtnVendasCanceladas";
            rbtnVendasCanceladas.Size = new Size(192, 45);
            rbtnVendasCanceladas.TabIndex = 1;
            rbtnVendasCanceladas.TabStop = true;
            rbtnVendasCanceladas.Text = "Canceladas";
            rbtnVendasCanceladas.UseVisualStyleBackColor = true;
            rbtnVendasCanceladas.CheckedChanged += RbtnVendas_CheckedChanged;
            // 
            // rbtnVendasFinalizadas
            // 
            rbtnVendasFinalizadas.AutoSize = true;
            rbtnVendasFinalizadas.Location = new Point(6, 46);
            rbtnVendasFinalizadas.Name = "rbtnVendasFinalizadas";
            rbtnVendasFinalizadas.Size = new Size(186, 45);
            rbtnVendasFinalizadas.TabIndex = 0;
            rbtnVendasFinalizadas.TabStop = true;
            rbtnVendasFinalizadas.Text = "Finalizadas";
            rbtnVendasFinalizadas.UseVisualStyleBackColor = true;
            rbtnVendasFinalizadas.CheckedChanged += RbtnVendas_CheckedChanged;
            // 
            // clnVendaId
            // 
            clnVendaId.HeaderText = "Nº";
            clnVendaId.MinimumWidth = 8;
            clnVendaId.Name = "clnVendaId";
            clnVendaId.ReadOnly = true;
            // 
            // clnItemTerminal
            // 
            clnItemTerminal.HeaderText = "Terminal";
            clnItemTerminal.MinimumWidth = 8;
            clnItemTerminal.Name = "clnItemTerminal";
            clnItemTerminal.ReadOnly = true;
            // 
            // clnItemFuncionario
            // 
            clnItemFuncionario.HeaderText = "Funcionário";
            clnItemFuncionario.MinimumWidth = 8;
            clnItemFuncionario.Name = "clnItemFuncionario";
            clnItemFuncionario.ReadOnly = true;
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
            // FrmPedidoManutencao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1120, 935);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnImprimirCupom);
            Controls.Add(btnImprimirNota);
            Controls.Add(groupBox5);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            ForeColor = Color.WhiteSmoke;
            Name = "FrmPedidosManutencao";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manutenção de pedidos";
            Load += FrmManutencaoVendas_Load;
            groupBox5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            groupBox6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidoItens).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImprimirNota;
        private GroupBox groupBox5;
        private Button btnFiltrarPorData;
        private GroupBox groupBox2;
        private DateTimePicker dtpFiltrarPorDataDe;
        private GroupBox groupBox3;
        private DateTimePicker dtpFiltrarPorDataAte;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox4;
        private Panel panel2;
        private DataGridView dgvPedidos;
        private GroupBox groupBox6;
        private Panel panel1;
        private DataGridView dgvPedidoItens;
        private Button btnImprimirCupom;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private RadioButton rbtnVendasCanceladas;
        private RadioButton rbtnVendasFinalizadas;
        private DataGridViewTextBoxColumn clnVendaItemNumero;
        private DataGridViewTextBoxColumn clnItemCod;
        private DataGridViewTextBoxColumn clnVendaItemCodBarrasCodRef;
        private DataGridViewTextBoxColumn clnVendaItemDescricao;
        private DataGridViewTextBoxColumn clnVendaItemUnd;
        private DataGridViewTextBoxColumn clnVendaItemPrecoUnitario;
        private DataGridViewTextBoxColumn clnVendaItemQntd;
        private DataGridViewTextBoxColumn clnVendaItemTotal;
        private DataGridViewTextBoxColumn clnVendaId;
        private DataGridViewTextBoxColumn clnItemTerminal;
        private DataGridViewTextBoxColumn clnItemFuncionario;
        private DataGridViewTextBoxColumn clnVendaTotal;
        private DataGridViewTextBoxColumn clnVendaVolume;
        private DataGridViewTextBoxColumn clnVendaRealizaEm;
    }
}