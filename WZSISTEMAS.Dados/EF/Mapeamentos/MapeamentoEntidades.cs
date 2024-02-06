using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public abstract class MapeamentoEntidades<TEntidade> : IEntityTypeConfiguration<TEntidade> where TEntidade : Entidade
{
    public virtual void Configure(EntityTypeBuilder<TEntidade> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("ID")
            .HasLong()
            .IsRequired();
    }
}