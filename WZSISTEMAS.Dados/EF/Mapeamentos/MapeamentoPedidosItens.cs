using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoPedidosItens : MapeamentoEntidades<PedidoItem>
{
    public override void Configure(EntityTypeBuilder<PedidoItem> builder)
    {
        base.Configure(builder);

        builder.ToTable("PEDIDOS_ITENS");

        builder.Property(x => x.PedidoId)
            .HasColumnName("PEDIDO_ID")
            .HasLong()
            .IsRequired();

        MapeamentoItensItens<PedidoItem>.Mapear(builder);

        builder.HasOne(x => x.Pedido)
            .WithMany(x => x.Itens)
            .HasForeignKey(x => x.PedidoId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder.HasOne(x => x.Item)
            .WithMany(x => x.PedidosItens)
            .HasForeignKey(x => x.ItemId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}