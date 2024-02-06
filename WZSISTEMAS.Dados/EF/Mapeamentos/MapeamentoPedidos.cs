using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoPedidos : MapeamentoEntidades<Pedido>
{
    public override void Configure(EntityTypeBuilder<Pedido> builder)
    {
        base.Configure(builder);

        builder.ToTable("PEDIDOS");

        builder.Property(x => x.ValorTotal)
            .HasColumnName("VALOR_TOTAL")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.Volume)
            .HasColumnName("VOLUME")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.ValorTotalDesconto)
            .HasColumnName("VALOR_TOTAL_DESCONTO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.AbertoEm)
            .HasColumnName("ABERTO_EM")
            .HasDateTime()
            .IsRequired();

        builder.Property(x => x.FinalizadoEm)
            .HasColumnName("FINALIZADO_EM")
            .HasDateTime()
            .IsOptional();

        builder.Property(x => x.CanceladoEm)
            .HasColumnName("CANCELADO_EM")
            .HasDateTime()
            .IsOptional();

        builder.HasOne(x => x.Funcionario)
            .WithMany(x => x.Pedidos)
            .HasForeignKey(x => x.FuncionarioId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}