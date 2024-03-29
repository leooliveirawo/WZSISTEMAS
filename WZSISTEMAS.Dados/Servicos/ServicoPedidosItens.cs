﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WZSISTEMAS.Dados.Entidades.Interfaces;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoPedidosItens(DbContext dbContext, IServicoItens servicoItens)
    : ServicoEntidades<PedidoItem>(dbContext), IServicoPedidosItens
{
    private readonly IMapper mapper = new MapperConfiguration(cfg => { cfg.CreateMap<IItem, IItem>(); })
        .CreateMapper();

    private readonly IServicoItens servicoItens = servicoItens ?? throw new ArgumentNullException(nameof(servicoItens));

    public  PedidoItem Criar(
        long pedidoId,
        long itemId,
        decimal precoUnitario,
        decimal quantidade = 1)
    {
        var produto = servicoItens.ObterPorId(itemId)
                      ?? throw new InvalidOperationException("O produto não foi encontrado");

        var pedidoItem = new PedidoItem
        {
            PedidoId = pedidoId,
            ItemId = itemId,
            ValorUnitario = precoUnitario,
            Quantidade = quantidade,
            ValorTotal = precoUnitario * quantidade
        };

        mapper.Map<IItem, IItem>(produto, pedidoItem);

        Criar(pedidoItem);

        return pedidoItem;
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

    public virtual PedidoItem? ObterPedidoItemParaExcluirItem(long pedidoItemId)
    {
        return DbContext.Set<PedidoItem>()
            .Where(x => x.Id == pedidoItemId)
            .Select(item => new PedidoItem
            {
                Id = item.Id,
                PedidoId = item.PedidoId,
                ItemId = item.ItemId,
                ValorTotal = item.ValorTotal
            })
            .FirstOrDefault();
    }

    public virtual IEnumerable<PedidoItem> ObterTudoPorPedidoId(long pedidoId)
        => DbContext.Set<PedidoItem>()
            .AsNoTracking()
            .Where(item => item.PedidoId == pedidoId)
            .ToList();
}