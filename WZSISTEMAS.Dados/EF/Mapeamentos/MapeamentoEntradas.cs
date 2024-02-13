using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoEntradas : MapeamentoEntidades<Entrada>
{
    public override void Configure(EntityTypeBuilder<Entrada> builder)
    {
        base.Configure(builder);

        builder.ToTable("ENTRADAS");

        builder.Property(x => x.DataEmissao)
            .HasColumnName("DATA_EMISSAO")
            .HasDateTime()
            .IsRequired();

        builder.Property(x => x.DataSaida)
            .HasColumnName("DATA_SAIDA")
            .HasDateTime()
            .IsRequired();

        builder.Property(x => x.DataEntrada)
            .HasColumnName("DATA_ENTRADA")
            .HasDateTime()
            .IsRequired();

        builder.Property(x => x.TerminalId)
            .HasColumnName("TERMINAL_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.EmitenteId)
            .HasColumnName("EMITENTE_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.TransportadoraId)
            .HasColumnName("TRANSPORTADORA_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.DestinarioId)
            .HasColumnName("DESTINATARIO_ID")
            .HasLong()
            .IsRequired();

        builder.HasOne(x => x.Terminal)
            .WithMany(x => x.Entradas)
            .HasForeignKey(x => x.TerminalId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder.HasOne(x => x.Emitente)
            .WithMany(x => x.Entradas)
            .HasForeignKey(x => x.EmitenteId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder.HasOne(x => x.Destinario)
            .WithMany(x => x.Entradas)
            .HasForeignKey(x => x.DestinarioId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder.HasOne(x => x.Transportadora)
            .WithMany(x => x.Entradas)
            .HasForeignKey(x => x.TransportadoraId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}