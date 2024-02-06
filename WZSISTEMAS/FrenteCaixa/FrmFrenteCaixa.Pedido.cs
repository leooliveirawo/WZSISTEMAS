using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZSISTEMAS.FrenteCaixa;
public partial class FrmFrenteCaixa
{
    private void AbrirPedidosEmAberto()
    {
        if (pedido is null)
        {
            using var frm = ExibirFrenteCaixaEmEspera();

            if (frm.Concluiu)
            {
                pedido = frm.Pedido
                         ?? throw new InvalidOperationException("Um erro interno ocorreu no sistema");

                CarregarPedido();
            }
        }
    }

    private void RecalcularPedidoTotal()
        => lbTotal.Text = $"{pedido?.ValorTotal:C2}";

    private void RedefinirTelaPedido()
    {
        gbxNumero.Text = "Pedido Nº";
        lbTotal.Text = $"{0:C2}";

        lbCPF_CNPJ.Clear("NÃO INFORMADO");

        RedefinirCamposConsulta();

        dgvItens.Rows.Clear();
    }

    private void CarregarPedido()
    {
        lbTotal.Text = $"{pedido?.ValorTotal ?? throw new InvalidOperationException("Um erro interno aconteceu durante o pedido"):C2}";

        gbxNumero.Text = $"Nº do pedido: {pedido.Id}";

        dgvItens.Rows.Clear();

        foreach (var item in pedido.Itens)
            AdicionarItemPedido(item);

        dgvItens.SelecionarUltimaLinha();
    }

    private void AdicionarItemPedido(PedidoItem item)
    {
        var count = dgvItens.Rows.GetRowCount(DataGridViewElementStates.Visible) + 1;

        dgvItens.Adicionar(
            item.Id,
            count,
            $"{item.ItemId:0000000}",
            item.CodigoBarrasCodigoReferencia(),
            item.Descricao,
            item.UnidadeMedida.ConverterParaString(true),
            $"{item.ValorUnitario:C2}",
            $"{item.Quantidade:0.000}",
            $"{item.ValorTotal:C2}");
    }

    private void RedefinirParametrosPedido()
        => pedido = default;

    private void CancelarPedido()
    {
        if (pedido is not null)
        {
            if (this.ExibirMensagemSimNao("Tem certeza que deseja cancelar o pedido?", "Confirmar cancelamento"))
            {
                try
                {
                    servicoPedidos.CancelarPedido(pedido.Id);

                    RedefinirParametrosPedido();

                    RedefinirTelaPedido();

                    this.ExibirMensagemOperacaoConcluida("O pedido foi cancelado com sucesso.");
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

    private void AcoesPedido(KeyEventArgs e)
    {
        if (e.KeyData == Keys.F4)
            ExcluirItemPedido();
        else if (e.KeyData == Keys.F5)
            ConverterPedidoParaVenda();
        else if (e.KeyData == Keys.F6)
            NovoPedido();
        else if (e.KeyData == Keys.F7)
            AbrirPedidosEmAberto();
        else if (e.KeyData == Keys.F8)
        {
            naoSelecionar = true;
            dgvItens.Selecionar();
        }
        else if (e.KeyData != Keys.F2)
            naoSelecionar = true;
    }
    
    private void ExcluirItemPedido()
    {
        if (dgvItens.ExisteLinhasSelecionadas()
            && this.ExibirMensagemSimNao("Tem certeza que deseja excluir o tipoItem do pedido?", "Excluir tipoItem do pedido"))
        {
            pedido = servicoPedidos.ExcluirItem(
                dgvItens.ConverterPrimeiroSelecionado<long>());

            dgvItens.RemoverPrimeiraLinhaSelecionada();

            RecalcularPosicoes();
            RecalcularPedidoTotal();
            RedefinirCamposConsulta();

            this.ExibirMensagemOperacaoConcluida("O tipoItem foi excluído do pedido.");
        }
    }

    private void NovoPedido()
    {
        if (pedido is not null)
        {
            try
            {
                RedefinirParametrosPedido();
                RedefinirCamposConsulta();
                RedefinirTelaPedido();
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }
    }

    private void AcoesPedido(Item item, decimal quantidade)
    {
        VerificarPedido();
        IncluirItemPedido(item, quantidade);
    }

    private void VerificarPedido()
    {
        if (pedido is null)
        {
            pedido = servicoPedidos.NovoPedido(funcionarioId);

            CarregarPedido();
        }
    }

    private void IncluirItemPedido(Item item1, decimal quantidade)
    {
        var precoFinal = SelecionarPrecoFinalItem(item1);

        var pedido_PedidoItem = servicoPedidos.AdicionarItem(
            pedido?.Id
            ?? throw new InvalidOperationException("Um erro interno aconteceu durante a venda"),
            item1.Id,
            precoFinal,
            quantidade);

        pedido = pedido_PedidoItem.Item1;
        var item = pedido_PedidoItem.Item2;

        AdicionarItemPedido(item);

        dgvItens.Rows[dgvItens.Rows.GetLastRow(DataGridViewElementStates.Visible)].Selected = true;
    }

    private void ConverterPedidoParaVenda()
    {
        try
        {
            if (pedido is not null)
            {
                var venda = servicoPedidos.ConverterParaVenda(pedido.Id, TerminalId, caixaId) ??
                            throw new InvalidOperationException("A venda não foi gerada corretamente");

                naoCarregarVendaEmAberto = true;

                DefinirTipo(TipoFrenteCaixa.Venda);

                naoCarregarVendaEmAberto = false;

                this.venda = venda;

                CarregarVenda();
                RecalcularVendaTotal();
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }

    }
}
