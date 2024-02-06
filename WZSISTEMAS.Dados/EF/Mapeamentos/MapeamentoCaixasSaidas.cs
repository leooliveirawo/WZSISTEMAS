using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoCaixasSaidas : MapeamentoEntidades<CaixaSaida>
{
    public override void Configure(EntityTypeBuilder<CaixaSaida> builder)
    {
        base.Configure(builder);

        builder.ToTable("CAIXAS_SAIDAS");

        builder.Property(x => x.CaixaId)
            .HasColumnName("CAIXA_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.DataSaida)
            .HasColumnName("DATA_SAIDA")
            .HasDateTime()
            .IsRequired();

        builder.Property(x => x.Tipo)
            .HasColumnName("TIPO")
            .HasColumnType(EFMappingHelper.EnumType)
            .IsRequired();

        builder.Property(x => x.Valor)
            .HasColumnName("VALOR")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.CanceladaEm)
            .HasColumnName("CANCELADA_EM")
            .HasDateTime()
            .IsOptional();

        builder.Property(x => x.FoiCancelada)
            .HasColumnName("FOI_CANCELADA")
            .HasBool()
            .IsRequired();

        builder.Property(x => x.MotivoCancelamento)
            .HasColumnName("MOTIVO_CANCELAMENTO")
            .HasString()
            .HasMaxLength(150)
            .IsOptional();

        builder.HasOne(x => x.Caixa)
            .WithMany(x => x.Saidas)
            .HasForeignKey(x => x.CaixaId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}