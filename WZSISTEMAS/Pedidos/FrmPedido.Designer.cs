namespace WZSISTEMAS.Pedidos
{
    partial class FrmPedido
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
            gbxNumero = new GroupBox();
            lbTerminalNumero = new Label();
            groupBox1 = new GroupBox();
            lbTotal = new Label();
            groupBox2 = new GroupBox();
            chbxFiltrarCodRef = new CheckBox();
            txtCodBarrasCodRef = new TextBox();
            groupBox3 = new GroupBox();
            txtQntd = new TextBox();
            gbxItens = new GroupBox();
            panel1 = new Panel();
            dgvItens = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnIndex = new DataGridViewTextBoxColumn();
            clnCod = new DataGridViewTextBoxColumn();
            clnCodBarrasCodRef = new DataGridViewTextBoxColumn();
            cln = new DataGridViewTextBoxColumn();
            clnUnd = new DataGridViewTextBoxColumn();
            clnPrecoUnitario = new DataGridViewTextBoxColumn();
            clnQntd = new DataGridViewTextBoxColumn();
            clnTotal = new DataGridViewTextBoxColumn();
            groupBox5 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbF7Texto = new Label();
            lbF6Texto = new Label();
            label8 = new Label();
            label2 = new Label();
            label10 = new Label();
            label4 = new Label();
            label1 = new Label();
            lbF5Texto = new Label();
            label5 = new Label();
            lbESCTexto = new Label();
            menuStrip1 = new MenuStrip();
            menuALTToolStripMenuItem = new ToolStripMenuItem();
            tsmiCadastroCliente = new ToolStripMenuItem();
            tsmiCadastroFuncionario = new ToolStripMenuItem();
            tsmiCadastroFornecedor = new ToolStripMenuItem();
            tsmiCadastroProduto = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiPedidosEmAberto = new ToolStripMenuItem();
            tsmiManutencaoPedidos = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            groupBox4 = new GroupBox();
            txtBuscarPorNumeroPedido = new TextBox();
            gbxNumero.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            gbxItens.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            groupBox5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // gbxNumero
            // 
            gbxNumero.Controls.Add(lbTerminalNumero);
            gbxNumero.Controls.Add(groupBox1);
            gbxNumero.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            gbxNumero.ForeColor = Color.WhiteSmoke;
            gbxNumero.Location = new Point(6, 41);
            gbxNumero.Name = "gbxNumero";
            gbxNumero.Size = new Size(375, 223);
            gbxNumero.TabIndex = 0;
            gbxNumero.TabStop = false;
            gbxNumero.Text = "Nº do pedido";
            // 
            // lbTerminalNumero
            // 
            lbTerminalNumero.AutoSize = true;
            lbTerminalNumero.Location = new Point(6, 48);
            lbTerminalNumero.Name = "lbTerminalNumero";
            lbTerminalNumero.Size = new Size(263, 45);
            lbTerminalNumero.TabIndex = 1;
            lbTerminalNumero.Text = "Nº do terminal:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lbTotal);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(6, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total R$";
            // 
            // lbTotal
            // 
            lbTotal.Dock = DockStyle.Fill;
            lbTotal.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            lbTotal.Location = new Point(3, 47);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(357, 71);
            lbTotal.TabIndex = 0;
            lbTotal.Text = "R$ 9999999,99";
            lbTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkRed;
            groupBox2.Controls.Add(chbxFiltrarCodRef);
            groupBox2.Controls.Add(txtCodBarrasCodRef);
            groupBox2.ForeColor = Color.WhiteSmoke;
            groupBox2.Location = new Point(6, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(378, 101);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cód.Barras (Cód.Ref) (F2)";
            // 
            // chbxFiltrarCodRef
            // 
            chbxFiltrarCodRef.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chbxFiltrarCodRef.AutoSize = true;
            chbxFiltrarCodRef.Location = new Point(122, 67);
            chbxFiltrarCodRef.Name = "chbxFiltrarCodRef";
            chbxFiltrarCodRef.Size = new Size(250, 29);
            chbxFiltrarCodRef.TabIndex = 3;
            chbxFiltrarCodRef.Text = "Filtrar pelo Cod.Ref (SHIFT)";
            chbxFiltrarCodRef.UseVisualStyleBackColor = true;
            // 
            // txtCodBarrasCodRef
            // 
            txtCodBarrasCodRef.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodBarrasCodRef.Location = new Point(6, 30);
            txtCodBarrasCodRef.Name = "txtCodBarrasCodRef";
            txtCodBarrasCodRef.Size = new Size(366, 31);
            txtCodBarrasCodRef.TabIndex = 0;
            txtCodBarrasCodRef.KeyPress += TxtCodBarrasCodRef_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkRed;
            groupBox3.Controls.Add(txtQntd);
            groupBox3.ForeColor = Color.WhiteSmoke;
            groupBox3.Location = new Point(6, 377);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(131, 101);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Qntd";
            // 
            // txtQntd
            // 
            txtQntd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQntd.Location = new Point(6, 30);
            txtQntd.Name = "txtQntd";
            txtQntd.Size = new Size(119, 31);
            txtQntd.TabIndex = 0;
            txtQntd.Text = "1";
            txtQntd.KeyPress += TxtQntd_KeyPress;
            txtQntd.Leave += TxtQntd_Leave;
            // 
            // gbxItens
            // 
            gbxItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxItens.Controls.Add(panel1);
            gbxItens.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            gbxItens.ForeColor = Color.WhiteSmoke;
            gbxItens.Location = new Point(393, 120);
            gbxItens.Name = "gbxItens";
            gbxItens.Size = new Size(715, 803);
            gbxItens.TabIndex = 3;
            gbxItens.TabStop = false;
            gbxItens.Text = "Itens do pedido (F8)";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvItens);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(3, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 721);
            panel1.TabIndex = 1;
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.AllowUserToDeleteRows = false;
            dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItens.BackgroundColor = Color.Silver;
            dgvItens.BorderStyle = BorderStyle.None;
            dgvItens.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvItens.ColumnHeadersHeight = 60;
            dgvItens.Columns.AddRange(new DataGridViewColumn[] { clnId, clnIndex, clnCod, clnCodBarrasCodRef, cln, clnUnd, clnPrecoUnitario, clnQntd, clnTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvItens.DefaultCellStyle = dataGridViewCellStyle2;
            dgvItens.Dock = DockStyle.Fill;
            dgvItens.EnableHeadersVisualStyles = false;
            dgvItens.GridColor = Color.Silver;
            dgvItens.Location = new Point(0, 0);
            dgvItens.MultiSelect = false;
            dgvItens.Name = "dgvItens";
            dgvItens.ReadOnly = true;
            dgvItens.RowHeadersVisible = false;
            dgvItens.RowHeadersWidth = 62;
            dgvItens.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvItens.RowTemplate.Height = 45;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.Size = new Size(709, 721);
            dgvItens.TabIndex = 0;
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
            // clnCod
            // 
            clnCod.HeaderText = "Cod";
            clnCod.MinimumWidth = 8;
            clnCod.Name = "clnCod";
            clnCod.ReadOnly = true;
            // 
            // clnCodBarrasCodRef
            // 
            clnCodBarrasCodRef.HeaderText = "Cód.Barras (Cód.Ref)";
            clnCodBarrasCodRef.MinimumWidth = 8;
            clnCodBarrasCodRef.Name = "clnCodBarrasCodRef";
            clnCodBarrasCodRef.ReadOnly = true;
            // 
            // cln
            // 
            cln.HeaderText = "Descrição";
            cln.MinimumWidth = 8;
            cln.Name = "cln";
            cln.ReadOnly = true;
            // 
            // clnUnd
            // 
            clnUnd.HeaderText = "Und";
            clnUnd.MinimumWidth = 8;
            clnUnd.Name = "clnUnd";
            clnUnd.ReadOnly = true;
            // 
            // clnPrecoUnitario
            // 
            clnPrecoUnitario.HeaderText = "Unit (R$)";
            clnPrecoUnitario.MinimumWidth = 8;
            clnPrecoUnitario.Name = "clnPrecoUnitario";
            clnPrecoUnitario.ReadOnly = true;
            // 
            // clnQntd
            // 
            clnQntd.HeaderText = "Qntd";
            clnQntd.MinimumWidth = 8;
            clnQntd.Name = "clnQntd";
            clnQntd.ReadOnly = true;
            // 
            // clnTotal
            // 
            clnTotal.HeaderText = "Total (R$)";
            clnTotal.MinimumWidth = 8;
            clnTotal.Name = "clnTotal";
            clnTotal.ReadOnly = true;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox5.Controls.Add(tableLayoutPanel1);
            groupBox5.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            groupBox5.ForeColor = Color.WhiteSmoke;
            groupBox5.Location = new Point(12, 597);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(378, 326);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Comandos";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lbF7Texto, 1, 4);
            tableLayoutPanel1.Controls.Add(lbF6Texto, 1, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(lbF5Texto, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(lbESCTexto, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 47);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(372, 276);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbF7Texto
            // 
            lbF7Texto.Dock = DockStyle.Fill;
            lbF7Texto.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            lbF7Texto.ForeColor = Color.CadetBlue;
            lbF7Texto.Location = new Point(63, 160);
            lbF7Texto.Name = "lbF7Texto";
            lbF7Texto.Size = new Size(306, 40);
            lbF7Texto.TabIndex = 12;
            lbF7Texto.Text = "Pedidos em aberto";
            lbF7Texto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbF6Texto
            // 
            lbF6Texto.Dock = DockStyle.Fill;
            lbF6Texto.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            lbF6Texto.ForeColor = Color.CadetBlue;
            lbF6Texto.Location = new Point(63, 120);
            lbF6Texto.Name = "lbF6Texto";
            lbF6Texto.Size = new Size(306, 40);
            lbF6Texto.TabIndex = 11;
            lbF6Texto.Text = "Novo pedido";
            lbF6Texto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label8.ForeColor = Color.CadetBlue;
            label8.Location = new Point(3, 160);
            label8.Name = "label8";
            label8.Size = new Size(54, 40);
            label8.TabIndex = 10;
            label8.Text = "F7";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(3, 120);
            label2.Name = "label2";
            label2.Size = new Size(54, 40);
            label2.TabIndex = 9;
            label2.Text = "F6";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label10.ForeColor = Color.SeaGreen;
            label10.Location = new Point(3, 80);
            label10.Name = "label10";
            label10.Size = new Size(54, 40);
            label10.TabIndex = 7;
            label10.Text = "ESC";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 40);
            label4.TabIndex = 5;
            label4.Text = "F4";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(63, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 40);
            label1.TabIndex = 0;
            label1.Text = "Cancelar item";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbF5Texto
            // 
            lbF5Texto.Dock = DockStyle.Fill;
            lbF5Texto.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            lbF5Texto.ForeColor = Color.SteelBlue;
            lbF5Texto.Location = new Point(63, 40);
            lbF5Texto.Name = "lbF5Texto";
            lbF5Texto.Size = new Size(306, 40);
            lbF5Texto.TabIndex = 2;
            lbF5Texto.Text = "Converter para venda";
            lbF5Texto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(3, 40);
            label5.Name = "label5";
            label5.Size = new Size(54, 40);
            label5.TabIndex = 6;
            label5.Text = "F5";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbESCTexto
            // 
            lbESCTexto.Dock = DockStyle.Fill;
            lbESCTexto.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            lbESCTexto.ForeColor = Color.SeaGreen;
            lbESCTexto.Location = new Point(63, 80);
            lbESCTexto.Name = "lbESCTexto";
            lbESCTexto.Size = new Size(306, 40);
            lbESCTexto.TabIndex = 8;
            lbESCTexto.Text = "Cancelar pedido";
            lbESCTexto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuALTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1120, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuALTToolStripMenuItem
            // 
            menuALTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiCadastroCliente, tsmiCadastroFuncionario, tsmiCadastroFornecedor, tsmiCadastroProduto, toolStripSeparator1, tsmiPedidosEmAberto, tsmiManutencaoPedidos, toolStripSeparator2 });
            menuALTToolStripMenuItem.Name = "menuALTToolStripMenuItem";
            menuALTToolStripMenuItem.Size = new Size(116, 29);
            menuALTToolStripMenuItem.Text = "Menu (ALT)";
            // 
            // tsmiCadastroCliente
            // 
            tsmiCadastroCliente.Name = "tsmiCadastroCliente";
            tsmiCadastroCliente.Size = new Size(319, 34);
            tsmiCadastroCliente.Text = "Cadastro de clientes";
            tsmiCadastroCliente.Click += TsmiCadastroCliente_Click;
            // 
            // tsmiCadastroFuncionario
            // 
            tsmiCadastroFuncionario.Name = "tsmiCadastroFuncionario";
            tsmiCadastroFuncionario.Size = new Size(319, 34);
            tsmiCadastroFuncionario.Text = "Cadastro de funcionarios";
            tsmiCadastroFuncionario.Click += TsmiCadastroFuncionario_Click;
            // 
            // tsmiCadastroFornecedor
            // 
            tsmiCadastroFornecedor.Name = "tsmiCadastroFornecedor";
            tsmiCadastroFornecedor.Size = new Size(319, 34);
            tsmiCadastroFornecedor.Text = "Cadastro de fornecedores";
            tsmiCadastroFornecedor.Click += TsmiCadastroFornecedor_Click;
            // 
            // tsmiCadastroProduto
            // 
            tsmiCadastroProduto.Name = "tsmiCadastroProduto";
            tsmiCadastroProduto.Size = new Size(319, 34);
            tsmiCadastroProduto.Text = "Cadastro de produtos";
            tsmiCadastroProduto.Click += TsmiCadastroProduto_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(316, 6);
            // 
            // tsmiPedidosEmAberto
            // 
            tsmiPedidosEmAberto.Name = "tsmiPedidosEmAberto";
            tsmiPedidosEmAberto.Size = new Size(319, 34);
            tsmiPedidosEmAberto.Text = "Pedidos em aberto";
            tsmiPedidosEmAberto.Click += TsmiPedidosEmAberto_Click;
            // 
            // tsmiManutencaoPedidos
            // 
            tsmiManutencaoPedidos.Name = "tsmiManutencaoPedidos";
            tsmiManutencaoPedidos.Size = new Size(319, 34);
            tsmiManutencaoPedidos.Text = "Manutenção de vendas";
            tsmiManutencaoPedidos.Click += TsmiPedidoManutencao_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(316, 6);
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(txtBuscarPorNumeroPedido);
            groupBox4.ForeColor = Color.WhiteSmoke;
            groupBox4.Location = new Point(393, 41);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(715, 73);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Buscar por Nº do pedido";
            // 
            // txtBuscarPorNumeroPedido
            // 
            txtBuscarPorNumeroPedido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarPorNumeroPedido.Location = new Point(6, 30);
            txtBuscarPorNumeroPedido.Name = "txtBuscarPorNumeroPedido";
            txtBuscarPorNumeroPedido.Size = new Size(703, 31);
            txtBuscarPorNumeroPedido.TabIndex = 1;
            txtBuscarPorNumeroPedido.KeyPress += TxtBuscarPorNumeroPedido_KeyPress;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1120, 935);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(gbxItens);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(gbxNumero);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            ForeColor = Color.WhiteSmoke;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPedido";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pedido";
            WindowState = FormWindowState.Maximized;
            Load += FrmPedido_Load;
            KeyPress += FrmPedido_KeyPress;
            KeyUp += FrmPedido_KeyUp;
            gbxNumero.ResumeLayout(false);
            gbxNumero.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gbxItens.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            groupBox5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxNumero;
        private GroupBox groupBox1;
        private Label lbTotal;
        private GroupBox groupBox2;
        private TextBox txtCodBarrasCodRef;
        private GroupBox groupBox3;
        private TextBox txtQntd;
        private CheckBox chbxFiltrarCodRef;
        private GroupBox gbxItens;
        private DataGridView dgvItens;
        private Panel panel1;
        private GroupBox groupBox5;
        private Label lbF5Texto;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label10;
        private Label label5;
        private Label lbESCTexto;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnIndex;
        private DataGridViewTextBoxColumn clnCod;
        private DataGridViewTextBoxColumn clnCodBarrasCodRef;
        private DataGridViewTextBoxColumn cln;
        private DataGridViewTextBoxColumn clnUnd;
        private DataGridViewTextBoxColumn clnPrecoUnitario;
        private DataGridViewTextBoxColumn clnQntd;
        private DataGridViewTextBoxColumn clnTotal;
        private Label lbF7Texto;
        private Label lbF6Texto;
        private Label label8;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuALTToolStripMenuItem;
        private ToolStripMenuItem tsmiCadastroCliente;
        private ToolStripMenuItem tsmiCadastroFuncionario;
        private ToolStripMenuItem tsmiCadastroFornecedor;
        private ToolStripMenuItem tsmiCadastroProduto;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiPedidosEmAberto;
        private ToolStripMenuItem tsmiManutencaoPedidos;
        private Label lbTerminalNumero;
        private ToolStripSeparator toolStripSeparator2;
        private GroupBox groupBox4;
        private TextBox txtBuscarPorNumeroPedido;
    }
}