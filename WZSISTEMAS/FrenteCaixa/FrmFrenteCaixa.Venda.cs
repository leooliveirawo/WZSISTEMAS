namespace WZSISTEMAS.FrenteCaixa;

public partial class FrmFrenteCaixa
{
    private void AbrirVendasEspera()
    {
        if (venda is null)
        {
            using var frm = ExibirFrenteCaixaEmEspera();

            if (frm.Concluiu)
            {
                venda = frm.Venda
                        ?? throw new InvalidOperationException("Um erro interno ocorreu no sistema");

                CarregarVenda();
            }
        }
    }

    private void RecalcularVendaTotal()
        => lbTotal.Text = $"{venda?.ValorTotal:C2}";

    private void RedefinirTelaVenda()
    {
        gbxNumero.Text = "Venda Nº";
        lbTotal.Text = $"{0:C2}";

        lbCPF_CNPJ.Clear("NÃO INFORMADO");

        RedefinirCamposConsulta();

        dgvItens.Rows.Clear();
    }

    private void CarregarVenda()
    {
        lbTotal.Text =
            $"{venda?.ValorTotal ?? throw new InvalidOperationException("Um erro interno aconteceu durante a venda"):C2}";

        gbxNumero.Text = $"Nº da Venda: {venda.Id}";

        DefinirCPFOuCNPJVenda();

        dgvItens.Rows.Clear();

        foreach (var item in venda.Itens)
            AdicionarItemVenda(item);

        dgvItens.SelecionarUltimaLinha();
    }

    private void AdicionarItemVenda(VendaItem item)
    {
        var count = dgvItens.Rows.GetRowCount(DataGridViewElementStates.Visible) + 1;

        dgvItens.Adicionar(
            item.Id,
            count,
            $"{item.ItemId:0000000}",
            item.CodigoBarrasCodigoReferencia(),
            item.DescricaoFormatada(),
            item.UnidadeMedida.ConverterParaString(true),
            $"{item.ValorUnitario:C2}",
            $"{item.Quantidade:0.000}",
            $"{item.ValorTotal:C2}");
    }

    private void RedefinirParametrosVenda()
        => venda = default;

    private void InformarCPFOuCNPJNaNotaVenda()
    {
        if (venda is not null)
        {
            using var frm = ProvedorServicos.FrmFrenteCaixaCPF_CNPJNaNota();

            frm.DefinirCPF_CNPJ(venda.CPF_CNPJ_Nota);

            if (frm.ShowDialog(this, DialogResult.OK))
            {
                venda = servicoVendas.ObterPorId(
                            venda.Id,
                            true)
                        ?? throw new InvalidOperationException("A venda não foi encontrada");

                venda.CPF_CNPJ_Nota = frm.CPF_CNPJ;

                servicoVendas.Editar(venda);

                servicoVendas.SalvarAlteracoes();

                servicoVendas.DescartarAlteracoes();

                DefinirCPFOuCNPJVenda();

                txtCodBarrasCodRef.Selecionar();
            }
        }
    }

    private void CancelarVenda()
    {
        if (venda is not null)
        {
            if (this.ExibirMensagemSimNao("Tem certeza que deseja cancelar a venda?", "Confirmar cancelamento"))
            {
                try
                {
                    servicoVendas.CancelarVenda(venda.Id);

                    RedefinirParametrosVenda();

                    RedefinirTelaVenda();

                    this.ExibirMensagemOperacaoConcluida("A venda foi cancelada com sucesso.");
                }
                catch (Exception erro)
                {
                    this.ExibirMensagemErro(erro);
                }
                finally
                {
                    txtCodBarrasCodRef.Selecionar();
                }
            }
        }
        else
            Close();
    }

    private void AcoesVenda(KeyEventArgs e)
    {
        if (e.KeyData == Keys.F4)
            ExcluirItemVenda();
        else if (e.KeyData == Keys.F5)
            FecharVenda();
        else if (e.KeyData == Keys.F6)
            ColocarEmEsperaVenda();
        else if (e.KeyData == Keys.F7)
            AbrirVendasEspera();
        else if (e.KeyData == Keys.F3)
            InformarCPFOuCNPJNaNotaVenda();
        else if (e.KeyData == Keys.F8)
        {
            naoSelecionar = true;
            dgvItens.Selecionar();
        }
        else if (e.KeyData != Keys.F2)
            naoSelecionar = true;
    }

    private void ExcluirItemVenda()
    {
        if (dgvItens.ExisteLinhasSelecionadas()
            && this.ExibirMensagemSimNao("Tem certeza que deseja excluir o tipoItem da venda?",
                "Excluir tipoItem da venda"))
        {
            venda = servicoVendas.ExcluirItem(
                dgvItens.ConverterPrimeiroSelecionado<long>());

            dgvItens.RemoverPrimeiraLinhaSelecionada();

            RecalcularPosicoes();
            RecalcularVendaTotal();
            RedefinirCamposConsulta();

            this.ExibirMensagemOperacaoConcluida("O tipoItem foi excluído da venda.");
        }

    }

    private void FecharVenda()
    {
        if (venda is not null
            && dgvItens.ExisteLinhas())
        {
            using var frm = ProvedorServicos.FrmFrenteCaixaFechamento();

            frm.DefinirVendaId(venda.Id);

            frm.ShowDialog(this);

            if (frm.Fechou)
            {
                RedefinirParametrosVenda();
                RedefinirTelaVenda();
            }
        }
    }

    private void ColocarEmEsperaVenda()
    {
        if (venda is not null
            && dgvItens.ExisteLinhas())
        {
            servicoVendas.ColocarVendaEmEspera(venda.Id);

            RedefinirParametrosVenda();
            RedefinirTelaVenda();
        }
    }

    private void AcoesVenda(Item item, decimal quantidade)
    {
        VerificarVenda();
        IncluirItemVenda(item, quantidade);
    }

    private void VerificarVenda()
    {
        if (venda is null)
        {
            venda = servicoVendas.NovaVenda(caixaId);

            CarregarVenda();

            InformarCPFOuCNPJNaNotaVenda();
        }
    }

    private void IncluirItemVenda(Item item1, decimal quantidade)
    {
        var precoFinal = SelecionarPrecoFinalItem(item1);

        var venda_VendaProduto = servicoVendas.AdicionarItem(
            venda?.Id
            ?? throw new InvalidOperationException("Um erro interno aconteceu durante a venda"),
            item1.Id,
            precoFinal,
            quantidade);

        venda = venda_VendaProduto.Item1;
        var item = venda_VendaProduto.Item2;

        AdicionarItemVenda(item);

        dgvItens.Rows[dgvItens.Rows.GetLastRow(DataGridViewElementStates.Visible)].Selected = true;
    }

    private void DefinirCPFOuCNPJVenda()
        => lbCPF_CNPJ.Text = venda?.CPF_CNPJ_Nota is null
            ? "NÃO INFORMADO"
            : venda.CPF_CNPJ_Nota
              ?? throw new InvalidOperationException("Um erro interno aconteceu durante a venda");

}
