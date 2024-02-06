using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;
using WZSISTEMAS.Dados.Entidades.Interfaces;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public static class MapeamentoItensItens<T>
    where T : class, IItemItem
{
    public static void Mapear(EntityTypeBuilder<T> builder)
    {
        builder.Property(x => x.ItemId)
            .HasColumnName("ITEM_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.CanceladoEm)
            .HasColumnName("CANCELADO_EM")
            .HasDateTime()
            .IsOptional();

        builder.Property(x => x.ValorUnitario)
            .HasColumnName("VALOR_UNITARIO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.ValorUnitarioDesconto)
            .HasColumnName("VALOR_UNITARIO_DESCONTO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.Quantidade)
            .HasColumnName("QUANTIDADE")
            .HasDecimal()
            .HasPrecision(18, 3)
            .IsRequired();

        builder.Property(x => x.ValorTotal)
            .HasColumnName("VALOR_TOTAL")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.ValorTotalDesconto)
            .HasColumnName("VALOR_TOTAL_DESCONTO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        MapeamentoItens<T>.Mapear(builder);
    }
}