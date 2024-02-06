using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;
using WZSISTEMAS.Base.EF.Mapeamentos;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoEmpresas : MapeamentoEntidades<Empresa>
{
    public override void Configure(EntityTypeBuilder<Empresa> builder)
    {
        base.Configure(builder);

        builder.ToTable("EMPRESAS");

        builder.Property(x => x.RazaoSocial)
            .HasColumnName("RAZAO_SOCIAL")
            .HasString()
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.CNPJ)
            .HasColumnName("CNPJ")
            .HasString()
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.InscricaoEstadual)
            .HasColumnName("INSCRICAO_ESTADUAL")
            .HasString()
            .HasMaxLength(150)
            .IsRequired();

        MapeamentoEnderecos.Mapear(builder);

        builder.Property(x => x.Referencia)
            .HasColumnName("REFERENCIA")
            .HasString()
            .HasMaxLength(150)
            .IsOptional();
    }
}