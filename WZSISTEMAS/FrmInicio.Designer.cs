﻿namespace WZSISTEMAS
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tsmiCadastros = new ToolStripMenuItem();
            tsmiCadastrosUsuarios = new ToolStripMenuItem();
            tsmiCadastrosFuncionarios = new ToolStripMenuItem();
            tsmiCadastrosFornecedores = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiCadastrosCargos = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tsmiCadastrosProdutos = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            empresasToolStripMenuItem = new ToolStripMenuItem();
            transportadorasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            convêniosToolStripMenuItem = new ToolStripMenuItem();
            tsmiEntrada = new ToolStripMenuItem();
            tsmiCaixa = new ToolStripMenuItem();
            tsmiUtilitarios = new ToolStripMenuItem();
            tsmiUtilitariosManutencaoVenda = new ToolStripMenuItem();
            tsmiPedidos = new ToolStripMenuItem();
            tsmiUtilitariosControleItens = new ToolStripMenuItem();
            tsmiFrenteCaixa = new ToolStripMenuItem();
            tsmiConfiguracoes = new ToolStripMenuItem();
            bancoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            terminalToolStripMenuItem = new ToolStripMenuItem();
            tsmiTrocarUsuario = new ToolStripMenuItem();
            btnCadastrosClientes = new Button();
            btnCadastrosFuncionarios = new Button();
            btnCadastrosCargos = new Button();
            groupBox1 = new GroupBox();
            btnCadastrosFornecedores = new Button();
            bntCadastrosProdutos = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiCadastros, tsmiEntrada, tsmiCaixa, tsmiUtilitarios, tsmiFrenteCaixa, tsmiConfiguracoes, tsmiTrocarUsuario });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiCadastros
            // 
            tsmiCadastros.DropDownItems.AddRange(new ToolStripItem[] { tsmiCadastrosUsuarios, tsmiCadastrosFuncionarios, tsmiCadastrosFornecedores, toolStripSeparator1, tsmiCadastrosCargos, toolStripSeparator2, tsmiCadastrosProdutos, toolStripSeparator3, empresasToolStripMenuItem, transportadorasToolStripMenuItem, toolStripSeparator4, convêniosToolStripMenuItem });
            tsmiCadastros.Name = "tsmiCadastros";
            tsmiCadastros.Size = new Size(71, 22);
            tsmiCadastros.Text = "Cadastros";
            // 
            // tsmiCadastrosUsuarios
            // 
            tsmiCadastrosUsuarios.Image = Properties.Resources.Clientes_16;
            tsmiCadastrosUsuarios.Name = "tsmiCadastrosUsuarios";
            tsmiCadastrosUsuarios.Size = new Size(158, 22);
            tsmiCadastrosUsuarios.Text = "Clientes";
            tsmiCadastrosUsuarios.Click += AbrirCadastrosClientes_Click;
            // 
            // tsmiCadastrosFuncionarios
            // 
            tsmiCadastrosFuncionarios.Image = Properties.Resources.Funcionarios_16;
            tsmiCadastrosFuncionarios.Name = "tsmiCadastrosFuncionarios";
            tsmiCadastrosFuncionarios.Size = new Size(158, 22);
            tsmiCadastrosFuncionarios.Text = "Funcionários";
            tsmiCadastrosFuncionarios.Click += AbrirCadastrosFuncionarios_Click;
            // 
            // tsmiCadastrosFornecedores
            // 
            tsmiCadastrosFornecedores.Image = Properties.Resources.Fornecedores_16;
            tsmiCadastrosFornecedores.Name = "tsmiCadastrosFornecedores";
            tsmiCadastrosFornecedores.Size = new Size(158, 22);
            tsmiCadastrosFornecedores.Text = "Fornecedores";
            tsmiCadastrosFornecedores.Click += AbrirCadastrosFornecedores_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(155, 6);
            // 
            // tsmiCadastrosCargos
            // 
            tsmiCadastrosCargos.Image = Properties.Resources.Cargos_16;
            tsmiCadastrosCargos.Name = "tsmiCadastrosCargos";
            tsmiCadastrosCargos.Size = new Size(158, 22);
            tsmiCadastrosCargos.Text = "Cargos";
            tsmiCadastrosCargos.Click += AbrirCadastrosCargos_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(155, 6);
            // 
            // tsmiCadastrosProdutos
            // 
            tsmiCadastrosProdutos.Image = Properties.Resources.Produtos_16;
            tsmiCadastrosProdutos.Name = "tsmiCadastrosProdutos";
            tsmiCadastrosProdutos.Size = new Size(158, 22);
            tsmiCadastrosProdutos.Text = "Produtos";
            tsmiCadastrosProdutos.Click += AbrirCadastrosProdutos_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(155, 6);
            // 
            // empresasToolStripMenuItem
            // 
            empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            empresasToolStripMenuItem.Size = new Size(158, 22);
            empresasToolStripMenuItem.Text = "Empresas";
            empresasToolStripMenuItem.Click += EmpresasToolStripMenuItem_Click;
            // 
            // transportadorasToolStripMenuItem
            // 
            transportadorasToolStripMenuItem.Name = "transportadorasToolStripMenuItem";
            transportadorasToolStripMenuItem.Size = new Size(158, 22);
            transportadorasToolStripMenuItem.Text = "Transportadoras";
            transportadorasToolStripMenuItem.Click += TransportadorasToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(155, 6);
            // 
            // convêniosToolStripMenuItem
            // 
            convêniosToolStripMenuItem.Name = "convêniosToolStripMenuItem";
            convêniosToolStripMenuItem.Size = new Size(158, 22);
            convêniosToolStripMenuItem.Text = "Convênios";
            convêniosToolStripMenuItem.Click += ConvêniosToolStripMenuItem_Click;
            // 
            // tsmiEntrada
            // 
            tsmiEntrada.Name = "tsmiEntrada";
            tsmiEntrada.Size = new Size(59, 22);
            tsmiEntrada.Text = "Entrada";
            tsmiEntrada.Click += EntradaToolStripMenuItem_Click;
            // 
            // tsmiCaixa
            // 
            tsmiCaixa.Name = "tsmiCaixa";
            tsmiCaixa.Size = new Size(48, 22);
            tsmiCaixa.Text = "Caixa";
            tsmiCaixa.Click += TsmiCaixa_Click;
            // 
            // tsmiUtilitarios
            // 
            tsmiUtilitarios.DropDownItems.AddRange(new ToolStripItem[] { tsmiUtilitariosManutencaoVenda, tsmiPedidos, tsmiUtilitariosControleItens });
            tsmiUtilitarios.Name = "tsmiUtilitarios";
            tsmiUtilitarios.Size = new Size(69, 22);
            tsmiUtilitarios.Text = "Utilitários";
            // 
            // tsmiUtilitariosManutencaoVenda
            // 
            tsmiUtilitariosManutencaoVenda.Name = "tsmiUtilitariosManutencaoVenda";
            tsmiUtilitariosManutencaoVenda.Size = new Size(197, 22);
            tsmiUtilitariosManutencaoVenda.Text = "Manutençao de Vendas";
            tsmiUtilitariosManutencaoVenda.Click += ManutencaoDeVendasToolStripMenuItem_Click;
            // 
            // tsmiPedidos
            // 
            tsmiPedidos.Name = "tsmiPedidos";
            tsmiPedidos.Size = new Size(197, 22);
            tsmiPedidos.Text = "Pedidos";
            tsmiPedidos.Click += TsmiPedidos_Click;
            // 
            // tsmiUtilitariosControleItens
            // 
            tsmiUtilitariosControleItens.Name = "tsmiUtilitariosControleItens";
            tsmiUtilitariosControleItens.Size = new Size(197, 22);
            tsmiUtilitariosControleItens.Text = "Controle de ítens";
            tsmiUtilitariosControleItens.Click += TsmiUtilitariosControleItens_Click;
            // 
            // tsmiFrenteCaixa
            // 
            tsmiFrenteCaixa.Name = "tsmiFrenteCaixa";
            tsmiFrenteCaixa.Size = new Size(98, 22);
            tsmiFrenteCaixa.Text = "Frente de caixa";
            tsmiFrenteCaixa.Click += TsmiFrenteCaixa_Click;
            // 
            // tsmiConfiguracoes
            // 
            tsmiConfiguracoes.DropDownItems.AddRange(new ToolStripItem[] { bancoDeDadosToolStripMenuItem, terminalToolStripMenuItem });
            tsmiConfiguracoes.Name = "tsmiConfiguracoes";
            tsmiConfiguracoes.Size = new Size(96, 22);
            tsmiConfiguracoes.Text = "Configurações";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            bancoDeDadosToolStripMenuItem.Size = new Size(158, 22);
            bancoDeDadosToolStripMenuItem.Text = "Banco de dados";
            bancoDeDadosToolStripMenuItem.Click += BancoDeDadosToolStripMenuItem_Click;
            // 
            // terminalToolStripMenuItem
            // 
            terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            terminalToolStripMenuItem.Size = new Size(158, 22);
            terminalToolStripMenuItem.Text = "Terminal";
            terminalToolStripMenuItem.Click += TerminalToolStripMenuItem_Click;
            // 
            // tsmiTrocarUsuario
            // 
            tsmiTrocarUsuario.Name = "tsmiTrocarUsuario";
            tsmiTrocarUsuario.Size = new Size(109, 22);
            tsmiTrocarUsuario.Text = "Trocar de usuário";
            tsmiTrocarUsuario.Click += TsmiTrocarUsuario_Click;
            // 
            // btnCadastrosClientes
            // 
            btnCadastrosClientes.Image = Properties.Resources.Clientes_64;
            btnCadastrosClientes.Location = new Point(4, 18);
            btnCadastrosClientes.Margin = new Padding(2, 2, 2, 2);
            btnCadastrosClientes.Name = "btnCadastrosClientes";
            btnCadastrosClientes.Size = new Size(90, 77);
            btnCadastrosClientes.TabIndex = 1;
            btnCadastrosClientes.Text = "Clientes";
            btnCadastrosClientes.TextAlign = ContentAlignment.BottomCenter;
            btnCadastrosClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCadastrosClientes.UseVisualStyleBackColor = true;
            btnCadastrosClientes.Click += AbrirCadastrosClientes_Click;
            // 
            // btnCadastrosFuncionarios
            // 
            btnCadastrosFuncionarios.Image = Properties.Resources.Funcionarios_64;
            btnCadastrosFuncionarios.Location = new Point(98, 18);
            btnCadastrosFuncionarios.Margin = new Padding(2, 2, 2, 2);
            btnCadastrosFuncionarios.Name = "btnCadastrosFuncionarios";
            btnCadastrosFuncionarios.Size = new Size(90, 77);
            btnCadastrosFuncionarios.TabIndex = 2;
            btnCadastrosFuncionarios.Text = "Funcionarios";
            btnCadastrosFuncionarios.TextAlign = ContentAlignment.BottomCenter;
            btnCadastrosFuncionarios.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCadastrosFuncionarios.UseVisualStyleBackColor = true;
            btnCadastrosFuncionarios.Click += AbrirCadastrosFuncionarios_Click;
            // 
            // btnCadastrosCargos
            // 
            btnCadastrosCargos.Image = Properties.Resources.Cargos_64;
            btnCadastrosCargos.Location = new Point(192, 18);
            btnCadastrosCargos.Margin = new Padding(2, 2, 2, 2);
            btnCadastrosCargos.Name = "btnCadastrosCargos";
            btnCadastrosCargos.Size = new Size(90, 77);
            btnCadastrosCargos.TabIndex = 3;
            btnCadastrosCargos.Text = "Cargos";
            btnCadastrosCargos.TextAlign = ContentAlignment.BottomCenter;
            btnCadastrosCargos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCadastrosCargos.UseVisualStyleBackColor = true;
            btnCadastrosCargos.Click += AbrirCadastrosCargos_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnCadastrosFornecedores);
            groupBox1.Controls.Add(bntCadastrosProdutos);
            groupBox1.Controls.Add(btnCadastrosClientes);
            groupBox1.Controls.Add(btnCadastrosCargos);
            groupBox1.Controls.Add(btnCadastrosFuncionarios);
            groupBox1.Location = new Point(8, 22);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(767, 104);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastros";
            // 
            // btnCadastrosFornecedores
            // 
            btnCadastrosFornecedores.Image = Properties.Resources.Fornecedores_64;
            btnCadastrosFornecedores.Location = new Point(286, 18);
            btnCadastrosFornecedores.Margin = new Padding(2, 2, 2, 2);
            btnCadastrosFornecedores.Name = "btnCadastrosFornecedores";
            btnCadastrosFornecedores.Size = new Size(90, 77);
            btnCadastrosFornecedores.TabIndex = 4;
            btnCadastrosFornecedores.Text = "Fornecedores";
            btnCadastrosFornecedores.TextAlign = ContentAlignment.BottomCenter;
            btnCadastrosFornecedores.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCadastrosFornecedores.UseVisualStyleBackColor = true;
            btnCadastrosFornecedores.Click += AbrirCadastrosFornecedores_Click;
            // 
            // bntCadastrosProdutos
            // 
            bntCadastrosProdutos.Image = Properties.Resources.Produtos_64;
            bntCadastrosProdutos.Location = new Point(379, 18);
            bntCadastrosProdutos.Margin = new Padding(2, 2, 2, 2);
            bntCadastrosProdutos.Name = "bntCadastrosProdutos";
            bntCadastrosProdutos.Size = new Size(90, 77);
            bntCadastrosProdutos.TabIndex = 5;
            bntCadastrosProdutos.Text = "Produtos";
            bntCadastrosProdutos.TextAlign = ContentAlignment.BottomCenter;
            bntCadastrosProdutos.TextImageRelation = TextImageRelation.ImageAboveText;
            bntCadastrosProdutos.UseVisualStyleBackColor = true;
            bntCadastrosProdutos.Click += AbrirCadastrosProdutos_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(1, 1, 1, 1);
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela inicial";
            WindowState = FormWindowState.Maximized;
            Load += FrmInicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiCadastros;
        private ToolStripMenuItem tsmiCadastrosUsuarios;
        private ToolStripMenuItem tsmiCadastrosFuncionarios;
        private ToolStripMenuItem tsmiCadastrosFornecedores;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiCadastrosCargos;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsmiCadastrosProdutos;
        private ToolStripMenuItem tsmiCaixa;
        private ToolStripMenuItem tsmiFrenteCaixa;
        private ToolStripMenuItem tsmiUtilitariosManutencaoVenda;
        private ToolStripMenuItem tsmiEntrada;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem empresasToolStripMenuItem;
        private ToolStripMenuItem tsmiConfiguracoes;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem terminalToolStripMenuItem;
        private ToolStripMenuItem transportadorasToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem convêniosToolStripMenuItem;
        private Button btnCadastrosClientes;
        private Button btnCadastrosFuncionarios;
        private Button btnCadastrosCargos;
        private GroupBox groupBox1;
        private Button bntCadastrosProdutos;
        private Button btnCadastrosFornecedores;
        private ToolStripMenuItem tsmiTrocarUsuario;
        private ToolStripMenuItem tsmiUtilitarios;
        private ToolStripMenuItem tsmiPedidos;
        private ToolStripMenuItem tsmiUtilitariosControleItens;
    }
}