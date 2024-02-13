using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoCaixasSuprimentos : MapeamentoEntidades<CaixaSuprimento>
{
    public override void Configure(EntityTypeBuilder<CaixaSuprimento> builder)
    {
        base.Configure(builder);

        builder.ToTable("CAIXAS_SUPRIMENTOS");

        builder.Property(x => x.CaixaId)
            .HasColumnName("CAIXA_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.DataSuprimento)
            .HasColumnName("DATA_SUPRIMENTO")
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

        builder.Property(x => x.CanceladoEm)
            .HasColumnName("CANCELADO_EM")
            .HasDateTime()
            .IsOptional();

        builder.Property(x => x.FoiCancelado)
            .HasColumnName("FOI_CANCELADO")
            .HasBool()
            .IsRequired();

        builder.Property(x => x.MotivoCancelamento)
            .HasColumnName("MOTIVO_CANCELAMENTO")
            .HasString()
            .HasMaxLength(150)
            .IsOptional();

        builder.HasOne(x => x.Caixa)
            .WithMany(x => x.Suprimentos)
            .HasForeignKey(x => x.CaixaId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}