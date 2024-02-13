using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Mapeamentos;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoClientes : MapeamentoEntidades<Cliente>
{
    public override void Configure(EntityTypeBuilder<Cliente> builder)
    {
        base.Configure(builder);

        builder.ToTable("CLIENTES");

        builder.Property(x => x.NomeCompleto_RazaoSocial)
            .HasColumnName("NOME_COMPLETO_RAZAO_SOCIAL")
            .HasString()
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.CPF_CNPJ)
            .HasColumnName("CPF_CNPJ")
            .HasString()
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.RG_INSCRICAO_ESTADUAL)
            .HasColumnName("RG_INSCRICAO_ESTADUAL")
            .HasString()
            .HasMaxLength(150)
            .IsOptional();

        builder.Property(x => x.DataNascimento)
            .HasColumnName("DATA_NASCIMENTO")
            .HasDateTime()
            .IsOptional();

        builder.Property(x => x.ConvenioAtivo)
            .HasColumnName("CONVENIO_ATIVO")
            .HasBool()
            .IsRequired();

        builder.Property(x => x.ConvenioInativo)
            .HasColumnName("CONVENIO_INATIVO")
            .HasBool()
            .IsRequired();

        builder.Property(x => x.ConvenioBloqueado)
            .HasColumnName("CONVENIO_BLOQUEADO")
            .HasBool()
            .IsRequired();

        builder.Property(x => x.ConvenioLimite)
            .HasColumnName("CONVENIO_LIMITE")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.ConvenioLimiteDisponivel)
            .HasColumnName("CONVENIO_LIMITE_DISPONIVEL")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.ConvenioLimiteUsado)
            .HasColumnName("CONVENIO_LIMITE_USADO)")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.FaturaDiaFechamentoVencimento)
            .HasColumnName("CONVENIO__FECHAMENTO_VENCIMENTO")
            .HasColumnType(EFMappingHelper.EnumType)
            .IsRequired();

        MapeamentoEnderecos.Mapear(builder);

        builder.Property(x => x.Referencia)
            .HasColumnName("REFERENCIA")
            .HasString()
            .HasMaxLength(150)
            .IsOptional();
    }
}