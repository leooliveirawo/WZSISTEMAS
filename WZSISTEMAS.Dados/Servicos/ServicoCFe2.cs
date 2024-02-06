using WZSISTEMAS.Base.NotaFiscal.Servicos;
using WZSISTEMAS.Base.NotaFiscal.Servicos.Interfaces;
using WZSISTEMAS.Base.NotaFiscal.Valores;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;
using WZSISTEMAS.Base.NotaFiscal.Valores.SAT;
using WZSISTEMAS.Base.Servicos.Interfaces;
using WZSISTEMAS.Dados.Helpers;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoCFe2(
    IServicoXml servicoXml,
    IServicoJson servicoJson,
    IServicoSAT servicoSAT) : ServicoCFe(servicoXml), IServicoCFe2
{
    private readonly IServicoJson servicoJson = servicoJson ?? throw new ArgumentNullException(nameof(servicoJson));

    private readonly IServicoSAT servicoSAT = servicoSAT ?? throw new ArgumentNullException(nameof(servicoSAT));

    public virtual CFe? ConvertVendaToCFe(
        DadosSAT dadosSAT,
        Venda venda,
        IEnumerable<VendaItem> itens,
        IEnumerable<VendaPagamento> pagamentos)
    {
        VerificarRequisitos();

        var cFe = new CFe();

        var empresa = venda.Caixa.Terminal.Empresa;

        DefinirIdentificao(venda, cFe);
        DefinirEmitente(cFe, empresa);
        DefinirPagamento(venda, cFe);
        DefinirTotal(venda, cFe);
        DefinirDetalhes(venda, itens, cFe);
        DefinirFormaPagamento(venda, pagamentos, cFe);

        servicoSAT.Criar(dadosSAT, cFe);

        return cFe;

       void VerificarRequisitos()
        {
            if (!itens.Any())
                throw new InvalidOperationException("Os ítens da venda não foram informados");

            if (!pagamentos.Any())
                throw new InvalidOperationException("Os ítens da venda não foram informados");

            if (venda.Caixa is null)
                throw new InvalidOperationException("O caixa não foi informado");

            if (venda.Caixa.Terminal is null)
                throw new InvalidOperationException("O terminal do caixa não foi informado");

            if (venda.Caixa.Terminal.Empresa is null)
                throw new InvalidOperationException("A empresa não foi informada");
        }

        static void DefinirIdentificao(Venda venda, CFe cFe)
        {
            cFe.InformacoesCFe.Identificacao.NumeroCaixa = venda.Caixa.TerminalId.ToString();
            cFe.InformacoesCFe.Identificacao.DataEmissao = venda.AbertaEm.Date.ToShortDateString();
            cFe.InformacoesCFe.Identificacao.HoraEmissao = venda.AbertaEm.ToLongTimeString();
        }

        static void DefinirEmitente(CFe cFe, Empresa empresa)
        {
            cFe.InformacoesCFe.Emitente.CPF_CNPJ = empresa.CNPJ;
            cFe.InformacoesCFe.Emitente.NomeOuRazaoSocial = empresa.RazaoSocial;
            cFe.InformacoesCFe.Emitente.IE = empresa.InscricaoEstadual;
        }

        static void DefinirPagamento(Venda venda, CFe cFe)
        {
            cFe.InformacoesCFe.Pagamento.ValorTroco = venda.Troco;
        }

        static void DefinirTotal(Venda venda, CFe cFe)
        {
            cFe.InformacoesCFe.Total.ValorTotal = venda.ValorTotal;
        }

        static void DefinirFormaPagamento(Venda venda, IEnumerable<VendaPagamento> pagamentos, CFe cFe)
        {
            foreach (var pagamento in pagamentos)
            {
                var formaPagamento = new FormaPagamentoCFe
                {
                    CodigoFormaPagamento = pagamento.Tipo.ConverterParaString(true),
                    ValorPago = pagamento.ValorPago
                };

                cFe.InformacoesCFe.Pagamento.FormaPagamento.Add(formaPagamento);
            }
        }
    }

    private void DefinirDetalhes(Venda venda, IEnumerable<VendaItem> itens, CFe cFe)
    {
        var numeroItem = 0;

        foreach (var item in itens)
        {
            numeroItem++;

            var detalhe = new Detalhe
            {
                NumeroItem = numeroItem.ToString()
            };

            detalhe.Produto.Nome = item.Descricao;
            detalhe.Produto.CodigoProduto = item.ItemId.ToString();
            detalhe.Produto.NCM = item.NCM;
            detalhe.Produto.CFOP = item.CFOP;
            detalhe.Produto.QuantidadeComercial = item.Quantidade;
            detalhe.Produto.ValorUnitarioComercial = item.ValorUnitario;
            detalhe.Produto.ValorProduto = item.ValorUnitario;
            detalhe.Produto.ValorProduto = item.ValorTotal;

            DefinirICMS_ISSQN(item, detalhe.Imposto);
            DefinirPIS(item, detalhe.Imposto);
            DefinirCOFINS(item, detalhe.Imposto);

            cFe.InformacoesCFe.Detalhes.Add(detalhe);
        }
    }

    private void DefinirICMS_ISSQN(VendaItem item, Imposto imposto)
    {
        void DefinirICMS()
        {
            object? itemICMS = item.TipoICMS switch
            {
                TiposICMS.ICMS00 => servicoJson.Deserializar<ICMS00>(item.ICMS),
                TiposICMS.ICMS10 => servicoJson.Deserializar<ICMS10>(item.ICMS),
                TiposICMS.ICMS20 => servicoJson.Deserializar<ICMS20>(item.ICMS),
                TiposICMS.ICMS30 => servicoJson.Deserializar<ICMS30>(item.ICMS),
                TiposICMS.ICMS40 => servicoJson.Deserializar<ICMS40>(item.ICMS),
                TiposICMS.ICMS51 => servicoJson.Deserializar<ICMS51>(item.ICMS),
                TiposICMS.ICMS60 => servicoJson.Deserializar<ICMS60>(item.ICMS),
                TiposICMS.ICMS70 => servicoJson.Deserializar<ICMS70>(item.ICMS),
                TiposICMS.ICMS90 => servicoJson.Deserializar<ICMS90>(item.ICMS),
                TiposICMS.ICMSSN101 => servicoJson.Deserializar<ICMSSN101>(item.ICMS),
                TiposICMS.ICMSSN102 => servicoJson.Deserializar<ICMSSN102>(item.ICMS),
                TiposICMS.ICMSSN201 => servicoJson.Deserializar<ICMSSN201>(item.ICMS),
                TiposICMS.ICMSSN202 => servicoJson.Deserializar<ICMSSN202>(item.ICMS),
                TiposICMS.ICMSSN500 => servicoJson.Deserializar<ICMSSN500>(item.ICMS),
                TiposICMS.ICMSSN900 => servicoJson.Deserializar<ICMSSN900>(item.ICMS),
                TiposICMS.ICMSST => servicoJson.Deserializar<ICMSST>(item.ICMS),
                _ => throw new NotSupportedException()
            };

            imposto.ICMS_ISSQN = new ICMS
            {
                TipoICMS = item.TipoICMS,
                ItemICMS = itemICMS
                           ?? throw new InvalidOperationException("Os dados do ICMS são inválidos")
            };
        }

        if (imposto.ImpostoTiposICMS_ISSQN == ImpostoTiposICMS_ISSQN.ICMS)
        {
            DefinirICMS();
        }
    }

    private void DefinirPIS(VendaItem item, Imposto imposto)
    {
        object? itemPIS = imposto.PIS.TipoPIS switch
        {
            TiposPIS.PISAliq => servicoJson.Deserializar<PISAliq>(item.PIS),
            TiposPIS.PISNT => servicoJson.Deserializar<PISNT>(item.PIS),
            TiposPIS.PISOutr => servicoJson.Deserializar<PISOutr>(item.PIS),
            TiposPIS.PISQtde => servicoJson.Deserializar<PISQtde>(item.PIS),
            TiposPIS.PISST => servicoJson.Deserializar<PISST>(item.PIS),
            _ => throw new NotSupportedException()
        };

        imposto.PIS.TipoPIS = item.TipoPIS;

        imposto.PIS.ItemPIS = itemPIS
                              ?? throw new InvalidOperationException("Os dados do PIS são inválidos");
    }

    private void DefinirCOFINS(VendaItem item, Imposto imposto)
    {
        object? itemCOFINS = item.TipoCOFINS switch
        {
            TiposCOFINS.COFINSAliq => servicoJson.Deserializar<COFINSAliq>(item.COFINS),
            TiposCOFINS.COFINSQtde => servicoJson.Deserializar<COFINSQtde>(item.COFINS),
            TiposCOFINS.COFINSNT => servicoJson.Deserializar<COFINSNT>(item.COFINS),
            TiposCOFINS.COFINSOutr => servicoJson.Deserializar<COFINSOutr>(item.COFINS),
            TiposCOFINS.COFINSST => servicoJson.Deserializar<COFINSST>(item.COFINS),
            _ => throw new NotSupportedException()
        };

        imposto.COFINS.TipoCOFINS = item.TipoCOFINS;
        imposto.COFINS.ItemCOFINS = itemCOFINS
                                    ?? throw new InvalidOperationException("Os dados do COFINS são inválidos");
    }
}