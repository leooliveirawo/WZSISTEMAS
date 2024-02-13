using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoItens : MapeamentoEntidades<Item>, IEntityTypeConfiguration<Item>
{
    public override void Configure(EntityTypeBuilder<Item> builder)
    {
        base.Configure(builder);

        builder.ToTable("ITENS");

        MapeamentoItens<Item>.Mapear(builder);

        builder.Property(x => x.DescricaoPDV)
            .HasColumnName("DESCRICAO_PDV")
            .HasString()
            .HasMaxLength(125)
            .IsOptional();

        builder.Property(x => x.CodigoAuxiliarBalanca)
            .HasColumnName("CODIGO_AUXILIAR_BALANCA")
            .HasString()
            .HasMaxLength(125)
            .IsOptional();

        builder.Property(x => x.GerarDadosAuxiliarBalanca)
            .HasColumnName("GERAR_DADOS_AUXILIAR_BALANCA")
            .HasBool()
            .IsRequired();

        builder.Property(x => x.UsarBalancaCheckout)
            .HasColumnName("USAR_BALANCA_CHECKOUT")
            .HasBool()
            .IsRequired();

        builder.Property(x => x.CustoReal)
            .HasColumnName("CUSTO_REAL")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.MargemLucro)
            .HasColumnName("MARGEM_LUCRO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.PrecoFinal)
            .HasColumnName("PRECO_FINAL")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.CustoReal2)
            .HasColumnName("CUSTO_REAL_2")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.MargemLucro2)
            .HasColumnName("MARGEM_LUCRO_2")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.PrecoFinal2)
            .HasColumnName("PRECO_FINAL_2")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.CustoReal3)
            .HasColumnName("CUSTO_REAL_3")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.MargemLucro3)
            .HasColumnName("MARGEM_LUCRO_3")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.PrecoFinal3)
            .HasColumnName("PRECO_FINAL_3")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(x => x.MultiplosPrecos)
            .HasColumnName("MULTIPLOS_PRECOS")
            .HasBool()
            .IsRequired();

        builder.Property(x => x.ModoItem)
            .HasColumnName("MODO_ITEM")
            .HasEnum()
            .IsRequired();

        builder.Property(x => x.EstoqueAtual)
            .HasColumnName("ESTOQUE_ATUAL")
            .HasInt()
            .IsRequired();

        builder.Property(x => x.EstoqueMinimo)
            .HasColumnName("ESTOQUE_MINIMO")
            .HasInt()
            .IsRequired();

        builder.Property(x => x.GerenciarEstoque)
            .HasColumnName("GERENCIAR_ESTOQUE")
            .HasBool()
            .IsRequired();

        builder.Property(x => x.NotificarEstoqueBaixo)
            .HasColumnName("NOTIFICAR_ESTOQUE_BAIXO")
            .HasBool()
            .IsRequired();
    }
}