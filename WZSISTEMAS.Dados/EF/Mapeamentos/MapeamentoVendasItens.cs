using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoVendasItens : MapeamentoEntidades<VendaItem>
{
    public override void Configure(EntityTypeBuilder<VendaItem> builder)
    {
        base.Configure(builder);

        builder.ToTable("VENDAS_ITENS");

        builder.Property(x => x.VendaId)
            .HasColumnName("VENDA_ID")
            .HasLong()
            .IsRequired();

        MapeamentoItensItens<VendaItem>.Mapear(builder);

        builder.HasOne(x => x.Venda)
            .WithMany(x => x.Itens)
            .HasForeignKey(x => x.VendaId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder.HasOne(x => x.Item)
            .WithMany(x => x.VendasItens)
            .HasForeignKey(x => x.ItemId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}