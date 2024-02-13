using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Mapeamentos;
using WZSISTEMAS.Dados.Entidades.Interfaces;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public static class MapeamentoItens<T>
    where T : class, IItem
{
    public static void Mapear(EntityTypeBuilder<T> builder)
    {
        builder.Property(x => x.Descricao)
            .HasColumnName("DESCRICAO")
            .HasString()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.CodigoBarras)
            .HasColumnName("CODIGO_BARRAS")
            .HasString()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.CodigoReferencia)
            .HasColumnName("CODIGO_REFERENCIA")
            .HasString()
            .HasMaxLength(125)
            .IsOptional();

        builder.Property(x => x.UnidadeMedida)
            .HasColumnName("UNIDADE_MEDIDA")
            .HasEnum()
            .IsRequired();

        builder.Property(x => x.NCM)
            .HasColumnName("NCM")
            .HasString()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.CFOP)
            .HasColumnName("CFOP")
            .HasString()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.TipoItem)
            .HasColumnName("TIPO_ITEM")
            .HasEnum()
            .IsRequired();

        MapeamentoImpostosICMS.Mapear(builder);
        MapeamentoImpostosPIS.Mapear(builder);
        MapeamentoImpostosCOFINS.Mapear(builder);
    }
}