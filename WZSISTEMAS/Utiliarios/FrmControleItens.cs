using System.Reflection.PortableExecutable;

namespace WZSISTEMAS.Utiliarios;

public partial class FrmControleItens : Form
{
    private readonly IServicoItens servicoItens;
    private ItemPrincipal? itemPrincipal;
    private int indexSelecionado;

    public FrmControleItens(IServicoItens servicoItens)
    {
        InitializeComponent();

        this.servicoItens = servicoItens ?? throw new ArgumentNullException(nameof(servicoItens));
    }

    private void RedefinirItensDerivados()
    {
        txtItemDerivadoDescricao.Clear();
        txtItemDerivadoPeso.Clear();
        txtItemDerivadoCustoRealKG.Clear();
        txtItemDerivadoMargemLucro.Clear();
        txtItemDerivadoPrecoFinalKG.Clear();
    }

    private void TxtItemPrincipalPeso_Leave(object sender, EventArgs e)
    {
        if (!txtItemPrincipalPeso.Text.EmBrancoOuNulo())
        {
            if (!txtItemPrincipalPeso.Text.ConverterParaDecimal(out var peso))
            {
                this.ExibirMensagem("O peso informado do ítem principal não é válido.", "Peso inválido");

                itemPrincipal.PesoKG = 0;

                txtItemPrincipalPeso.Clear();
                txtItemPrincipalPeso.Selecionar();
            }
            else
                itemPrincipal.PesoKG = peso;
        }
        else
            itemPrincipal.PesoKG = 0;
    }

    private void TxtItemPrincipalCustoReal_Leave(object sender, EventArgs e)
    {
        if (!txtItemPrincipalCustoReal.Text.EmBrancoOuNulo())
        {
            if (!txtItemPrincipalCustoReal.Text.ConverterParaDecimal(out var custoReal))
            {
                this.ExibirMensagem("O custo real informado do ítem principal não é válido.", "Custo real inválido");

                itemPrincipal.CustoReal = 0;
                itemPrincipal.CustoRealFinal = 0;
                itemPrincipal.CustoRealKG = 0;

                txtItemPrincipalCustoReal.Clear();
                txtItemPrincipalCustoRealFinal.Clear();
                txtItemPrincipalCustoRealKG.Clear();

                txtItemPrincipalCustoReal.Selecionar();
            }
            else
            {
                itemPrincipal.CustoReal = custoReal;
                
                CalcularItemPrincipalCustoRealKG();
            }
        }
        else
            itemPrincipal.CustoReal = 0;
    }

    private void CalcularItemPrincipalCustoRealKG()
    {
        if (itemPrincipal is { CustoReal: > 0, PesoKG: > 0 })
        {
            itemPrincipal.CalcularCustoRealFinal();
            itemPrincipal.CalcularCustoRealKG();

            txtItemPrincipalCustoRealFinal.Text = $"{itemPrincipal.CustoRealFinal:0.00}";
            txtItemPrincipalCustoRealKG.Text = $"{itemPrincipal.CustoRealKG:0.00}";

            for (var index = 0; index < itemPrincipal.ItensDerivados.Count; index++)
            {
                var itemDerivado = itemPrincipal.ItensDerivados.ElementAt(index);

                itemDerivado.CustoRealKG = itemPrincipal.CustoRealKG;

                if (itemDerivado.MargemLucro > 0)
                {
                    itemDerivado.PrecoFinalKG = itemDerivado.CustoRealKG.AplicarPorcentagem(itemDerivado.MargemLucro);

                    dgvItensDerivadosCadastros[clnItemDerivadoPrecoFinalKG.Name, index].Value =
                        $"{itemDerivado.PrecoFinalKG:C2}";
                }
            }

            txtItemPrincipalCustoRealKG.Selecionar();
        }
    }


    private void TxtItemPrincipalQuebra_Leave(object sender, EventArgs e)
    {
        if (!txtItemPrincipalQuebra.Text.EmBrancoOuNulo())
        {
            if (!txtItemPrincipalQuebra.Text.ConverterParaDecimal(out var quebra))
            {
                this.ExibirMensagem("O peso (quebra) informado do ítem principal não é válido.", "Peso (quebra) inválido");

                itemPrincipal.Quebra = 0;

                txtItemPrincipalQuebra.Clear();

                txtItemPrincipalQuebra.Selecionar();
            }
            else
                itemPrincipal.Quebra = quebra;
        }
        else
            itemPrincipal.Quebra = 0;
    }

    private void BtnItemPrincipalSelecionar_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmConsultaAvancadaItens();

            frm.DefinirTipo(TipoConsultaItens.ItensPrincipais);

            if (frm.ShowDialog(this, DialogResult.OK))
            {
                var item = servicoItens.ObterPorIdComItensDerivados(frm.Id);

                if (item is null)
                    this.ExibirMensagem("O item não foi encontrado.", "Item não encontrado");
                else
                {
                    itemPrincipal = new(item);

                    txtItemPrincipalId.Text = itemPrincipal.Id.ToString();
                    txtItemPrincipalCodBarrasCodRef.Text = itemPrincipal.CodigoBarrasCodigoReferencia;
                    txtItemPrincipalDescricao.Text = itemPrincipal.Descricao;

                    txtItemPrincipalPeso.Ativar();
                    txtItemPrincipalQuebra.Ativar();
                    txtItemPrincipalCustoReal.Ativar();

                    txtItemPrincipalCustoRealKG.Ativar();

                    txtItemPrincipalPeso.Clear();

                    txtItemPrincipalCustoReal.Clear();

                    txtItemPrincipalCustoRealKG.Clear();

                    dgvItensDerivadosCadastros.Rows.Clear();

                    foreach (var itemDerivado in itemPrincipal.ItensDerivados)
                        dgvItensDerivadosCadastros.Adicionar(
                            itemDerivado.Id,
                            itemDerivado.Descricao,
                            $"{itemDerivado.PesoKG:0.000}",
                            $"{itemDerivado.MargemLucro:0.000}",
                            $"{itemDerivado.PrecoFinalKG:C2}");

                    txtItemDerivadoDescricao.Clear();

                    txtItemDerivadoPeso.Clear();

                    txtItemDerivadoCustoRealKG.Clear();
                    txtItemDerivadoMargemLucro.Clear();
                    txtItemDerivadoPrecoFinalKG.Clear();

                    txtItemDerivadoPeso.Desativar();

                    txtItemDerivadoCustoRealKG.Desativar();
                    txtItemDerivadoMargemLucro.Desativar();
                    txtItemDerivadoPrecoFinalKG.Desativar();

                    gbxItemDerivado.Ativar();

                    btnItensDerivadosSalvar.Desativar();

                    txtItemPrincipalPeso.Selecionar();
                }
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void TxtItemDerivadoMargemLucro_Leave(object sender, EventArgs e)
    {
        var itemDerivado = itemPrincipal.ItensDerivados.ElementAt(indexSelecionado);

        if (!txtItemDerivadoMargemLucro.Text.EmBrancoOuNulo())
        {
            if (!txtItemDerivadoMargemLucro.Text.ConverterParaDecimal(out var margemLucro))
            {
                this.ExibirMensagem("A margem de lucro do item derivado informada não é válida.",
                    "Margem de lucro inválida");

                itemDerivado.MargemLucro = 0;
                txtItemDerivadoMargemLucro.Text = "0";
                txtItemDerivadoMargemLucro.Selecionar();
            }
            else
                itemDerivado.MargemLucro = margemLucro;
        }
        else
            itemDerivado.MargemLucro = 0;

    }

    private void TxtItemDerivadoPrecoFinalKG_Leave(object sender, EventArgs e)
    {
        var itemDerivado = itemPrincipal.ItensDerivados.ElementAt(indexSelecionado);

        if (!txtItemDerivadoPrecoFinalKG.Text.EmBrancoOuNulo())
        {
            if (!txtItemDerivadoPrecoFinalKG.Text.ConverterParaDecimal(out var precoFinal))
            {
                this.ExibirMensagem("O preço final/KG do item derivado informado não é válido.",
                    "Preço final/KG inválido");

                itemDerivado.PrecoFinalKG = 0;
                txtItemDerivadoPrecoFinalKG.Text = "0";
                txtItemDerivadoPrecoFinalKG.Selecionar();
            }
            else
                itemDerivado.PrecoFinalKG = precoFinal;
        }
        else
            itemDerivado.PrecoFinalKG = 0;

        dgvItensDerivadosCadastros.ObterPrimeiraLinhaSelecionada().Cells[clnItemDerivadoPrecoFinalKG.Name].Value =
            $"{itemDerivado.PrecoFinalKG:C2}";

    }

    private void TxtItemDerivadoPeso_Leave(object sender, EventArgs e)
    {
        var itemDerivado = itemPrincipal.ItensDerivados.ElementAt(indexSelecionado);

        if (!txtItemDerivadoPeso.Text.EmBrancoOuNulo())
        {
            if (!txtItemDerivadoPeso.Text.ConverterParaDecimal(out var peso))
            {
                this.ExibirMensagem("O peso/KG do item derivado informado não é válido.",
                    "Peso/KG inválido");

                itemDerivado.PesoKG = 0;
                txtItemDerivadoPeso.Text = "0";
                txtItemDerivadoPeso.Selecionar();
            }
            else
                itemDerivado.PesoKG = peso;
        }
        else
            itemDerivado.PesoKG = 0;


        dgvItensDerivadosCadastros.ObterPrimeiraLinhaSelecionada().Cells[clnItemDerivadoPeso.Name].Value =
            $"{itemDerivado.PesoKG:0.000}";
    }

    private void DgvCadastros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.LinhaEColunaSelecionada())
        {
            try
            {
                indexSelecionado = dgvItensDerivadosCadastros.ObterIndexPrimeiraLinhaSelecionada();

                var itemDerivado = itemPrincipal.ItensDerivados.ElementAt(indexSelecionado);

                txtItemDerivadoDescricao.Text = itemDerivado.Descricao;
                txtItemDerivadoPeso.Text = itemDerivado.PesoKG.ToString();
                txtItemDerivadoCustoRealKG.Text = $"{itemDerivado.CustoRealKG:0.00}";
                txtItemDerivadoMargemLucro.Text = $"{itemDerivado.MargemLucro:0.000}";
                txtItemDerivadoPrecoFinalKG.Text = $"{itemDerivado.PrecoFinalKG:0.00}";

                txtItemDerivadoPeso.Ativar();
                txtItemDerivadoCustoRealKG.Ativar();
                txtItemDerivadoMargemLucro.Ativar();
                txtItemDerivadoPrecoFinalKG.Ativar();

                btnItensDerivadosSalvar.Ativar();

                txtItemDerivadoPeso.Selecionar();
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }
    }

    private void CalcularItemDerivado(ItemDerivado itemDerivado)
    {
        itemDerivado.PrecoFinalKG = itemDerivado.CustoRealKG.AplicarPorcentagem(itemDerivado.MargemLucro);

        txtItemDerivadoCustoRealKG.Text = $"{itemDerivado.CustoRealKG:0.00}";
        txtItemDerivadoPrecoFinalKG.Text = $"{itemDerivado.PrecoFinalKG:0.00}";

        dgvItensDerivadosCadastros.ObterPrimeiraLinhaSelecionada().Cells[clnItemDerivadoPrecoFinalKG.Name].Value =
            $"{itemDerivado.PrecoFinalKG:C2}";
    }

    private void txtItemDerivadoMargemLucro_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnItensDerivadosSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (var itemDerivado in itemPrincipal.ItensDerivados)
            {
                var item = servicoItens.ObterPorId(itemDerivado.Id, true);

                item.CustoReal = itemDerivado.CustoRealKG;
                item.PrecoFinal = itemDerivado.PrecoFinalKG;

                servicoItens.Editar(item);
            }

            servicoItens.SalvarAlteracoes();

            this.ExibirMensagemOperacaoConcluida("As alterações dos itens derivados foram salvas com sucesso.");
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }
}
