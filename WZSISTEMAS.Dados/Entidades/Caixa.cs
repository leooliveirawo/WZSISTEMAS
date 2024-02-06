namespace WZSISTEMAS.Dados.Entidades;

public class Caixa : Entidade
{
    public Caixa()
    {
        Status = CaixaStatus.Aberto;

        AbertoEm = DateTime.Now;

        Entradas = new HashSet<CaixaEntrada>();
        Saidas = new HashSet<CaixaSaida>();
        Suprimentos = new HashSet<CaixaSuprimento>();

        Vendas = new HashSet<Venda>();
    }

    public long UsuarioId { get; set; }
    public long TerminalId { get; set; }

    public CaixaStatus Status { get; set; }

    public DateTime AbertoEm { get; set; }
    public DateTime? FechadoEm { get; set; }
    public DateTime? CanceladoEm { get; set; }

    public string? MotivoCancelamento { get; set; }

    public decimal SaldoInicial { get; set; }
    public decimal SaldoSuprimento { get; set; }
    public decimal SaldoFinal { get; set; }

    public decimal SaldoDinheiro { get; set; }
    public decimal SaldoCheque { get; set; }
    public decimal SaldoOutros { get; set; }

    public decimal SuprimentoDinheiro { get; set; }
    public decimal SuprimentoOutros { get; set; }
    public decimal SuprimentoCheque { get; set; }

    public decimal SuprimentoCanceladoDinheiro { get; set; }
    public decimal SuprimentoCanceladoCheque { get; set; }
    public decimal SuprimentoCanceladoOutros { get; set; }

    public decimal EntradaDinheiro { get; set; }
    public decimal EntradaCartaoCredito { get; set; }
    public decimal EntradaCartaoDebito { get; set; }
    public decimal EntradaCartaoConvenio { get; set; }
    public decimal EntradaCartaoVoucher { get; set; }
    public decimal EntradaCheque { get; set; }
    public decimal EntradaOutros { get; set; }

    public decimal EntradaCanceladaDinheiro { get; set; }
    public decimal EntradaCanceladaCartaoCredito { get; set; }
    public decimal EntradaCanceladaCartaoDebito { get; set; }
    public decimal EntradaCanceladaCartaoConvenio { get; set; }
    public decimal EntradaCanceladaCartaoVoucher { get; set; }
    public decimal EntradaCanceladaCheque { get; set; }
    public decimal EntradaCanceladaOutros { get; set; }

    public decimal SaidaDinheiro { get; set; }
    public decimal SaidaCheque { get; set; }
    public decimal SaidaOutros { get; set; }

    public decimal SaidaCanceladaDinheiro { get; set; }
    public decimal SaidaCanceladaCheque { get; set; }
    public decimal SaidaCanceladaOutros { get; set; }

    public Usuario Usuario { get; set; } = default!;
    public Terminal Terminal { get; set; } = default!;

    public ICollection<CaixaEntrada> Entradas { get; set; }
    public ICollection<CaixaSaida> Saidas { get; set; }
    public ICollection<CaixaSuprimento> Suprimentos { get; set; }

    public ICollection<Venda> Vendas { get; set; }

    public void IncluirSuprimento(TipoSuprimentoCaixa tipo, decimal valor)
    {
        switch (tipo)
        {
            case TipoSuprimentoCaixa.Cheque:
                SuprimentoCheque += valor;
                SaldoCheque += valor;
                SaldoFinal += valor;
                break;
            case TipoSuprimentoCaixa.Dinheiro:
                SuprimentoDinheiro += valor;
                SaldoDinheiro += valor;
                SaldoFinal += valor;
                break;
            case TipoSuprimentoCaixa.Outros:
                SuprimentoOutros += valor;
                SaldoOutros += valor;
                SaldoFinal += valor;
                break;
            default:
                throw new NotSupportedException();
        }
    }

    public void CancelarSuprimento(TipoSuprimentoCaixa tipo, decimal valor)
    {
        switch (tipo)
        {
            case TipoSuprimentoCaixa.Cheque:
                SuprimentoCanceladoCheque += valor;
                SaldoCheque -= valor;
                SaldoFinal -= valor;
                break;
            case TipoSuprimentoCaixa.Dinheiro:
                SuprimentoCanceladoDinheiro += valor;
                SaldoDinheiro -= valor;
                SaldoFinal -= valor;
                break;
            case TipoSuprimentoCaixa.Outros:
                SuprimentoCanceladoOutros += valor;
                SaldoOutros -= valor;
                SaldoFinal += valor;
                break;
            default:
                throw new NotSupportedException();
        }
    }

    public void IncluirEntrada(TipoEntradaCaixa entradaType, decimal valor)
    {
        switch (entradaType)
        {
            case TipoEntradaCaixa.Dinheiro:
                EntradaDinheiro += valor;
                SaldoDinheiro += valor;
                break;
            case TipoEntradaCaixa.CartaoDebito:
                EntradaCartaoDebito += valor;
                break;
            case TipoEntradaCaixa.CartaoCredito:
                EntradaCartaoCredito += valor;
                break;
            case TipoEntradaCaixa.CartaoVoucher:
                EntradaCartaoVoucher += valor;
                break;
            case TipoEntradaCaixa.CartaoLoja:
                EntradaCartaoConvenio += valor;
                break;
            case TipoEntradaCaixa.Cheque:
                SaldoCheque += valor;
                EntradaCheque += valor;
                break;
            case TipoEntradaCaixa.Outros:
                SaldoCheque += valor;
                EntradaOutros += valor;
                break;
            default:
                throw new NotSupportedException();
        }

        SaldoFinal += valor;
    }

    public void CancelarEntrada(TipoEntradaCaixa entradaType, decimal valor)
    {
        switch (entradaType)
        {
            case TipoEntradaCaixa.Dinheiro:
                SaldoDinheiro -= valor;
                EntradaCanceladaDinheiro += valor;
                break;
            case TipoEntradaCaixa.CartaoDebito:
                EntradaCanceladaCartaoDebito += valor;
                break;
            case TipoEntradaCaixa.CartaoCredito:
                EntradaCanceladaCartaoCredito += valor;
                break;
            case TipoEntradaCaixa.CartaoVoucher:
                EntradaCanceladaCartaoVoucher += valor;
                break;
            case TipoEntradaCaixa.CartaoLoja:
                EntradaCanceladaCartaoConvenio += valor;
                break;
            case TipoEntradaCaixa.Cheque:
                SaldoCheque -= valor;
                EntradaCanceladaCheque += valor;
                break;
            case TipoEntradaCaixa.Outros:
                SaldoOutros -= valor;
                EntradaCanceladaOutros += valor;
                break;
            default:
                throw new NotSupportedException();
        }

        SaldoFinal -= valor;
    }

    public void RealizarRetirada(TipoSaidaCaixa saidaType, decimal valor)
    {
        switch (saidaType)
        {
            case TipoSaidaCaixa.Dinheiro:
                SaldoDinheiro -= valor;
                SaidaDinheiro += valor;
                break;
            case TipoSaidaCaixa.Cheque:
                SaldoCheque -= valor;
                SaidaCheque += valor;
                break;
            case TipoSaidaCaixa.Outros:
                SaldoOutros -= valor;
                SaidaOutros += valor;
                break;
            default:
                throw new NotSupportedException();
        }

        SaldoFinal -= valor;
    }

    public void CancelarSaida(TipoSaidaCaixa saidaType, decimal valor)
    {
        switch (saidaType)
        {
            case TipoSaidaCaixa.Dinheiro:
                SaldoDinheiro += valor;
                SaidaCanceladaDinheiro += valor;
                break;
            case TipoSaidaCaixa.Cheque:
                SaldoCheque += valor;
                SaidaCanceladaCheque += valor;
                break;
            case TipoSaidaCaixa.Outros:
                SaldoOutros += valor;
                SaidaCanceladaOutros += valor;
                break;
            default:
                throw new NotSupportedException();
        }

        SaldoFinal += valor;
    }
}