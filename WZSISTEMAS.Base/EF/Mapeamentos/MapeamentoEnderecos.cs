using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Interfaces;

namespace WZSISTEMAS.Base.EF.Mapeamentos;
public static class MapeamentoEnderecos
{
    public static void Mapear<T>(EntityTypeBuilder<T> builder)
        where T : class, IEnderecoCompleto
    {
        builder.Property(x => x.Logradouro)
            .HasColumnName("LOGRADOURO")
            .HasString()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.LogradouroNumero)
            .HasColumnName("LOGRADOURO_NUMERO")
            .HasString()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.Complemento)
            .HasColumnName("COMPLEMENTO")
            .HasString()
            .HasMaxLength(125)
            .IsOptional();

        builder.Property(x => x.CEP)
            .HasColumnName("CEP")
            .HasString()
            .HasMaxLength(9)
            .IsRequired();

        builder.Property(x => x.Bairro)
            .HasColumnName("BAIRRO")
            .HasString()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.Cidade)
            .HasColumnName("CIDADE")
            .HasString()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.UF)
            .HasColumnName("UF")
            .HasEnum()
            .IsRequired();

        builder.Property(x => x.Pais)
            .HasColumnName("PAIS")
            .HasString()
            .HasMaxLength(125)
            .IsOptional();

        builder.Property(x => x.Telefone)
            .HasColumnName("TELEFONE")
            .HasString()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.Telefone2)
            .HasColumnName("TELEFONE_2")
            .HasString()
            .HasMaxLength(125)
            .IsOptional();

        builder.Property(x => x.Telefone3)
            .HasColumnName("TELEFONE_3")
            .HasString()
            .HasMaxLength(125)
            .IsOptional();

        builder.Property(x => x.Email)
            .HasColumnName("EMAIL")
            .HasString()
            .HasMaxLength(255)
            .IsOptional();
    }
}
