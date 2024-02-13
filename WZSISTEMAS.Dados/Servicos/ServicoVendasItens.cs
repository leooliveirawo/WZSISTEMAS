using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WZSISTEMAS.Dados.Entidades.Interfaces;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoVendasItens(DbContext dbContext, IServicoItens servicoItens)
    : ServicoEntidades<VendaItem>(dbContext), IServicoVendasItens
{
    private readonly IMapper mapper = new MapperConfiguration(cfg => { cfg.CreateMap<IItem, IItem>(); })
        .CreateMapper();

    private readonly IServicoItens servicoItens = servicoItens ?? throw new ArgumentNullException(nameof(servicoItens));

    public override void Criar(VendaItem entidade)
    {
        base.Criar(entidade);

        var produto = servicoItens.ObterPorId(entidade.ItemId, true) ??
                      throw new InvalidOperationException("O produto não foi encontrado");

        if (produto.GerenciarEstoque)
        {
            produto.EstoqueAtual -= Convert.ToInt64(entidade.Quantidade);

            servicoItens.Editar(produto);
        }
    }

    public  VendaItem Criar(long vendaId, long itemId, decimal precoUnitario, decimal quantidade = 1)
    {
        var produto = servicoItens.ObterPorId(itemId) ??
                      throw new InvalidOperationException("O produto não foi encontrado");

        var vendaItem = new VendaItem
        {
            VendaId = vendaId,
            ItemId = itemId,
            ValorUnitario = precoUnitario,
            Quantidade = quantidade,
            ValorTotal = precoUnitario * quantidade
        };

        mapper.Map<IItem, IItem>(produto, vendaItem);

        Criar(vendaItem);

        return vendaItem;
    }

    public override void ExcluirPeloId(long id)
    {
        var entidade = ObterPorId(id) ??
                       throw new InvalidOperationException("O produto não foi encontrado");

        var produto = servicoItens.ObterPorId(entidade.ItemId, true) ??
                      throw new InvalidOperationException("O produto não foi encontrado");

        base.ExcluirPeloId(id);

        if (produto.GerenciarEstoque)
        {
            produto.EstoqueAtual -= Convert.ToInt64(entidade.Quantidade);

            servicoItens.Editar(produto);
        }
    }

    public virtual VendaItem? ObterVendaItemParaExcluirItem(long vendaItemId)
    {
        return DbContext.Set<VendaItem>()
            .Where(x => x.Id == vendaItemId)
            .Select(item => new VendaItem
            {
                Id = item.Id,
                VendaId = item.VendaId,
                ItemId = item.ItemId,
                ValorTotal = item.ValorTotal
            })
            .FirstOrDefault();
    }
}