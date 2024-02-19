namespace WZSISTEMAS.Utiliarios;

partial class FrmControleItens
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
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        groupBox3 = new GroupBox();
        txtItemPrincipalCustoRealFinal = new TextBox();
        groupBox10 = new GroupBox();
        txtItemPrincipalCustoRealKG = new TextBox();
        gbxItemDerivado = new GroupBox();
        btnItensDerivadosSalvar = new Button();
        groupBox9 = new GroupBox();
        txtItemDerivadoPeso = new TextBox();
        groupBox8 = new GroupBox();
        dgvItensDerivadosCadastros = new DataGridView();
        clnItemDerivadoId = new DataGridViewTextBoxColumn();
        clnItemDerivadoDescricao = new DataGridViewTextBoxColumn();
        clnItemDerivadoPeso = new DataGridViewTextBoxColumn();
        clnItemDerivadoMargemLucro = new DataGridViewTextBoxColumn();
        clnItemDerivadoPrecoFinalKG = new DataGridViewTextBoxColumn();
        groupBox7 = new GroupBox();
        txtItemDerivadoMargemLucro = new TextBox();
        groupBox6 = new GroupBox();
        txtItemDerivadoPrecoFinalKG = new TextBox();
        groupBox5 = new GroupBox();
        txtItemDerivadoCustoRealKG = new TextBox();
        groupBox4 = new GroupBox();
        txtItemDerivadoDescricao = new TextBox();
        groupBox11 = new GroupBox();
        groupBox2 = new GroupBox();
        txtItemPrincipalQuebra = new TextBox();
        groupBox15 = new GroupBox();
        txtItemPrincipalCustoReal = new TextBox();
        btnItemPrincipalSelecionar = new Button();
        groupBox14 = new GroupBox();
        txtItemPrincipalCodBarrasCodRef = new TextBox();
        groupBox13 = new GroupBox();
        txtItemPrincipalId = new TextBox();
        groupBox12 = new GroupBox();
        txtItemPrincipalDescricao = new TextBox();
        groupBox1 = new GroupBox();
        txtItemPrincipalPeso = new TextBox();
        tabPage2 = new TabPage();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox10.SuspendLayout();
        gbxItemDerivado.SuspendLayout();
        groupBox9.SuspendLayout();
        groupBox8.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvItensDerivadosCadastros).BeginInit();
        groupBox7.SuspendLayout();
        groupBox6.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox11.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox15.SuspendLayout();
        groupBox14.SuspendLayout();
        groupBox13.SuspendLayout();
        groupBox12.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Location = new Point(12, 12);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1096, 911);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(groupBox3);
        tabPage1.Controls.Add(groupBox10);
        tabPage1.Controls.Add(gbxItemDerivado);
        tabPage1.Controls.Add(groupBox11);
        tabPage1.Location = new Point(4, 34);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1088, 873);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Calcular derivações";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(txtItemPrincipalCustoRealFinal);
        groupBox3.Location = new Point(6, 196);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(195, 71);
        groupBox3.TabIndex = 7;
        groupBox3.TabStop = false;
        groupBox3.Text = "Custo real (Final) (R$)";
        // 
        // txtItemPrincipalCustoRealFinal
        // 
        txtItemPrincipalCustoRealFinal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemPrincipalCustoRealFinal.Location = new Point(6, 30);
        txtItemPrincipalCustoRealFinal.Name = "txtItemPrincipalCustoRealFinal";
        txtItemPrincipalCustoRealFinal.ReadOnly = true;
        txtItemPrincipalCustoRealFinal.Size = new Size(178, 31);
        txtItemPrincipalCustoRealFinal.TabIndex = 0;
        // 
        // groupBox10
        // 
        groupBox10.Controls.Add(txtItemPrincipalCustoRealKG);
        groupBox10.Location = new Point(207, 196);
        groupBox10.Name = "groupBox10";
        groupBox10.Size = new Size(195, 71);
        groupBox10.TabIndex = 8;
        groupBox10.TabStop = false;
        groupBox10.Text = "Custo real/KG (R$)";
        // 
        // txtItemPrincipalCustoRealKG
        // 
        txtItemPrincipalCustoRealKG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemPrincipalCustoRealKG.Enabled = false;
        txtItemPrincipalCustoRealKG.Location = new Point(6, 30);
        txtItemPrincipalCustoRealKG.Name = "txtItemPrincipalCustoRealKG";
        txtItemPrincipalCustoRealKG.ReadOnly = true;
        txtItemPrincipalCustoRealKG.Size = new Size(178, 31);
        txtItemPrincipalCustoRealKG.TabIndex = 0;
        // 
        // gbxItemDerivado
        // 
        gbxItemDerivado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gbxItemDerivado.Controls.Add(btnItensDerivadosSalvar);
        gbxItemDerivado.Controls.Add(groupBox9);
        gbxItemDerivado.Controls.Add(groupBox8);
        gbxItemDerivado.Controls.Add(groupBox7);
        gbxItemDerivado.Controls.Add(groupBox6);
        gbxItemDerivado.Controls.Add(groupBox5);
        gbxItemDerivado.Controls.Add(groupBox4);
        gbxItemDerivado.Enabled = false;
        gbxItemDerivado.Location = new Point(6, 288);
        gbxItemDerivado.Name = "gbxItemDerivado";
        gbxItemDerivado.Size = new Size(1076, 579);
        gbxItemDerivado.TabIndex = 1;
        gbxItemDerivado.TabStop = false;
        gbxItemDerivado.Text = "Itens derivados";
        // 
        // btnItensDerivadosSalvar
        // 
        btnItensDerivadosSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnItensDerivadosSalvar.Location = new Point(964, 539);
        btnItensDerivadosSalvar.Name = "btnItensDerivadosSalvar";
        btnItensDerivadosSalvar.Size = new Size(112, 34);
        btnItensDerivadosSalvar.TabIndex = 8;
        btnItensDerivadosSalvar.Text = "Salvar";
        btnItensDerivadosSalvar.UseVisualStyleBackColor = true;
        btnItensDerivadosSalvar.Click += btnItensDerivadosSalvar_Click;
        // 
        // groupBox9
        // 
        groupBox9.Controls.Add(txtItemDerivadoPeso);
        groupBox9.Location = new Point(312, 30);
        groupBox9.Name = "groupBox9";
        groupBox9.Size = new Size(195, 71);
        groupBox9.TabIndex = 1;
        groupBox9.TabStop = false;
        groupBox9.Text = "Peso";
        // 
        // txtItemDerivadoPeso
        // 
        txtItemDerivadoPeso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemDerivadoPeso.Enabled = false;
        txtItemDerivadoPeso.Location = new Point(6, 30);
        txtItemDerivadoPeso.Name = "txtItemDerivadoPeso";
        txtItemDerivadoPeso.Size = new Size(183, 31);
        txtItemDerivadoPeso.TabIndex = 0;
        txtItemDerivadoPeso.Leave += TxtItemDerivadoPeso_Leave;
        // 
        // groupBox8
        // 
        groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        groupBox8.Controls.Add(dgvItensDerivadosCadastros);
        groupBox8.Location = new Point(7, 186);
        groupBox8.Margin = new Padding(4, 5, 4, 5);
        groupBox8.Name = "groupBox8";
        groupBox8.Padding = new Padding(4, 5, 4, 5);
        groupBox8.Size = new Size(1062, 345);
        groupBox8.TabIndex = 7;
        groupBox8.TabStop = false;
        groupBox8.Text = "Itens";
        // 
        // dgvItensDerivadosCadastros
        // 
        dgvItensDerivadosCadastros.AllowUserToAddRows = false;
        dgvItensDerivadosCadastros.AllowUserToDeleteRows = false;
        dgvItensDerivadosCadastros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvItensDerivadosCadastros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        dgvItensDerivadosCadastros.ColumnHeadersHeight = 65;
        dgvItensDerivadosCadastros.Columns.AddRange(new DataGridViewColumn[] { clnItemDerivadoId, clnItemDerivadoDescricao, clnItemDerivadoPeso, clnItemDerivadoMargemLucro, clnItemDerivadoPrecoFinalKG });
        dgvItensDerivadosCadastros.Dock = DockStyle.Fill;
        dgvItensDerivadosCadastros.Location = new Point(4, 29);
        dgvItensDerivadosCadastros.Margin = new Padding(4, 5, 4, 5);
        dgvItensDerivadosCadastros.MultiSelect = false;
        dgvItensDerivadosCadastros.Name = "dgvItensDerivadosCadastros";
        dgvItensDerivadosCadastros.ReadOnly = true;
        dgvItensDerivadosCadastros.RowHeadersVisible = false;
        dgvItensDerivadosCadastros.RowHeadersWidth = 62;
        dgvItensDerivadosCadastros.RowTemplate.Height = 32;
        dgvItensDerivadosCadastros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvItensDerivadosCadastros.Size = new Size(1054, 311);
        dgvItensDerivadosCadastros.TabIndex = 0;
        dgvItensDerivadosCadastros.CellDoubleClick += DgvCadastros_CellDoubleClick;
        // 
        // clnItemDerivadoId
        // 
        clnItemDerivadoId.HeaderText = "Id";
        clnItemDerivadoId.MinimumWidth = 8;
        clnItemDerivadoId.Name = "clnItemDerivadoId";
        clnItemDerivadoId.ReadOnly = true;
        // 
        // clnItemDerivadoDescricao
        // 
        clnItemDerivadoDescricao.HeaderText = "Descrição";
        clnItemDerivadoDescricao.MinimumWidth = 8;
        clnItemDerivadoDescricao.Name = "clnItemDerivadoDescricao";
        clnItemDerivadoDescricao.ReadOnly = true;
        // 
        // clnItemDerivadoPeso
        // 
        clnItemDerivadoPeso.HeaderText = "Peso";
        clnItemDerivadoPeso.MinimumWidth = 8;
        clnItemDerivadoPeso.Name = "clnItemDerivadoPeso";
        clnItemDerivadoPeso.ReadOnly = true;
        // 
        // clnItemDerivadoMargemLucro
        // 
        clnItemDerivadoMargemLucro.HeaderText = "Margem de lucro (%)";
        clnItemDerivadoMargemLucro.MinimumWidth = 8;
        clnItemDerivadoMargemLucro.Name = "clnItemDerivadoMargemLucro";
        clnItemDerivadoMargemLucro.ReadOnly = true;
        // 
        // clnItemDerivadoPrecoFinalKG
        // 
        clnItemDerivadoPrecoFinalKG.HeaderText = "Preço final/KG (R$)";
        clnItemDerivadoPrecoFinalKG.MinimumWidth = 8;
        clnItemDerivadoPrecoFinalKG.Name = "clnItemDerivadoPrecoFinalKG";
        clnItemDerivadoPrecoFinalKG.ReadOnly = true;
        // 
        // groupBox7
        // 
        groupBox7.Controls.Add(txtItemDerivadoMargemLucro);
        groupBox7.Location = new Point(513, 30);
        groupBox7.Name = "groupBox7";
        groupBox7.Size = new Size(195, 71);
        groupBox7.TabIndex = 2;
        groupBox7.TabStop = false;
        groupBox7.Text = "Margem de lucro (%)";
        // 
        // txtItemDerivadoMargemLucro
        // 
        txtItemDerivadoMargemLucro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemDerivadoMargemLucro.Enabled = false;
        txtItemDerivadoMargemLucro.Location = new Point(6, 30);
        txtItemDerivadoMargemLucro.Name = "txtItemDerivadoMargemLucro";
        txtItemDerivadoMargemLucro.Size = new Size(183, 31);
        txtItemDerivadoMargemLucro.TabIndex = 0;
        txtItemDerivadoMargemLucro.TextChanged += txtItemDerivadoMargemLucro_TextChanged;
        txtItemDerivadoMargemLucro.Leave += TxtItemDerivadoMargemLucro_Leave;
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(txtItemDerivadoPrecoFinalKG);
        groupBox6.Location = new Point(207, 107);
        groupBox6.Name = "groupBox6";
        groupBox6.Size = new Size(195, 71);
        groupBox6.TabIndex = 5;
        groupBox6.TabStop = false;
        groupBox6.Text = "Preço final/KG (R$)";
        // 
        // txtItemDerivadoPrecoFinalKG
        // 
        txtItemDerivadoPrecoFinalKG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemDerivadoPrecoFinalKG.Enabled = false;
        txtItemDerivadoPrecoFinalKG.Location = new Point(6, 30);
        txtItemDerivadoPrecoFinalKG.Name = "txtItemDerivadoPrecoFinalKG";
        txtItemDerivadoPrecoFinalKG.Size = new Size(183, 31);
        txtItemDerivadoPrecoFinalKG.TabIndex = 0;
        txtItemDerivadoPrecoFinalKG.Leave += TxtItemDerivadoPrecoFinalKG_Leave;
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(txtItemDerivadoCustoRealKG);
        groupBox5.Location = new Point(6, 107);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new Size(195, 71);
        groupBox5.TabIndex = 4;
        groupBox5.TabStop = false;
        groupBox5.Text = "Custo real/KG (R$)";
        // 
        // txtItemDerivadoCustoRealKG
        // 
        txtItemDerivadoCustoRealKG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemDerivadoCustoRealKG.Location = new Point(6, 30);
        txtItemDerivadoCustoRealKG.Name = "txtItemDerivadoCustoRealKG";
        txtItemDerivadoCustoRealKG.ReadOnly = true;
        txtItemDerivadoCustoRealKG.Size = new Size(183, 31);
        txtItemDerivadoCustoRealKG.TabIndex = 0;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(txtItemDerivadoDescricao);
        groupBox4.Location = new Point(6, 30);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(300, 71);
        groupBox4.TabIndex = 0;
        groupBox4.TabStop = false;
        groupBox4.Text = "Descrição";
        // 
        // txtItemDerivadoDescricao
        // 
        txtItemDerivadoDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemDerivadoDescricao.Location = new Point(6, 30);
        txtItemDerivadoDescricao.Name = "txtItemDerivadoDescricao";
        txtItemDerivadoDescricao.ReadOnly = true;
        txtItemDerivadoDescricao.Size = new Size(288, 31);
        txtItemDerivadoDescricao.TabIndex = 0;
        // 
        // groupBox11
        // 
        groupBox11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBox11.Controls.Add(groupBox2);
        groupBox11.Controls.Add(groupBox15);
        groupBox11.Controls.Add(btnItemPrincipalSelecionar);
        groupBox11.Controls.Add(groupBox14);
        groupBox11.Controls.Add(groupBox13);
        groupBox11.Controls.Add(groupBox12);
        groupBox11.Controls.Add(groupBox1);
        groupBox11.Location = new Point(6, 6);
        groupBox11.Name = "groupBox11";
        groupBox11.Size = new Size(1079, 184);
        groupBox11.TabIndex = 0;
        groupBox11.TabStop = false;
        groupBox11.Text = "Item principal";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(txtItemPrincipalQuebra);
        groupBox2.Location = new Point(207, 107);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(195, 71);
        groupBox2.TabIndex = 5;
        groupBox2.TabStop = false;
        groupBox2.Text = "Peso (Quebra) (KG)";
        // 
        // txtItemPrincipalQuebra
        // 
        txtItemPrincipalQuebra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemPrincipalQuebra.Enabled = false;
        txtItemPrincipalQuebra.Location = new Point(6, 30);
        txtItemPrincipalQuebra.Name = "txtItemPrincipalQuebra";
        txtItemPrincipalQuebra.Size = new Size(178, 31);
        txtItemPrincipalQuebra.TabIndex = 0;
        txtItemPrincipalQuebra.Leave += TxtItemPrincipalQuebra_Leave;
        // 
        // groupBox15
        // 
        groupBox15.Controls.Add(txtItemPrincipalCustoReal);
        groupBox15.Location = new Point(408, 107);
        groupBox15.Name = "groupBox15";
        groupBox15.Size = new Size(195, 71);
        groupBox15.TabIndex = 6;
        groupBox15.TabStop = false;
        groupBox15.Text = "Custo real (R$)";
        // 
        // txtItemPrincipalCustoReal
        // 
        txtItemPrincipalCustoReal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemPrincipalCustoReal.Enabled = false;
        txtItemPrincipalCustoReal.Location = new Point(6, 30);
        txtItemPrincipalCustoReal.Name = "txtItemPrincipalCustoReal";
        txtItemPrincipalCustoReal.Size = new Size(173, 31);
        txtItemPrincipalCustoReal.TabIndex = 0;
        txtItemPrincipalCustoReal.Leave += TxtItemPrincipalCustoReal_Leave;
        // 
        // btnItemPrincipalSelecionar
        // 
        btnItemPrincipalSelecionar.Location = new Point(810, 58);
        btnItemPrincipalSelecionar.Name = "btnItemPrincipalSelecionar";
        btnItemPrincipalSelecionar.Size = new Size(112, 34);
        btnItemPrincipalSelecionar.TabIndex = 0;
        btnItemPrincipalSelecionar.Text = "Selecionar";
        btnItemPrincipalSelecionar.UseVisualStyleBackColor = true;
        btnItemPrincipalSelecionar.Click += BtnItemPrincipalSelecionar_Click;
        // 
        // groupBox14
        // 
        groupBox14.Controls.Add(txtItemPrincipalCodBarrasCodRef);
        groupBox14.Location = new Point(207, 30);
        groupBox14.Name = "groupBox14";
        groupBox14.Size = new Size(195, 71);
        groupBox14.TabIndex = 2;
        groupBox14.TabStop = false;
        groupBox14.Text = "Cod.Barras (Cod.Ref)";
        // 
        // txtItemPrincipalCodBarrasCodRef
        // 
        txtItemPrincipalCodBarrasCodRef.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemPrincipalCodBarrasCodRef.Location = new Point(6, 30);
        txtItemPrincipalCodBarrasCodRef.Name = "txtItemPrincipalCodBarrasCodRef";
        txtItemPrincipalCodBarrasCodRef.ReadOnly = true;
        txtItemPrincipalCodBarrasCodRef.Size = new Size(173, 31);
        txtItemPrincipalCodBarrasCodRef.TabIndex = 0;
        // 
        // groupBox13
        // 
        groupBox13.Controls.Add(txtItemPrincipalId);
        groupBox13.Location = new Point(6, 30);
        groupBox13.Name = "groupBox13";
        groupBox13.Size = new Size(195, 71);
        groupBox13.TabIndex = 1;
        groupBox13.TabStop = false;
        groupBox13.Text = "Id";
        // 
        // txtItemPrincipalId
        // 
        txtItemPrincipalId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemPrincipalId.Location = new Point(6, 30);
        txtItemPrincipalId.Name = "txtItemPrincipalId";
        txtItemPrincipalId.ReadOnly = true;
        txtItemPrincipalId.Size = new Size(178, 31);
        txtItemPrincipalId.TabIndex = 0;
        // 
        // groupBox12
        // 
        groupBox12.Controls.Add(txtItemPrincipalDescricao);
        groupBox12.Location = new Point(408, 30);
        groupBox12.Name = "groupBox12";
        groupBox12.Size = new Size(396, 71);
        groupBox12.TabIndex = 3;
        groupBox12.TabStop = false;
        groupBox12.Text = "Descrição";
        // 
        // txtItemPrincipalDescricao
        // 
        txtItemPrincipalDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemPrincipalDescricao.Location = new Point(6, 30);
        txtItemPrincipalDescricao.Name = "txtItemPrincipalDescricao";
        txtItemPrincipalDescricao.ReadOnly = true;
        txtItemPrincipalDescricao.Size = new Size(379, 31);
        txtItemPrincipalDescricao.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txtItemPrincipalPeso);
        groupBox1.Location = new Point(6, 107);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(195, 71);
        groupBox1.TabIndex = 4;
        groupBox1.TabStop = false;
        groupBox1.Text = "Peso (KG)";
        // 
        // txtItemPrincipalPeso
        // 
        txtItemPrincipalPeso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemPrincipalPeso.Enabled = false;
        txtItemPrincipalPeso.Location = new Point(6, 30);
        txtItemPrincipalPeso.Name = "txtItemPrincipalPeso";
        txtItemPrincipalPeso.Size = new Size(183, 31);
        txtItemPrincipalPeso.TabIndex = 0;
        txtItemPrincipalPeso.Leave += TxtItemPrincipalPeso_Leave;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 34);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(1088, 873);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "tabPage2";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // FrmControleItens
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1120, 935);
        Controls.Add(tabControl1);
        DoubleBuffered = true;
        Name = "FrmControleItens";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Controle de ítens";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox10.ResumeLayout(false);
        groupBox10.PerformLayout();
        gbxItemDerivado.ResumeLayout(false);
        groupBox9.ResumeLayout(false);
        groupBox9.PerformLayout();
        groupBox8.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvItensDerivadosCadastros).EndInit();
        groupBox7.ResumeLayout(false);
        groupBox7.PerformLayout();
        groupBox6.ResumeLayout(false);
        groupBox6.PerformLayout();
        groupBox5.ResumeLayout(false);
        groupBox5.PerformLayout();
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        groupBox11.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox15.ResumeLayout(false);
        groupBox15.PerformLayout();
        groupBox14.ResumeLayout(false);
        groupBox14.PerformLayout();
        groupBox13.ResumeLayout(false);
        groupBox13.PerformLayout();
        groupBox12.ResumeLayout(false);
        groupBox12.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private GroupBox groupBox1;
    private TextBox txtItemPrincipalPeso;
    private TabPage tabPage2;
    private GroupBox gbxItemDerivado;
    private GroupBox groupBox4;
    private TextBox txtItemDerivadoDescricao;
    private GroupBox groupBox7;
    private TextBox txtItemDerivadoMargemLucro;
    private GroupBox groupBox6;
    private TextBox txtItemDerivadoPrecoFinalKG;
    private GroupBox groupBox5;
    private TextBox txtItemDerivadoCustoRealKG;
    private GroupBox groupBox8;
    private DataGridView dgvItensDerivadosCadastros;
    private GroupBox groupBox9;
    private TextBox txtItemDerivadoPeso;
    private GroupBox groupBox10;
    private TextBox txtItemPrincipalCustoRealKG;
    private GroupBox groupBox11;
    private Button btnItemPrincipalSelecionar;
    private GroupBox groupBox14;
    private TextBox txtItemPrincipalCodBarrasCodRef;
    private GroupBox groupBox13;
    private TextBox txtItemPrincipalId;
    private GroupBox groupBox12;
    private TextBox txtItemPrincipalDescricao;
    private GroupBox groupBox15;
    private TextBox txtItemPrincipalCustoReal;
    private DataGridViewTextBoxColumn clnItemDerivadoId;
    private DataGridViewTextBoxColumn clnItemDerivadoDescricao;
    private DataGridViewTextBoxColumn clnItemDerivadoPeso;
    private DataGridViewTextBoxColumn clnItemDerivadoMargemLucro;
    private DataGridViewTextBoxColumn clnItemDerivadoPrecoFinalKG;
    private Button btnItensDerivadosSalvar;
    private GroupBox groupBox3;
    private TextBox txtItemPrincipalCustoRealFinal;
    private GroupBox groupBox2;
    private TextBox txtItemPrincipalQuebra;
}