using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoClientesFaturas : MapeamentoEntidades<ClienteFatura>
{
    public override void Configure(EntityTypeBuilder<ClienteFatura> builder)
    {
        base.Configure(builder);

        builder.ToTable("CLIENTES_FATURAS");

        builder.Property(x => x.ClienteId)
            .HasColumnName("CLIENTE_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.DiaFechamentoVencimento)
            .HasColumnName("DIA_FECHAMENTO_VENCIMENTO")
            .HasEnum()
            .IsRequired();

        builder.Property(x => x.MesReferente)
            .HasColumnName("MES_REFERENTE")
            .HasInt()
            .IsRequired();

        builder.Property(x => x.AnoReferente)
            .HasColumnName("ANO_REFERENTE")
            .HasInt()
            .IsRequired();

        builder.Property(x => x.ValorFatura)
            .HasColumnName("VALOR_FATURA")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.ParcialmentePago)
            .HasColumnName("PARCIALMENTE_PAGO")
            .HasBool()
            .IsRequired();

        builder.Property(x => x.Pago)
            .HasColumnName("PAGO")
            .HasBool()
            .IsRequired();

        builder.Property(x => x.ValorRestante)
            .HasColumnName("VALOR_RESTANTE")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.ValorPago)
            .HasColumnName("VALOR_PAGO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.HasOne(x => x.Cliente)
            .WithMany(x => x.Faturas)
            .HasForeignKey(x => x.ClienteId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}