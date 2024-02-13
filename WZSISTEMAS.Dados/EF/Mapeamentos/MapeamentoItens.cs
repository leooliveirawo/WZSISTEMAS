using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoItens : MapeamentoEntidades<Item>
{
    public override void Configure(EntityTypeBuilder<Item> builder)
    {
        base.Configure(builder);

        builder.ToTable("ITENS");

        MapeamentoItens<Item>.Mapear(builder);

        builder.Property(item => item.DescricaoPDV)
            .HasColumnName("DESCRICAO_PDV")
            .HasString()
            .HasMaxLength(125)
            .IsOptional();

        builder.Property(item => item.CodigoAuxiliarBalanca)
            .HasColumnName("CODIGO_AUXILIAR_BALANCA")
            .HasString()
            .HasMaxLength(125)
            .IsOptional();

        builder.Property(item => item.GerarDadosAuxiliarBalanca)
            .HasColumnName("GERAR_DADOS_AUXILIAR_BALANCA")
            .HasBool()
            .IsRequired();

        builder.Property(item => item.UsarBalancaCheckout)
            .HasColumnName("USAR_BALANCA_CHECKOUT")
            .HasBool()
            .IsRequired();

        builder.Property(item => item.CustoReal)
            .HasColumnName("CUSTO_REAL")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(item => item.MargemLucro)
            .HasColumnName("MARGEM_LUCRO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(item => item.PrecoFinal)
            .HasColumnName("PRECO_FINAL")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(item => item.CustoReal2)
            .HasColumnName("CUSTO_REAL_2")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(item => item.MargemLucro2)
            .HasColumnName("MARGEM_LUCRO_2")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(item => item.PrecoFinal2)
            .HasColumnName("PRECO_FINAL_2")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(item => item.CustoReal3)
            .HasColumnName("CUSTO_REAL_3")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(item => item.MargemLucro3)
            .HasColumnName("MARGEM_LUCRO_3")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(item => item.PrecoFinal3)
            .HasColumnName("PRECO_FINAL_3")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsOptional();

        builder.Property(item => item.MultiplosPrecos)
            .HasColumnName("MULTIPLOS_PRECOS")
            .HasBool()
            .IsRequired();

        builder.Property(item => item.ModoItem)
            .HasColumnName("MODO_ITEM")
            .HasEnum()
            .IsRequired();

        builder.Property(item => item.EstoqueAtual)
            .HasColumnName("ESTOQUE_ATUAL")
            .HasInt()
            .IsRequired();

        builder.Property(item => item.EstoqueMinimo)
            .HasColumnName("ESTOQUE_MINIMO")
            .HasInt()
            .IsRequired();

        builder.Property(item => item.GerenciarEstoque)
            .HasColumnName("GERENCIAR_ESTOQUE")
            .HasBool()
            .IsRequired();

        builder.Property(item => item.NotificarEstoqueBaixo)
            .HasColumnName("NOTIFICAR_ESTOQUE_BAIXO")
            .HasBool()
            .IsRequired();

        builder.Property(item => item.ItemPrincipalId)
            .HasColumnName("ITEM_PRINCIPAL_ID")
            .HasLong()
            .IsOptional();

        builder.HasOne(item => item.ItemPrincipal)
            .WithMany(item => item.ItensDerivados)
            .HasForeignKey(item => item.ItemPrincipalId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsOptional();
    }
}