namespace WZSISTEMAS.Cadastros
{
    partial class FrmCadastroCargos
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
            btnNovo = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            btnEditar = new Button();
            gbxConsulta = new GroupBox();
            txtBuscarPorNome = new TextBox();
            btnCancelar = new Button();
            gbxDados = new GroupBox();
            txtDescricao = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            gbxCadastros = new GroupBox();
            dgvCadastros = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            gbxConsulta.SuspendLayout();
            gbxDados.SuspendLayout();
            gbxCadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCadastros).BeginInit();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.Location = new Point(291, 527);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 10;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += BtnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Location = new Point(534, 527);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.Location = new Point(454, 527);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoltar.Location = new Point(697, 527);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += BtnVoltar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.Location = new Point(373, 527);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += BtnEditar_Click;
            // 
            // gbxConsulta
            // 
            gbxConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxConsulta.Controls.Add(txtBuscarPorNome);
            gbxConsulta.Location = new Point(12, 12);
            gbxConsulta.Name = "gbxConsulta";
            gbxConsulta.Size = new Size(760, 64);
            gbxConsulta.TabIndex = 7;
            gbxConsulta.TabStop = false;
            gbxConsulta.Text = "Buscar por nome";
            // 
            // txtBuscarPorNome
            // 
            txtBuscarPorNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarPorNome.Location = new Point(6, 22);
            txtBuscarPorNome.Name = "txtBuscarPorNome";
            txtBuscarPorNome.Size = new Size(748, 23);
            txtBuscarPorNome.TabIndex = 0;
            txtBuscarPorNome.KeyPress += TxtBuscarPorNome_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(616, 527);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // gbxDados
            // 
            gbxDados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxDados.Controls.Add(txtDescricao);
            gbxDados.Controls.Add(label3);
            gbxDados.Controls.Add(txtNome);
            gbxDados.Controls.Add(label2);
            gbxDados.Location = new Point(12, 415);
            gbxDados.Name = "gbxDados";
            gbxDados.Size = new Size(760, 106);
            gbxDados.TabIndex = 9;
            gbxDados.TabStop = false;
            gbxDados.Text = "Dados do cargo";
            // 
            // txtDescricao
            // 
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
            txtDescricao.Location = new Point(6, 81);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(408, 23);
            txtDescricao.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição";
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Location = new Point(6, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(408, 23);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome*";
            // 
            // gbxCadastros
            // 
            gbxCadastros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxCadastros.Controls.Add(dgvCadastros);
            gbxCadastros.Location = new Point(12, 65);
            gbxCadastros.Name = "gbxCadastros";
            gbxCadastros.Size = new Size(760, 344);
            gbxCadastros.TabIndex = 8;
            gbxCadastros.TabStop = false;
            gbxCadastros.Text = "Cadastros";
            // 
            // dgvCadastros
            // 
            dgvCadastros.AllowUserToAddRows = false;
            dgvCadastros.AllowUserToDeleteRows = false;
            dgvCadastros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCadastros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvCadastros.ColumnHeadersHeight = 45;
            dgvCadastros.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome });
            dgvCadastros.Dock = DockStyle.Fill;
            dgvCadastros.Location = new Point(3, 19);
            dgvCadastros.MultiSelect = false;
            dgvCadastros.Name = "dgvCadastros";
            dgvCadastros.ReadOnly = true;
            dgvCadastros.RowHeadersVisible = false;
            dgvCadastros.RowHeadersWidth = 62;
            dgvCadastros.RowTemplate.Height = 32;
            dgvCadastros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCadastros.Size = new Size(754, 322);
            dgvCadastros.TabIndex = 0;
            dgvCadastros.SelectionChanged += DgvCadastros_SelectionChanged;
            // 
            // clnId
            // 
            clnId.HeaderText = "Id";
            clnId.MinimumWidth = 8;
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.MinimumWidth = 8;
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            // 
            // FrmCadastroCargos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(gbxCadastros);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(btnEditar);
            Controls.Add(gbxConsulta);
            Controls.Add(btnCancelar);
            Controls.Add(gbxDados);
            DoubleBuffered = true;
            Name = "FrmCadastroCargos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cargo";
            Load += FrmCadastroCargos_Load;
            gbxConsulta.ResumeLayout(false);
            gbxConsulta.PerformLayout();
            gbxDados.ResumeLayout(false);
            gbxDados.PerformLayout();
            gbxCadastros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCadastros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovo;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnVoltar;
        private Button btnEditar;
        private GroupBox gbxConsulta;
        private TextBox txtBuscarPorNome;
        private Button btnCancelar;
        private GroupBox gbxDados;
        private TextBox txtDescricao;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private GroupBox gbxCadastros;
        private DataGridView dgvCadastros;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
    }
}