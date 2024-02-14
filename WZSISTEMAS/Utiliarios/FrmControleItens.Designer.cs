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
        groupBox9 = new GroupBox();
        txtItemDerivadoPeso = new TextBox();
        groupBox8 = new GroupBox();
        dgvItensDerivadosCadastros = new DataGridView();
        clnId = new DataGridViewTextBoxColumn();
        clnDescricao = new DataGridViewTextBoxColumn();
        clnPecaPeso = new DataGridViewTextBoxColumn();
        clnPrecoFinal = new DataGridViewTextBoxColumn();
        groupBox7 = new GroupBox();
        txtItemDerivadoMargemLucro = new TextBox();
        groupBox6 = new GroupBox();
        txtItemDerivadoPrecoFinal = new TextBox();
        groupBox5 = new GroupBox();
        txtItemDerivadoCustoReal = new TextBox();
        groupBox4 = new GroupBox();
        txtItemDerivadoDescricao = new TextBox();
        btnItensDerivadosSalvar = new Button();
        groupBox11 = new GroupBox();
        btnItemPrincipalSelecionar = new Button();
        groupBox14 = new GroupBox();
        txtItemPrincipalCodBarrasCodRef = new TextBox();
        groupBox13 = new GroupBox();
        txtItemPrincipalId = new TextBox();
        groupBox10 = new GroupBox();
        txtItemPrincipalCustoKG = new TextBox();
        groupBox2 = new GroupBox();
        txtItemPrincipalValorTotal = new TextBox();
        groupBox12 = new GroupBox();
        txtItemPrincipalDescricao = new TextBox();
        groupBox1 = new GroupBox();
        txtItemPrincipalPeso = new TextBox();
        tabPage2 = new TabPage();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox9.SuspendLayout();
        groupBox8.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvItensDerivadosCadastros).BeginInit();
        groupBox7.SuspendLayout();
        groupBox6.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox11.SuspendLayout();
        groupBox14.SuspendLayout();
        groupBox13.SuspendLayout();
        groupBox10.SuspendLayout();
        groupBox2.SuspendLayout();
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
        groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        groupBox3.Controls.Add(groupBox9);
        groupBox3.Controls.Add(groupBox8);
        groupBox3.Controls.Add(groupBox7);
        groupBox3.Controls.Add(groupBox6);
        groupBox3.Controls.Add(groupBox5);
        groupBox3.Controls.Add(groupBox4);
        groupBox3.Controls.Add(btnItensDerivadosSalvar);
        groupBox3.Location = new Point(6, 203);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(1076, 664);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Itens derivados";
        // 
        // groupBox9
        // 
        groupBox9.Controls.Add(txtItemDerivadoPeso);
        groupBox9.Location = new Point(312, 30);
        groupBox9.Name = "groupBox9";
        groupBox9.Size = new Size(300, 71);
        groupBox9.TabIndex = 8;
        groupBox9.TabStop = false;
        groupBox9.Text = "Peso";
        // 
        // txtItemDerivadoPeso
        // 
        txtItemDerivadoPeso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemDerivadoPeso.Enabled = false;
        txtItemDerivadoPeso.Location = new Point(6, 30);
        txtItemDerivadoPeso.Name = "txtItemDerivadoPeso";
        txtItemDerivadoPeso.Size = new Size(388, 31);
        txtItemDerivadoPeso.TabIndex = 0;
        // 
        // groupBox8
        // 
        groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        groupBox8.Controls.Add(dgvItensDerivadosCadastros);
        groupBox8.Location = new Point(7, 226);
        groupBox8.Margin = new Padding(4, 5, 4, 5);
        groupBox8.Name = "groupBox8";
        groupBox8.Padding = new Padding(4, 5, 4, 5);
        groupBox8.Size = new Size(1062, 406);
        groupBox8.TabIndex = 6;
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
        dgvItensDerivadosCadastros.Columns.AddRange(new DataGridViewColumn[] { clnId, clnDescricao, clnPecaPeso, clnPrecoFinal });
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
        dgvItensDerivadosCadastros.Size = new Size(1054, 372);
        dgvItensDerivadosCadastros.TabIndex = 0;
        dgvItensDerivadosCadastros.CellDoubleClick += DgvCadastros_CellDoubleClick;
        // 
        // clnId
        // 
        clnId.HeaderText = "Id";
        clnId.MinimumWidth = 8;
        clnId.Name = "clnId";
        clnId.ReadOnly = true;
        // 
        // clnDescricao
        // 
        clnDescricao.HeaderText = "Descrição";
        clnDescricao.MinimumWidth = 8;
        clnDescricao.Name = "clnDescricao";
        clnDescricao.ReadOnly = true;
        // 
        // clnPecaPeso
        // 
        clnPecaPeso.HeaderText = "Peso";
        clnPecaPeso.MinimumWidth = 8;
        clnPecaPeso.Name = "clnPecaPeso";
        clnPecaPeso.ReadOnly = true;
        // 
        // clnPrecoFinal
        // 
        clnPrecoFinal.HeaderText = "Preço Final (R$)";
        clnPrecoFinal.MinimumWidth = 8;
        clnPrecoFinal.Name = "clnPrecoFinal";
        clnPrecoFinal.ReadOnly = true;
        // 
        // groupBox7
        // 
        groupBox7.Controls.Add(txtItemDerivadoMargemLucro);
        groupBox7.Location = new Point(312, 107);
        groupBox7.Name = "groupBox7";
        groupBox7.Size = new Size(300, 71);
        groupBox7.TabIndex = 4;
        groupBox7.TabStop = false;
        groupBox7.Text = "Margem de lucro (%)";
        // 
        // txtItemDerivadoMargemLucro
        // 
        txtItemDerivadoMargemLucro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemDerivadoMargemLucro.Enabled = false;
        txtItemDerivadoMargemLucro.Location = new Point(6, 30);
        txtItemDerivadoMargemLucro.Name = "txtItemDerivadoMargemLucro";
        txtItemDerivadoMargemLucro.Size = new Size(288, 31);
        txtItemDerivadoMargemLucro.TabIndex = 0;
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(txtItemDerivadoPrecoFinal);
        groupBox6.Location = new Point(618, 107);
        groupBox6.Name = "groupBox6";
        groupBox6.Size = new Size(300, 71);
        groupBox6.TabIndex = 4;
        groupBox6.TabStop = false;
        groupBox6.Text = "Preço final/kG (R$)";
        // 
        // txtItemDerivadoPrecoFinal
        // 
        txtItemDerivadoPrecoFinal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemDerivadoPrecoFinal.Enabled = false;
        txtItemDerivadoPrecoFinal.Location = new Point(6, 30);
        txtItemDerivadoPrecoFinal.Name = "txtItemDerivadoPrecoFinal";
        txtItemDerivadoPrecoFinal.Size = new Size(288, 31);
        txtItemDerivadoPrecoFinal.TabIndex = 0;
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(txtItemDerivadoCustoReal);
        groupBox5.Location = new Point(6, 107);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new Size(300, 71);
        groupBox5.TabIndex = 3;
        groupBox5.TabStop = false;
        groupBox5.Text = "Custo real/KG (R$)";
        // 
        // txtItemDerivadoCustoReal
        // 
        txtItemDerivadoCustoReal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemDerivadoCustoReal.Enabled = false;
        txtItemDerivadoCustoReal.Location = new Point(6, 30);
        txtItemDerivadoCustoReal.Name = "txtItemDerivadoCustoReal";
        txtItemDerivadoCustoReal.Size = new Size(288, 31);
        txtItemDerivadoCustoReal.TabIndex = 0;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(txtItemDerivadoDescricao);
        groupBox4.Location = new Point(6, 30);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(300, 71);
        groupBox4.TabIndex = 2;
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
        // btnItensDerivadosSalvar
        // 
        btnItensDerivadosSalvar.Location = new Point(6, 184);
        btnItensDerivadosSalvar.Name = "btnItensDerivadosSalvar";
        btnItensDerivadosSalvar.Size = new Size(112, 34);
        btnItensDerivadosSalvar.TabIndex = 7;
        btnItensDerivadosSalvar.Text = "Salvar";
        btnItensDerivadosSalvar.UseVisualStyleBackColor = true;
        btnItensDerivadosSalvar.Click += btnItemDerivadoSalvar_Click;
        // 
        // groupBox11
        // 
        groupBox11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBox11.Controls.Add(btnItemPrincipalSelecionar);
        groupBox11.Controls.Add(groupBox14);
        groupBox11.Controls.Add(groupBox13);
        groupBox11.Controls.Add(groupBox10);
        groupBox11.Controls.Add(groupBox2);
        groupBox11.Controls.Add(groupBox12);
        groupBox11.Controls.Add(groupBox1);
        groupBox11.Location = new Point(6, 6);
        groupBox11.Name = "groupBox11";
        groupBox11.Size = new Size(1079, 191);
        groupBox11.TabIndex = 4;
        groupBox11.TabStop = false;
        groupBox11.Text = "Item principal";
        // 
        // btnItemPrincipalSelecionar
        // 
        btnItemPrincipalSelecionar.Location = new Point(810, 58);
        btnItemPrincipalSelecionar.Name = "btnItemPrincipalSelecionar";
        btnItemPrincipalSelecionar.Size = new Size(112, 34);
        btnItemPrincipalSelecionar.TabIndex = 6;
        btnItemPrincipalSelecionar.Text = "Selecionar";
        btnItemPrincipalSelecionar.UseVisualStyleBackColor = true;
        btnItemPrincipalSelecionar.Click += btnItemPrincipalSelecionar_Click;
        // 
        // groupBox14
        // 
        groupBox14.Controls.Add(txtItemPrincipalCodBarrasCodRef);
        groupBox14.Location = new Point(207, 30);
        groupBox14.Name = "groupBox14";
        groupBox14.Size = new Size(195, 71);
        groupBox14.TabIndex = 5;
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
        groupBox13.TabIndex = 4;
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
        // groupBox10
        // 
        groupBox10.Controls.Add(txtItemPrincipalCustoKG);
        groupBox10.Location = new Point(207, 107);
        groupBox10.Name = "groupBox10";
        groupBox10.Size = new Size(195, 71);
        groupBox10.TabIndex = 3;
        groupBox10.TabStop = false;
        groupBox10.Text = "Custo/KG (R$)";
        // 
        // txtItemPrincipalCustoKG
        // 
        txtItemPrincipalCustoKG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemPrincipalCustoKG.Location = new Point(6, 30);
        txtItemPrincipalCustoKG.Name = "txtItemPrincipalCustoKG";
        txtItemPrincipalCustoKG.Size = new Size(178, 31);
        txtItemPrincipalCustoKG.TabIndex = 0;
        txtItemPrincipalCustoKG.Text = "0";
        txtItemPrincipalCustoKG.Leave += txtItemPrincipalCustoKG_Leave;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(txtItemPrincipalValorTotal);
        groupBox2.Location = new Point(408, 107);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(195, 71);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Valor total (R$)";
        // 
        // txtItemPrincipalValorTotal
        // 
        txtItemPrincipalValorTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemPrincipalValorTotal.Location = new Point(6, 30);
        txtItemPrincipalValorTotal.Name = "txtItemPrincipalValorTotal";
        txtItemPrincipalValorTotal.Size = new Size(183, 31);
        txtItemPrincipalValorTotal.TabIndex = 0;
        txtItemPrincipalValorTotal.Text = "0";
        txtItemPrincipalValorTotal.Leave += TxtValorTotal_Leave;
        // 
        // groupBox12
        // 
        groupBox12.Controls.Add(txtItemPrincipalDescricao);
        groupBox12.Location = new Point(408, 30);
        groupBox12.Name = "groupBox12";
        groupBox12.Size = new Size(396, 71);
        groupBox12.TabIndex = 1;
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
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Peso";
        // 
        // txtItemPrincipalPeso
        // 
        txtItemPrincipalPeso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtItemPrincipalPeso.Location = new Point(6, 30);
        txtItemPrincipalPeso.Name = "txtItemPrincipalPeso";
        txtItemPrincipalPeso.Size = new Size(183, 31);
        txtItemPrincipalPeso.TabIndex = 0;
        txtItemPrincipalPeso.Text = "0";
        txtItemPrincipalPeso.Leave += TxtPeso_Leave;
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
        groupBox14.ResumeLayout(false);
        groupBox14.PerformLayout();
        groupBox13.ResumeLayout(false);
        groupBox13.PerformLayout();
        groupBox10.ResumeLayout(false);
        groupBox10.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox12.ResumeLayout(false);
        groupBox12.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private GroupBox groupBox2;
    private TextBox txtItemPrincipalValorTotal;
    private GroupBox groupBox1;
    private TextBox txtItemPrincipalPeso;
    private TabPage tabPage2;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private TextBox txtItemDerivadoDescricao;
    private GroupBox groupBox7;
    private TextBox txtItemDerivadoMargemLucro;
    private GroupBox groupBox6;
    private TextBox txtItemDerivadoPrecoFinal;
    private GroupBox groupBox5;
    private TextBox txtItemDerivadoCustoReal;
    private GroupBox groupBox8;
    private DataGridView dgvItensDerivadosCadastros;
    private Button btnItensDerivadosSalvar;
    private GroupBox groupBox9;
    private TextBox txtItemDerivadoPeso;
    private DataGridViewTextBoxColumn clnId;
    private DataGridViewTextBoxColumn clnDescricao;
    private DataGridViewTextBoxColumn clnPecaPeso;
    private DataGridViewTextBoxColumn clnPrecoFinal;
    private GroupBox groupBox10;
    private TextBox txtItemPrincipalCustoKG;
    private GroupBox groupBox11;
    private Button btnItemPrincipalSelecionar;
    private GroupBox groupBox14;
    private TextBox txtItemPrincipalCodBarrasCodRef;
    private GroupBox groupBox13;
    private TextBox txtItemPrincipalId;
    private GroupBox groupBox12;
    private TextBox txtItemPrincipalDescricao;
}