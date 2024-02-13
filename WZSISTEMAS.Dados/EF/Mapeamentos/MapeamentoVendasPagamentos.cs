using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoVendasPagamentos : MapeamentoEntidades<VendaPagamento>
{
    public override void Configure(EntityTypeBuilder<VendaPagamento> builder)
    {
        base.Configure(builder);

        builder.ToTable("VENDAS_PAGAMENTOS");

        builder.Property(x => x.VendaId)
            .HasColumnName("VENDA_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.CaixaEntradaId)
            .HasColumnName("CAIXA_ENTRADA_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.CanceladoEm)
            .HasColumnName("CANCELADO_EM")
            .HasDateTime()
            .IsOptional();

        builder.Property(x => x.Tipo)
            .HasColumnName("TIPO")
            .HasEnum()
            .IsRequired();

        builder.Property(x => x.ValorPago)
            .HasColumnName("VALOR_PAGO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.ValorPagoLiquido)
            .HasColumnName("VALOR_PAGO_LIQUIDO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.HasOne(x => x.Venda)
            .WithMany(x => x.Pagamentos)
            .HasForeignKey(x => x.VendaId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder.HasOne(x => x.CaixaEntrada)
            .WithOne(x => x.VendaPagamento)
            .HasForeignKey<VendaPagamento>(x => x.CaixaEntradaId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}