using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoProdutos(DbContext dbContext, IValidator<Item> validacao)
    : ServicoEntidades<Item>(dbContext), IServicoProdutos
{
    private readonly IValidator<Item> validacao = validacao ?? throw new ArgumentNullException(nameof(validacao));

    public  IEnumerable<Item> ListarPorDescricao(string descricao)
    {
        return DbContext.Set<Item>()
            .AsNoTracking()
            .Where(produto => produto.Descricao.Contains(descricao))
            .ToList();
    }

    public  Item? ObterPorCodigoReferencia(string codigoReferencia)
    {
        return ObterPorFiltro(produto => produto.CodigoReferencia == codigoReferencia);
    }

    public  Item? ObterPorIdOuCodigoBarras(string idOuCodigoBarras)
    {
        return long.TryParse(idOuCodigoBarras, out var id)
            ? ObterPorFiltro(x => x.Id == id || x.CodigoBarras == idOuCodigoBarras)
            : ObterPorFiltro(x => x.CodigoBarras == idOuCodigoBarras);
    }

    public  ValidationResult Validar(Item entidade)
    {
        return validacao.Validate(entidade);
    }

    protected virtual Item? ObterPorFiltro(Expression<Func<Item, bool>> filtro)
    {
        return DbContext.Set<Item>()
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
}