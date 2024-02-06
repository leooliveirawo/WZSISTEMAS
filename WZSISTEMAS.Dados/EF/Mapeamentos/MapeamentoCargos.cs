using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoCargos : MapeamentoEntidades<Cargo>
{
    public override void Configure(EntityTypeBuilder<Cargo> builder)
    {
        base.Configure(builder);

        builder.ToTable("CARGOS");

        builder.Property(x => x.Nome)
            .HasColumnName("NOME")
            .HasString()
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.Descricao)
            .HasColumnName("DESCRICAO")
            .HasString()
            .HasMaxLength(150)
            .IsOptional();
    }
}