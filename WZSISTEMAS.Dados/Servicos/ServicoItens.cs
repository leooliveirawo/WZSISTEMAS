using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoItens(
    DbContext dbContext,
    IValidator<Item> validacao)
    : ServicoEntidades<Item>(dbContext), IServicoItens
{
    private readonly IValidator<Item> validacao = validacao
                                                  ?? throw new ArgumentNullException(nameof(validacao));

    public IEnumerable<Item> ListarPorIdCodigoBarrasCodigoReferenciaDescricao(
        string valor,
        TipoConsultaItens tipo = TipoConsultaItens.Padrao)
    {
        var query = DbContext.Set<Item>()
            .Where(item => item.Descricao.Contains(valor)
                           || item.CodigoBarras == valor
                           || item.CodigoReferencia == valor);

        query = valor.ConverterParaLong(out var id)
            ? query.Where(item => item.Id == id)
            : query;

        query = tipo == TipoConsultaItens.ItensPrincipais
            ? query.Where(item => item.ItensDerivados.Any())
            : tipo == TipoConsultaItens.ItensDerivados
                ? query.Where(item => item.ItemPrincipalId.HasValue)
                : query;
        
        return query.ToList();
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