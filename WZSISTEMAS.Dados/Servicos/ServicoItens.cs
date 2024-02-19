using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoItens(
    DbContext dbContext,
    IValidator<Item> validacao)
    : ServicoEntidades<Item>(dbContext), IServicoItens
{
    private readonly IValidator<Item> validacao = validacao
                                                  ?? throw new ArgumentNullException(nameof(validacao));

    protected override Expression<Func<Item, ItemLista<long>>> ConverterEntidadeParaLista()
        => item => new ItemLista<long>
        {
            Descricao = item.Descricao,
            Item = item.Id
        };

    public IEnumerable<Item> ListarPorIdCodigoBarrasCodigoReferenciaDescricao(
        string valor,
        TipoConsultaItens tipo = TipoConsultaItens.Padrao)
        => tipo switch
        {
            TipoConsultaItens.Padrao when valor.ConverterParaLong(out var id) => DbContext.Set<Item>()
                .Where(item => 
                    item.Id == id 
                    || item.Descricao.Contains(valor) 
                    || item.CodigoBarras == valor 
                    || item.CodigoReferencia == valor)
                .ToList(),
            TipoConsultaItens.Padrao => DbContext.Set<Item>()
                .Where(item =>
                    item.Descricao.Contains(valor)
                    || item.CodigoBarras == valor
                    || item.CodigoReferencia == valor)
                .ToList(),
            TipoConsultaItens.ItensPrincipais when valor.ConverterParaLong(out var id) => DbContext.Set<Item>()
                .Where(item => 
                    item.ItensDerivados.Any()
                    && item.Id == id
                    || item.Descricao.Contains(valor)
                    || item.CodigoBarras == valor
                    || item.CodigoReferencia == valor)
                .ToList(),
            TipoConsultaItens.ItensPrincipais => DbContext.Set<Item>()
                .Where(item =>
                    item.ItensDerivados.Any()
                    && item.Descricao.Contains(valor)
                    || item.CodigoBarras == valor
                    || item.CodigoReferencia == valor)
                .ToList(),
            TipoConsultaItens.ItensDerivados when valor.ConverterParaLong(out var id) => DbContext.Set<Item>()
                .Where(item =>
                    item.ItemPrincipalId.HasValue
                    && item.Id == id 
                    || item.Descricao.Contains(valor)
                    || item.CodigoBarras == valor
                    || item.CodigoReferencia == valor)
                .ToList(),
            TipoConsultaItens.ItensDerivados => DbContext.Set<Item>()
                .Where(item =>
                    item.ItemPrincipalId.HasValue
                    && item.Descricao.Contains(valor) 
                    || item.CodigoBarras == valor 
                    || item.CodigoReferencia == valor)
                .ToList(),
            _ => throw new NotSupportedException()
        };

    public Item? ObterPorIdComItensDerivados(long id)
    {
        var item = DbContext.Set<Item>()
            .Include(item => item.ItensDerivados)
            .Where(item => item.Id == id)
            .Select(item => new Item()
            {
                Id = item.Id,
                Descricao = item.Descricao,
                CodigoBarras = item.CodigoBarras,
                CodigoReferencia = item.CodigoReferencia,
                CustoReal = item.CustoReal,
                PrecoFinal = item.PrecoFinal,
                MargemLucro = item.MargemLucro,
                ItensDerivados = item.ItensDerivados.Select(itemDerivado =>
                        new Item
                        {
                            Id = itemDerivado.Id,
                            Descricao = itemDerivado.Descricao,
                            CodigoBarras = itemDerivado.CodigoBarras,
                            CodigoReferencia = itemDerivado.CodigoReferencia,
                            CustoReal = itemDerivado.CustoReal,
                            PrecoFinal = itemDerivado.PrecoFinal,
                            MargemLucro = itemDerivado.MargemLucro,
                        })
                    .ToList()
            })
            .PrimeiroOuPadrao();

        return item;
    }



    public Item? ObterPorCodigoReferencia(string codigoReferencia)
        => ObterPorFiltro(item => item.CodigoReferencia == codigoReferencia);

    public Item? ObterPorIdOuCodigoBarras(string idOuCodigoBarras)
        => long.TryParse(idOuCodigoBarras, out var id)
            ? ObterPorFiltro(item => item.Id == id || item.CodigoBarras == idOuCodigoBarras)
            : ObterPorFiltro(item => item.CodigoBarras == idOuCodigoBarras);

    public  ValidationResult Validar(Item entidade)
        => validacao.Validate(entidade);

    protected virtual Item? ObterPorFiltro(Expression<Func<Item, bool>> filtro)
    => DbContext.Set<Item>()
        .AsNoTracking()
        .Where(filtro)
        /*.Select(produto => new Item
        {
            Id = produto.Id,
            Descricao = produto.Descricao,
            DescricaoPDV = produto.DescricaoPDV,
            GerarDadosAuxiliarBalanca = produto.GerarDadosAuxiliarBalanca,
            CodigoAuxiliarBalanca = produto.CodigoAuxiliarBalanca,
            UsarBalancaCheckout = produto.UsarBalancaCheckout,
            MultiplosPrecos = produto.MultiplosPrecos,
            ModoItem = produto.ModoItem,
            UnidadeMedida = produto.UnidadeMedida,
            PrecoFinal = produto.PrecoFinal,
            PrecoFinal2 = produto.PrecoFinal2,
            PrecoFinal3 = produto.PrecoFinal3,
            NCM = produto.NCM,
            CFOP = produto.CFOP,
            ICMS = produto.ICMS,
            TipoICMS = produto.TipoICMS,
            COFINS = produto.COFINS,
            TipoCOFINS = produto.TipoCOFINS,
            PIS = produto.PIS,
            TipoPIS = produto.TipoPIS
        })*/
        .FirstOrDefault();
}