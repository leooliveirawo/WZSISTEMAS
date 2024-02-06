using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;
using WZSISTEMAS.Base.EF.Mapeamentos;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoFuncionarios : MapeamentoEntidades<Funcionario>
{
    public override void Configure(EntityTypeBuilder<Funcionario> builder)
    {
        base.Configure(builder);

        builder.ToTable("FUNCIONARIOS");

        builder.Property(x => x.CargoId)
            .HasColumnName("CARGO_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.NomeCompleto)
            .HasColumnName("NOME_COMPLETO")
            .HasString()
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.CPF)
            .HasColumnName("CPF")
            .HasString()
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.RG)
            .HasColumnName("RG")
            .HasString()
            .HasMaxLength(150)
            .IsOptional();

        builder.Property(x => x.DataNascimento)
            .HasColumnName("DATA_NASCIMENTO")
            .HasDateTime()
            .IsOptional();

        MapeamentoEnderecos.Mapear(builder);

        builder.Property(x => x.Referencia)
            .HasColumnName("REFERENCIA")
            .HasString()
            .HasMaxLength(150)
            .IsOptional();

        builder.HasOne(x => x.Cargo)
            .WithMany(x => x.Funcionarios)
            .HasForeignKey(x => x.CargoId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}