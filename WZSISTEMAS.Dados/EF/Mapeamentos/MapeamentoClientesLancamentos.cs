using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoClientesLancamentos : MapeamentoEntidades<ClienteLancamento>
{
    public override void Configure(EntityTypeBuilder<ClienteLancamento> builder)
    {
        base.Configure(builder);

        builder.ToTable("CLIENTES_LANCAMENTOS");

        builder.Property(x => x.FaturaId)
            .HasColumnName("FATURA_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.VendaPagamentoId)
            .HasColumnName("VENDA_PAGAMENTO_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.LancadoEm)
            .HasColumnName("CRIADO_EM")
            .HasDateTime()
            .IsRequired();

        builder.Property(x => x.ValorLancamento)
            .HasColumnName("VALOR_LANCAMENTO")
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

        builder.HasOne(x => x.Fatura)
            .WithMany(x => x.Lancamentos)
            .HasForeignKey(x => x.FaturaId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder.HasOne(x => x.VendaPagamento)
            .WithMany(x => x.ClientesTitulos)
            .HasForeignKey(x => x.VendaPagamentoId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}