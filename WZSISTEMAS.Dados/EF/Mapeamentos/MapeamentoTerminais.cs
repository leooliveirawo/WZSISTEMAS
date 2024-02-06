using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoTerminais : MapeamentoEntidades<Terminal>
{
    public override void Configure(EntityTypeBuilder<Terminal> builder)
    {
        base.Configure(builder);

        builder.ToTable("TERMINAIS");

        builder.Property(x => x.EmpresaId)
            .HasColumnName("EMPRESA_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.Nome)
            .HasColumnName("NOME")
            .HasString()
            .HasMaxLength(150)
            .IsRequired();

        builder.HasOne(x => x.Empresa)
            .WithMany(x => x.Terminais)
            .HasForeignKey(x => x.EmpresaId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}