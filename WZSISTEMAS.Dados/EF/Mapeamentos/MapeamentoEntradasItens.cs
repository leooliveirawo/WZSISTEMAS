using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoEntradasItens : MapeamentoEntidades<EntradaItem>
{
    public override void Configure(EntityTypeBuilder<EntradaItem> builder)
    {
        base.Configure(builder);

        builder.ToTable("ENTRADAS_ITENS");

        builder.Property(x => x.EntradaId)
            .HasColumnName("ENTRADA_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.ItemId)
            .HasColumnName("PRODUTO_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.CodigoProduto)
            .HasColumnName("CODIGO_PRODUTO")
            .HasString()
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.Descricao)
            .HasColumnName("DESCRICAO")
            .HasString()
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.UnidadeMedidaOrigem)
            .HasColumnName("UNIDADE_MEDIDA_ORIGEM")
            .HasColumnType(EFMappingHelper.EnumType)
            .IsRequired();

        builder.Property(x => x.UnidadeMedidaDestino)
            .HasColumnName("UNIDADE_MEDIDA_DESTINO")
            .HasColumnType(EFMappingHelper.EnumType)
            .IsRequired();

        builder.Property(x => x.UnidadeMedidaConversao)
            .HasColumnName("UNIDADE_MEDIDA_CONVERSAO")
            .HasColumnType(EFMappingHelper.EnumType)
            .IsRequired();

        builder.Property(x => x.ValorUnitario)
            .HasColumnName("VALOR_UNITARIO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

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

        builder.HasOne(x => x.Entrada)
            .WithMany(x => x.Itens)
            .HasForeignKey(x => x.EntradaId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder.HasOne(x => x.Item)
            .WithMany(x => x.EntradasItens)
            .HasForeignKey(x => x.ItemId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}