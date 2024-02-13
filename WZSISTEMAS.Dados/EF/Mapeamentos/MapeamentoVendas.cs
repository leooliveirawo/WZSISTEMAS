using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoVendas : MapeamentoEntidades<Venda>
{
    public override void Configure(EntityTypeBuilder<Venda> builder)
    {
        base.Configure(builder);

        builder.ToTable("VENDAS");

        builder.Property(x => x.CaixaId)
            .HasColumnName("CAIXA_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.Volume)
            .HasColumnName("VOLUME")
            .HasLong()
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

        builder.Property(x => x.Troco)
            .HasColumnName("TROCO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.CPF_CNPJ_Nota)
            .HasColumnName("CPF_CNPJ_NOTA")
            .HasString()
            .HasMaxLength(150)
            .IsOptional();

        builder.Property(x => x.AbertaEm)
            .HasColumnName("ABERTA_EM")
            .HasDateTime()
            .IsRequired();

        builder.Property(x => x.FechadaEm)
            .HasColumnName("FECHADA_EM")
            .HasDateTime()
            .IsOptional();

        builder.Property(x => x.CanceladaEm)
            .HasColumnName("CANCELADA_EM")
            .HasDateTime()
            .IsOptional();

        builder.Property(x => x.EmEspera)
            .HasColumnName("EM_ESPERA")
            .HasBool()
            .IsRequired();

        builder.Property(x => x.CFeXml)
            .HasColumnName("CFE_XML")
            .HasString()
            .HasMaxLength()
            .IsOptional();

        builder.HasOne(x => x.Caixa)
            .WithMany(x => x.Vendas)
            .HasForeignKey(x => x.CaixaId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}