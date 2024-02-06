namespace WZSISTEMAS.Caixas;

public record CaixaMovimentacoes(
    long Id,
    DateTime DataHora,
    string TextoMovimentacao,
    ModosCaixaMovimentacao ModoMovimentacao,
    string Tipo,
    string Valor,
    TiposCaixaMovimentacao TipoMovimentacao,
    bool FoiCancelada);
