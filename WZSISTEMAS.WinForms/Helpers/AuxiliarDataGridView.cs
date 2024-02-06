namespace WZSISTEMAS.WinForms.Helpers;

public static class AuxiliarDataGridView
{
    public static void Definir<T>(
        this DataGridView dataGridView,
        int linha,
        int coluna,
        T valor)
        => dataGridView.Rows[linha].Cells[coluna].Value = valor;

    public static void RedefinirIndex(
        this DataGridView dataGridView,
        int colunaIndex)
    {
        var count = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible);

        if (count > 0)
            for (var i = 0; i < 0; i++)
                dataGridView.Definir(
                    i,
                    colunaIndex,
                    i + 1);
    }

    public static int ObterProximoIndex(this DataGridView dataGridView)
        => dataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible);

    public static T? Converter<T>(
        this DataGridView dataGridView,
        int linha,
        int coluna = 0)
        => dataGridView[coluna, linha].Value is null
        ? default
        : (T?)dataGridView[coluna, linha].Value;

    public static T? ConverterPrimeiroSelecionado<T>(
        this DataGridView dataGridView)
        => dataGridView.SelectedRows.Count == 0
        ? default
        : dataGridView.SelectedRows[0].Cells[0].Value is null
        ? default
        : (T?)dataGridView.SelectedRows[0].Cells[0].Value;

    public static int Adicionar(
        this DataGridView dataGridView,
        params object[] valores)
        => dataGridView.Rows.Add(valores);

    public static bool ExisteLinhas(
        this DataGridView dataGridView,
        DataGridViewElementStates state = DataGridViewElementStates.Visible)
        => dataGridView.ObterNumeroLinhas(state) > 0;

    public static int ObterNumeroLinhas(
        this DataGridView dataGridView,
        DataGridViewElementStates state = DataGridViewElementStates.Visible)
        => dataGridView.Rows.GetRowCount(state);

    public static bool ExisteLinhasSelecionadas(this DataGridView dataGridView)
        => dataGridView.SelectedRows.Count > 0;

    public static int ObterIndexUltimaLinha(
        this DataGridView dataGridView,
        DataGridViewElementStates state = DataGridViewElementStates.Visible)
        => dataGridView.Rows.GetLastRow(state);

    public static DataGridViewRow ObterPrimeiraLinhaSelecionada(this DataGridView dataGridView)
        => dataGridView.SelectedRows[0];

    public static int ObterIndexPrimeiraLinhaSelecionada(this DataGridView dataGridView)
        => dataGridView.ObterPrimeiraLinhaSelecionada().Index;

    public static DataGridViewRow ObterUltimaLinha(this DataGridView dataGridView)
        => dataGridView.Rows[dataGridView.ObterIndexUltimaLinha()];

    public static void RemoverPrimeiraLinhaSelecionada(this DataGridView dataGridView)
    {
        if (dataGridView.ExisteLinhasSelecionadas())
            dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
    }

    public static bool LinhaEColunaSelecionada(this DataGridViewCellEventArgs evento)
        => evento.ColumnIndex >= 0 && evento.RowIndex >= 0;

    public static void SelecionarUltimaLinha(this DataGridView dataGridView)
    {
        if (dataGridView.ExisteLinhas())
            dataGridView.ObterUltimaLinha().Selected = true;
    }
}
