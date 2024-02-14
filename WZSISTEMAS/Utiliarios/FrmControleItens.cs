namespace WZSISTEMAS.Utiliarios;

public partial class FrmControleItens : Form
{
    private readonly IServicoItens servicoItens;
    private Item itemPrincipal;
    private int indexSelecionado;

    public FrmControleItens(IServicoItens servicoItens)
    {
        InitializeComponent();

        this.servicoItens = servicoItens ?? throw new ArgumentNullException(nameof(servicoItens));
    }

    private void RedefinirItensDerivados()
    {
        txtItemDerivadoCustoReal.Clear();
        txtItemDerivadoMargemLucro.Clear();
        txtItemDerivadoPeso.Clear();
        txtItemDerivadoPrecoFinal.Clear();
        txtItemDerivadoDescricao.Clear();
    }

    private void TxtPeso_Leave(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtItemPrincipalPeso.Text))
        {
            if (!decimal.TryParse(txtItemPrincipalPeso.Text, out var peso))
            {
                this.ExibirMensagem("O peso informado não é válido.", "Peso inválido");

                txtItemPrincipalPeso.Clear();
                txtItemPrincipalPeso.Selecionar();
            }
            else if (!string.IsNullOrWhiteSpace(txtItemPrincipalValorTotal.Text)
                     && this.ExibirMensagemSimNao("Deseja calcular o custo/kg?", "Calcular?"))
            {
                txtItemPrincipalValorTotal.Text.ConverterParaDecimal(out var valorTotal);

                txtItemPrincipalCustoKG.Text = $"{(valorTotal / peso):0.000}";
            }
        }
    }

    private void txtItemPrincipalCustoKG_Leave(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtItemPrincipalCustoKG.Text))
        {
            if (!decimal.TryParse(txtItemPrincipalPeso.Text, out var peso))
            {
                this.ExibirMensagem("O custo (KG) não é válido.", "Custo (KG) inválido");

                txtItemPrincipalPeso.Clear();
                txtItemPrincipalPeso.Selecionar();
            }
        }
    }

    private void TxtValorTotal_Leave(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtItemPrincipalValorTotal.Text)
            && !decimal.TryParse(txtItemPrincipalValorTotal.Text, out var peso))
        {
            this.ExibirMensagem("O valor total da novilha informado não é válido.", "Valor total inválido");

            txtItemPrincipalValorTotal.Clear();
            txtItemPrincipalValorTotal.Selecionar();
        }
    }

    private void btnItemDerivadoSalvar_Click(object sender, EventArgs e)
    {

    }

    private void btnItemPrincipalSelecionar_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmConsultaAvancadaItens();

            frm.DefinirTipo(TipoConsultaItens.ItensPrincipais);

            if (frm.ShowDialog(this, DialogResult.OK))
            {
                var item = servicoItens.ObterPorIdComItensDerivados(frm.Id);

                if (item is null)
                {
                    this.ExibirMensagem("O item não foi encontrado.", "Item não encontrado");
                }
                else
                {
                    itemPrincipal = item;

                    txtItemPrincipalId.Text = item.Id.ToString();
                    txtItemPrincipalDescricao.Text = item.Descricao;

                    foreach (var itemDerivado in item.ItensDerivados)
                        dgvItensDerivadosCadastros.Adicionar(itemDerivado.Id, itemDerivado.Descricao, "0.000", "0.000");

                    txtItemDerivadoDescricao.Clear();
                    txtItemDerivadoPeso.Clear();
                    txtItemDerivadoCustoReal.Clear();
                    txtItemDerivadoMargemLucro.Clear();
                    txtItemDerivadoPrecoFinal.Clear();

                    txtItemDerivadoPeso.Desativar();
                    txtItemDerivadoCustoReal.Desativar();
                    txtItemDerivadoMargemLucro.Desativar();
                    txtItemDerivadoPrecoFinal.Desativar();

                    btnItensDerivadosSalvar.Hide();
                }
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
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
                txtItemDerivadoPeso.Text = itemDerivado.ToString();
                txtItemDerivadoCustoReal.Text = itemDerivado.CustoReal.ToString();
                txtItemDerivadoMargemLucro.Text = itemDerivado.MargemLucro.ToString();
                txtItemDerivadoPrecoFinal.Text = itemDerivado.PrecoFinal.ToString();

                txtItemDerivadoPeso.Ativar();
                txtItemDerivadoCustoReal.Ativar();
                txtItemDerivadoMargemLucro.Ativar();
                txtItemDerivadoPrecoFinal.Ativar();

                btnItensDerivadosSalvar.Show();
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }
    }
}
