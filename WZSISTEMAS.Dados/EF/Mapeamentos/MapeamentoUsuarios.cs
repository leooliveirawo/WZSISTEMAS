using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoUsuarios : MapeamentoEntidades<Usuario>
{
    public override void Configure(EntityTypeBuilder<Usuario> builder)
    {
        base.Configure(builder);

        builder.ToTable("USUARIOS");

        builder.Property(x => x.FuncionarioId)
            .HasColumnName("FUNCIONARIO_ID")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.NomeUsuario)
            .HasColumnName("NOME_USUARIO")
            .HasString()
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.HashSenha)
            .HasColumnName("HASH_SENHA")
            .HasString()
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.Ativo)
            .HasColumnName("ATIVO")
            .HasBool()
            .IsRequired();
    }
}