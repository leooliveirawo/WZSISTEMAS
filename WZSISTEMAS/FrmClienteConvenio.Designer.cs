namespace WZSISTEMAS;

partial class FrmClienteConvenio
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
        groupBox1 = new GroupBox();
        btnConsultar = new Button();
        label2 = new Label();
        txtNomeCompleto_RazaoSocial = new TextBox();
        label3 = new Label();
        txtCPF_CNPJ = new TextBox();
        groupBox2 = new GroupBox();
        lbValorTotal = new Label();
        lbFechamentoData = new Label();
        lbVencimentoData = new Label();
        panel1 = new Panel();
        dgvTitulos = new DataGridView();
        clnDataLancamento = new DataGridViewTextBoxColumn();
        clnValorTitulo = new DataGridViewTextBoxColumn();
        nmupAno = new NumericUpDown();
        label4 = new Label();
        cbbxMes = new ComboBox();
        label1 = new Label();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTitulos).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nmupAno).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBox1.Controls.Add(btnConsultar);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(txtNomeCompleto_RazaoSocial);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(txtCPF_CNPJ);
        groupBox1.ForeColor = Color.White;
        groupBox1.Location = new Point(8, 7);
        groupBox1.Margin = new Padding(2, 2, 2, 2);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(2, 2, 2, 2);
        groupBox1.Size = new Size(767, 59);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Dados do cliente";
        // 
        // btnConsultar
        // 
        btnConsultar.ForeColor = Color.Black;
        btnConsultar.Location = new Point(620, 33);
        btnConsultar.Margin = new Padding(2, 2, 2, 2);
        btnConsultar.Name = "btnConsultar";
        btnConsultar.Size = new Size(78, 20);
        btnConsultar.TabIndex = 10;
        btnConsultar.Text = "Consultar";
        btnConsultar.UseVisualStyleBackColor = true;
        btnConsultar.Click += BtnConsultar_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(5, 16);
        label2.Name = "label2";
        label2.Size = new Size(171, 15);
        label2.TabIndex = 6;
        label2.Text = "Nome completo/Razão social *";
        // 
        // txtNomeCompleto_RazaoSocial
        // 
        txtNomeCompleto_RazaoSocial.CharacterCasing = CharacterCasing.Upper;
        txtNomeCompleto_RazaoSocial.Enabled = false;
        txtNomeCompleto_RazaoSocial.ForeColor = Color.Black;
        txtNomeCompleto_RazaoSocial.Location = new Point(5, 34);
        txtNomeCompleto_RazaoSocial.Name = "txtNomeCompleto_RazaoSocial";
        txtNomeCompleto_RazaoSocial.Size = new Size(408, 23);
        txtNomeCompleto_RazaoSocial.TabIndex = 7;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(419, 16);
        label3.Name = "label3";
        label3.Size = new Size(68, 15);
        label3.TabIndex = 8;
        label3.Text = "CPF/CNPJ *";
        // 
        // txtCPF_CNPJ
        // 
        txtCPF_CNPJ.CharacterCasing = CharacterCasing.Upper;
        txtCPF_CNPJ.Enabled = false;
        txtCPF_CNPJ.ForeColor = Color.Black;
        txtCPF_CNPJ.Location = new Point(419, 34);
        txtCPF_CNPJ.Name = "txtCPF_CNPJ";
        txtCPF_CNPJ.Size = new Size(197, 23);
        txtCPF_CNPJ.TabIndex = 9;
        // 
        // groupBox2
        // 
        groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        groupBox2.Controls.Add(lbValorTotal);
        groupBox2.Controls.Add(lbFechamentoData);
        groupBox2.Controls.Add(lbVencimentoData);
        groupBox2.Controls.Add(panel1);
        groupBox2.Controls.Add(nmupAno);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(cbbxMes);
        groupBox2.Controls.Add(label1);
        groupBox2.ForeColor = Color.WhiteSmoke;
        groupBox2.Location = new Point(8, 70);
        groupBox2.Margin = new Padding(2, 2, 2, 2);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(2, 2, 2, 2);
        groupBox2.Size = new Size(767, 484);
        groupBox2.TabIndex = 6;
        groupBox2.TabStop = false;
        groupBox2.Text = "Vendas";
        // 
        // lbValorTotal
        // 
        lbValorTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbValorTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lbValorTotal.Location = new Point(4, 441);
        lbValorTotal.Name = "lbValorTotal";
        lbValorTotal.Size = new Size(757, 18);
        lbValorTotal.TabIndex = 18;
        lbValorTotal.Text = "Valor total (R$): {valor}";
        lbValorTotal.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbFechamentoData
        // 
        lbFechamentoData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lbFechamentoData.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lbFechamentoData.Location = new Point(5, 55);
        lbFechamentoData.Name = "lbFechamentoData";
        lbFechamentoData.Size = new Size(757, 18);
        lbFechamentoData.TabIndex = 17;
        lbFechamentoData.Text = "Fechamento em: {data}";
        lbFechamentoData.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbVencimentoData
        // 
        lbVencimentoData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lbVencimentoData.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lbVencimentoData.Location = new Point(4, 73);
        lbVencimentoData.Name = "lbVencimentoData";
        lbVencimentoData.Size = new Size(758, 18);
        lbVencimentoData.TabIndex = 16;
        lbVencimentoData.Text = "Vencimento em: {data}";
        lbVencimentoData.TextAlign = ContentAlignment.MiddleRight;
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panel1.Controls.Add(dgvTitulos);
        panel1.ForeColor = Color.Black;
        panel1.Location = new Point(4, 92);
        panel1.Margin = new Padding(2, 2, 2, 2);
        panel1.Name = "panel1";
        panel1.Size = new Size(758, 347);
        panel1.TabIndex = 15;
        // 
        // dgvTitulos
        // 
        dgvTitulos.AllowUserToAddRows = false;
        dgvTitulos.AllowUserToDeleteRows = false;
        dgvTitulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvTitulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTitulos.BackgroundColor = Color.Silver;
        dgvTitulos.BorderStyle = BorderStyle.None;
        dgvTitulos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.SteelBlue;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
        dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
        dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvTitulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvTitulos.ColumnHeadersHeight = 60;
        dgvTitulos.Columns.AddRange(new DataGridViewColumn[] { clnDataLancamento, clnValorTitulo });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = Color.Black;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvTitulos.DefaultCellStyle = dataGridViewCellStyle2;
        dgvTitulos.EnableHeadersVisualStyles = false;
        dgvTitulos.GridColor = Color.Silver;
        dgvTitulos.Location = new Point(0, 0);
        dgvTitulos.Margin = new Padding(2, 2, 2, 2);
        dgvTitulos.MultiSelect = false;
        dgvTitulos.Name = "dgvTitulos";
        dgvTitulos.ReadOnly = true;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Control;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvTitulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvTitulos.RowHeadersVisible = false;
        dgvTitulos.RowHeadersWidth = 62;
        dgvTitulos.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
        dgvTitulos.RowTemplate.Height = 45;
        dgvTitulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTitulos.Size = new Size(758, 347);
        dgvTitulos.TabIndex = 1;
        // 
        // clnDataLancamento
        // 
        clnDataLancamento.HeaderText = "Lançado em";
        clnDataLancamento.MinimumWidth = 8;
        clnDataLancamento.Name = "clnDataLancamento";
        clnDataLancamento.ReadOnly = true;
        // 
        // clnValorTitulo
        // 
        clnValorTitulo.HeaderText = "Valor (R$)";
        clnValorTitulo.MinimumWidth = 8;
        clnValorTitulo.Name = "clnValorTitulo";
        clnValorTitulo.ReadOnly = true;
        // 
        // nmupAno
        // 
        nmupAno.Location = new Point(257, 34);
        nmupAno.Margin = new Padding(2, 2, 2, 2);
        nmupAno.Name = "nmupAno";
        nmupAno.Size = new Size(136, 23);
        nmupAno.TabIndex = 14;
        nmupAno.ValueChanged += NmupAno_ValueChanged;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(256, 16);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(29, 15);
        label4.TabIndex = 13;
        label4.Text = "Ano";
        // 
        // cbbxMes
        // 
        cbbxMes.DropDownStyle = ComboBoxStyle.DropDownList;
        cbbxMes.FormattingEnabled = true;
        cbbxMes.Location = new Point(5, 33);
        cbbxMes.Margin = new Padding(2, 2, 2, 2);
        cbbxMes.Name = "cbbxMes";
        cbbxMes.Size = new Size(249, 23);
        cbbxMes.TabIndex = 12;
        cbbxMes.SelectedIndexChanged += CbbxMes_SelectedIndexChanged;
        cbbxMes.KeyDown += CbbxMes_KeyDown;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(4, 16);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(29, 15);
        label1.TabIndex = 11;
        label1.Text = "Mês";
        // 
        // FrmClienteConvenio
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.SeaGreen;
        ClientSize = new Size(784, 561);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        ForeColor = Color.WhiteSmoke;
        Margin = new Padding(2, 2, 2, 2);
        Name = "FrmClienteConvenio";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Convenio";
        Load += FrmClienteConvenio_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvTitulos).EndInit();
        ((System.ComponentModel.ISupportInitialize)nmupAno).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Button btnConsultar;
    private Label label2;
    private TextBox txtNomeCompleto_RazaoSocial;
    private Label label3;
    private TextBox txtCPF_CNPJ;
    private GroupBox groupBox2;
    private DataGridView dgvTitulos;
    private DataGridViewTextBoxColumn clnDataLancamento;
    private DataGridViewTextBoxColumn clnValorTitulo;
    private ComboBox cbbxMes;
    private Label label1;
    private NumericUpDown nmupAno;
    private Label label4;
    private Panel panel1;
    private Label lbVencimentoData;
    private Label lbFechamentoData;
    private Label lbValorTotal;
}