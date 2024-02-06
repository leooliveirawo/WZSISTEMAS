using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;

namespace WZSISTEMAS.Dados.EF.Mapeamentos;

public class MapeamentoCaixas : MapeamentoEntidades<Caixa>
{
    public override void Configure(EntityTypeBuilder<Caixa> builder)
    {
        base.Configure(builder);

        builder.ToTable("CAIXAS");

        builder.Property(x => x.UsuarioId)
            .HasColumnName("USUARIO_ID")
            .HasLong()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.TerminalId)
            .HasColumnName("TERMINAL_ID")
            .HasLong()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.Status)
            .HasColumnName("STATUS")
            .HasEnum()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.AbertoEm)
            .HasColumnName("ABERTO_EM")
            .HasDateTime()
            .HasMaxLength(125)
            .IsRequired();

        builder.Property(x => x.FechadoEm)
            .HasColumnName("FECHADO_EM")
            .HasDateTime()
            .HasMaxLength(125)
            .IsOptional();

        builder.Property(x => x.CanceladoEm)
            .HasColumnName("CANCELADO_EM")
            .HasDateTime()
            .HasMaxLength(125)
            .IsOptional();

        builder.Property(x => x.MotivoCancelamento)
            .HasColumnName("MOTIVO_CANCELAMENTO")
            .HasString()
            .HasMaxLength(125)
            .IsOptional();

        builder.Property(x => x.SaldoInicial)
            .HasColumnName("SALDO_INICIAL")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SaldoSuprimento)
            .HasColumnName("SALDO_SUPRIMENTO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SaldoFinal)
            .HasColumnName("SALDO_FINAL")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SaldoDinheiro)
            .HasColumnName("SALDO_DINHEIRO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SaldoCheque)
            .HasColumnName("SALDO_CHEQUE")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SaldoOutros)
            .HasColumnName("SALDO_OUTROS")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SuprimentoDinheiro)
            .HasColumnName("SUPRIMENTO_DINHEIRO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SuprimentoOutros)
            .HasColumnName("SUPRIMENTO_OUTROS")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SuprimentoCheque)
            .HasColumnName("SUPRIMENTO_CHEQUE")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SuprimentoCanceladoDinheiro)
            .HasColumnName("SUPRIMENTO_CANCELADO_DINHEIRO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SuprimentoCanceladoOutros)
            .HasColumnName("SUPRIMENTO_CANCELADO_OUTROS")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SuprimentoCanceladoCheque)
            .HasColumnName("SUPRIMENTO_CANCELADO_CHEQUE")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaDinheiro)
            .HasColumnName("ENTRADA_DINHEIRO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaCartaoCredito)
            .HasColumnName("ENTRADA_CARTAO_CREDITO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaCartaoDebito)
            .HasColumnName("ENTRADA_CARTAO_DEBITO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaCartaoConvenio)
            .HasColumnName("ENTRADA_CARTAO_CONVENIO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaCartaoVoucher)
            .HasColumnName("ENTRADA_CARTAO_VOUCHER")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaOutros)
            .HasColumnName("ENTRADA_OUTROS")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaCheque)
            .HasColumnName("ENTRADA_CHEQUE")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaCanceladaDinheiro)
            .HasColumnName("ENTRADA_CANCELADA_DINHEIRO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaCanceladaCartaoCredito)
            .HasColumnName("ENTRADA_CANCELADA_CARTAO_CREDITO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaCanceladaCartaoDebito)
            .HasColumnName("ENTRADA_CANCELADA_CARTAO_DEBITO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaCanceladaCartaoConvenio)
            .HasColumnName("ENTRADA_CANCELADA_CARTAO_CONVENIO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaCanceladaCartaoVoucher)
            .HasColumnName("ENTRADA_CANCELADA_CARTAO_VOUCHER")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaCanceladaOutros)
            .HasColumnName("ENTRADA_CANCELADA_OUTROS")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.EntradaCanceladaCheque)
            .HasColumnName("ENTRADA_CANCELADA_CHEQUE")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SaidaDinheiro)
            .HasColumnName("SAIDA_DINHEIRO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SaidaOutros)
            .HasColumnName("SAIDA_OUTROS")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SaidaCheque)
            .HasColumnName("SAIDA_CHEQUE")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SaidaCanceladaDinheiro)
            .HasColumnName("SAIDA_CANCELADA_DINHEIRO")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SaidaCanceladaOutros)
            .HasColumnName("SAIDA_CANCELADA_OUTROS")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.SaidaCanceladaCheque)
            .HasColumnName("SAIDA_CANCELADA_CHEQUE")
            .HasDecimal()
            .HasPrecision(18, 2)
            .IsRequired();
    }
}