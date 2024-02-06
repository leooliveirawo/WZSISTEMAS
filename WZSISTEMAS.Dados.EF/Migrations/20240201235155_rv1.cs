using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WZSISTEMAS.Dados.EF.Migrations
{
    /// <inheritdoc />
    public partial class rv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CARGOS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARGOS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CLIENTES",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    NOME_COMPLETO_RAZAO_SOCIAL = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    CPF_CNPJ = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    RG_INSCRICAO_ESTADUAL = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    LOGRADOURO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    LOGRADOURO_NUMERO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    COMPLEMENTO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    REFERENCIA = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    CEP = table.Column<string>(type: "VARCHAR(9)", maxLength: 9, nullable: false),
                    BAIRRO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CIDADE = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    UF = table.Column<int>(type: "INT", nullable: false),
                    PAIS = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    TELEFONE = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    TELEFONE_2 = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    TELEFONE_3 = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    EMAIL = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true),
                    CONVENIO_ATIVO = table.Column<bool>(type: "BIT", nullable: false),
                    CONVENIO_INATIVO = table.Column<bool>(type: "BIT", nullable: false),
                    CONVENIO_BLOQUEADO = table.Column<bool>(type: "BIT", nullable: false),
                    CONVENIO_LIMITE = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    CONVENIO_LIMITE_DISPONIVEL = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    CONVENIO_LIMITE_USADO = table.Column<decimal>(name: "CONVENIO_LIMITE_USADO)", type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    CONVENIO__FECHAMENTO_VENCIMENTO = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EMPRESAS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RAZAO_SOCIAL = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    CodigoReferencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    INSCRICAO_ESTADUAL = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    LOGRADOURO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    LOGRADOURO_NUMERO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    COMPLEMENTO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    REFERENCIA = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    CEP = table.Column<string>(type: "VARCHAR(9)", maxLength: 9, nullable: false),
                    BAIRRO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CIDADE = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    UF = table.Column<int>(type: "INT", nullable: false),
                    PAIS = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    TELEFONE = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    TELEFONE_2 = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    TELEFONE_3 = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    EMAIL = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPRESAS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FORNECEDORES",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RAZAO_SOCIAL = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    INSCRICAO_ESTADUAL = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    LOGRADOURO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    LOGRADOURO_NUMERO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    COMPLEMENTO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    REFERENCIA = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    CEP = table.Column<string>(type: "VARCHAR(9)", maxLength: 9, nullable: false),
                    BAIRRO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CIDADE = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    UF = table.Column<int>(type: "INT", nullable: false),
                    PAIS = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    TELEFONE = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    TELEFONE_2 = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    TELEFONE_3 = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    EMAIL = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORNECEDORES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ITENS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO_BARRAS = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CODIGO_REFERENCIA = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    DESCRICAO_PDV = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    CODIGO_AUXILIAR_BALANCA = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    GERAR_DADOS_AUXILIAR_BALANCA = table.Column<bool>(type: "BIT", nullable: false),
                    USAR_BALANCA_CHECKOUT = table.Column<bool>(type: "BIT", nullable: false),
                    CUSTO_REAL = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    MARGEM_LUCRO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    PRECO_FINAL = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    CUSTO_REAL_2 = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    MARGEM_LUCRO_2 = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    PRECO_FINAL_2 = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    CUSTO_REAL_3 = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    MARGEM_LUCRO_3 = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    PRECO_FINAL_3 = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    MULTIPLOS_PRECOS = table.Column<bool>(type: "BIT", nullable: false),
                    TIPO_ITEM = table.Column<int>(type: "INT", nullable: false),
                    MODO_ITEM = table.Column<int>(type: "INT", nullable: false),
                    UNIDADE_MEDIDA = table.Column<int>(type: "INT", nullable: false),
                    ESTOQUE_ATUAL = table.Column<int>(type: "INT", nullable: false),
                    ESTOQUE_MINIMO = table.Column<int>(type: "INT", nullable: false),
                    GERENCIAR_ESTOQUE = table.Column<bool>(type: "BIT", nullable: false),
                    NOTIFICAR_ESTOQUE_BAIXO = table.Column<bool>(type: "BIT", nullable: false),
                    NCM = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CFOP = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    TIPO_ICMS = table.Column<long>(type: "BIGINT", nullable: false),
                    ICMS = table.Column<string>(type: "VARCHAR(max)", maxLength: -1, nullable: false),
                    TIPO_PIS = table.Column<long>(type: "BIGINT", nullable: false),
                    PIS = table.Column<string>(type: "VARCHAR(max)", maxLength: -1, nullable: false),
                    TIPO_COFINS = table.Column<long>(type: "BIGINT", nullable: false),
                    COFINS = table.Column<string>(type: "VARCHAR(max)", maxLength: -1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITENS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TRANSPORTADORAS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO_REFERENCIA = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    RAZAO_SOCIAL = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    INSCRICAO_ESTADUAL = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    LOGRADOURO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    LOGRADOURO_NUMERO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    COMPLEMENTO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    REFERENCIA = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    CEP = table.Column<string>(type: "VARCHAR(9)", maxLength: 9, nullable: false),
                    BAIRRO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CIDADE = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    UF = table.Column<int>(type: "INT", nullable: false),
                    PAIS = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    TELEFONE = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    TELEFONE_2 = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    TELEFONE_3 = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    EMAIL = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSPORTADORAS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FUNCIONARIOS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARGO_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    NOME_COMPLETO = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    RG = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    LOGRADOURO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    LOGRADOURO_NUMERO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    COMPLEMENTO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    REFERENCIA = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    CEP = table.Column<string>(type: "VARCHAR(9)", maxLength: 9, nullable: false),
                    BAIRRO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CIDADE = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    UF = table.Column<int>(type: "INT", nullable: false),
                    PAIS = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    TELEFONE = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    TELEFONE_2 = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    TELEFONE_3 = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    EMAIL = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCIONARIOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FUNCIONARIOS_CARGOS_CARGO_ID",
                        column: x => x.CARGO_ID,
                        principalTable: "CARGOS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CLIENTES_FATURAS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CLIENTE_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    DIA_FECHAMENTO_VENCIMENTO = table.Column<int>(type: "INT", nullable: false),
                    MES_REFERENTE = table.Column<int>(type: "INT", nullable: false),
                    ANO_REFERENTE = table.Column<int>(type: "INT", nullable: false),
                    VALOR_FATURA = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    PARCIALMENTE_PAGO = table.Column<bool>(type: "BIT", nullable: false),
                    PAGO = table.Column<bool>(type: "BIT", nullable: false),
                    VALOR_RESTANTE = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    VALOR_PAGO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES_FATURAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CLIENTES_FATURAS_CLIENTES_CLIENTE_ID",
                        column: x => x.CLIENTE_ID,
                        principalTable: "CLIENTES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TERMINAIS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMPRESA_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    NOME = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TERMINAIS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TERMINAIS_EMPRESAS_EMPRESA_ID",
                        column: x => x.EMPRESA_ID,
                        principalTable: "EMPRESAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PEDIDOS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<long>(type: "BIGINT", nullable: false),
                    VALOR_TOTAL = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    VALOR_TOTAL_DESCONTO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    VOLUME = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ABERTO_EM = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    FINALIZADO_EM = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    CANCELADO_EM = table.Column<DateTime>(type: "DATETIME2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PEDIDOS_FUNCIONARIOS_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "FUNCIONARIOS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FUNCIONARIO_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    NOME_USUARIO = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    HASH_SENHA = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    ATIVO = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_USUARIOS_FUNCIONARIOS_FUNCIONARIO_ID",
                        column: x => x.FUNCIONARIO_ID,
                        principalTable: "FUNCIONARIOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ENTRADAS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATA_EMISSAO = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    DATA_SAIDA = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    DATA_ENTRADA = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    TERMINAL_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    EMITENTE_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    TRANSPORTADORA_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    DESTINATARIO_ID = table.Column<long>(type: "BIGINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENTRADAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ENTRADAS_EMPRESAS_DESTINATARIO_ID",
                        column: x => x.DESTINATARIO_ID,
                        principalTable: "EMPRESAS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ENTRADAS_FORNECEDORES_EMITENTE_ID",
                        column: x => x.EMITENTE_ID,
                        principalTable: "FORNECEDORES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ENTRADAS_TERMINAIS_TERMINAL_ID",
                        column: x => x.TERMINAL_ID,
                        principalTable: "TERMINAIS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ENTRADAS_TRANSPORTADORAS_TRANSPORTADORA_ID",
                        column: x => x.TRANSPORTADORA_ID,
                        principalTable: "TRANSPORTADORAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PEDIDOS_ITENS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PEDIDO_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    ITEM_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    CANCELADO_EM = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    VALOR_UNITARIO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    VALOR_UNITARIO_DESCONTO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    QUANTIDADE = table.Column<decimal>(type: "DECIMAL(18,3)", precision: 18, scale: 3, nullable: false),
                    VALOR_TOTAL = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    VALOR_TOTAL_DESCONTO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CODIGO_BARRAS = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CODIGO_REFERENCIA = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    UNIDADE_MEDIDA = table.Column<int>(type: "INT", nullable: false),
                    TIPO_ITEM = table.Column<int>(type: "INT", nullable: false),
                    NCM = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CFOP = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    TIPO_ICMS = table.Column<long>(type: "BIGINT", nullable: false),
                    ICMS = table.Column<string>(type: "VARCHAR(max)", maxLength: -1, nullable: false),
                    TIPO_PIS = table.Column<long>(type: "BIGINT", nullable: false),
                    PIS = table.Column<string>(type: "VARCHAR(max)", maxLength: -1, nullable: false),
                    TIPO_COFINS = table.Column<long>(type: "BIGINT", nullable: false),
                    COFINS = table.Column<string>(type: "VARCHAR(max)", maxLength: -1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDOS_ITENS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PEDIDOS_ITENS_ITENS_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "ITENS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PEDIDOS_ITENS_PEDIDOS_PEDIDO_ID",
                        column: x => x.PEDIDO_ID,
                        principalTable: "PEDIDOS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CAIXAS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USUARIO_ID = table.Column<long>(type: "BIGINT", maxLength: 125, nullable: false),
                    TERMINAL_ID = table.Column<long>(type: "BIGINT", maxLength: 125, nullable: false),
                    STATUS = table.Column<int>(type: "INT", maxLength: 125, nullable: false),
                    ABERTO_EM = table.Column<DateTime>(type: "DATETIME2", maxLength: 125, nullable: false),
                    FECHADO_EM = table.Column<DateTime>(type: "DATETIME2", maxLength: 125, nullable: true),
                    CANCELADO_EM = table.Column<DateTime>(type: "DATETIME2", maxLength: 125, nullable: true),
                    MOTIVO_CANCELAMENTO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    SALDO_INICIAL = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SALDO_SUPRIMENTO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SALDO_FINAL = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SALDO_DINHEIRO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SALDO_CHEQUE = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SALDO_OUTROS = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SUPRIMENTO_DINHEIRO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SUPRIMENTO_OUTROS = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SUPRIMENTO_CHEQUE = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SUPRIMENTO_CANCELADO_DINHEIRO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SUPRIMENTO_CANCELADO_CHEQUE = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SUPRIMENTO_CANCELADO_OUTROS = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_DINHEIRO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_CARTAO_CREDITO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_CARTAO_DEBITO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_CARTAO_CONVENIO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_CARTAO_VOUCHER = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_CHEQUE = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_OUTROS = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_CANCELADA_DINHEIRO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_CANCELADA_CARTAO_CREDITO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_CANCELADA_CARTAO_DEBITO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_CANCELADA_CARTAO_CONVENIO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_CANCELADA_CARTAO_VOUCHER = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_CANCELADA_CHEQUE = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    ENTRADA_CANCELADA_OUTROS = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SAIDA_DINHEIRO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SAIDA_CHEQUE = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SAIDA_OUTROS = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SAIDA_CANCELADA_DINHEIRO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SAIDA_CANCELADA_CHEQUE = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    SAIDA_CANCELADA_OUTROS = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAIXAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CAIXAS_TERMINAIS_TERMINAL_ID",
                        column: x => x.TERMINAL_ID,
                        principalTable: "TERMINAIS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CAIXAS_USUARIOS_USUARIO_ID",
                        column: x => x.USUARIO_ID,
                        principalTable: "USUARIOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ENTRADAS_ITENS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ENTRADA_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    PRODUTO_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    CODIGO_PRODUTO = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    UNIDADE_MEDIDA_ORIGEM = table.Column<int>(type: "INT", nullable: false),
                    UNIDADE_MEDIDA_DESTINO = table.Column<int>(type: "INT", nullable: false),
                    UNIDADE_MEDIDA_CONVERSAO = table.Column<int>(type: "INT", nullable: false),
                    VALOR_UNITARIO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    QUANTIDADE = table.Column<decimal>(type: "DECIMAL(18,3)", precision: 18, scale: 3, nullable: false),
                    VALOR_TOTAL = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENTRADAS_ITENS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ENTRADAS_ITENS_ENTRADAS_ENTRADA_ID",
                        column: x => x.ENTRADA_ID,
                        principalTable: "ENTRADAS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ENTRADAS_ITENS_ITENS_PRODUTO_ID",
                        column: x => x.PRODUTO_ID,
                        principalTable: "ITENS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ENTRADAS_CAIXAS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAIXA_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    DATA_ENTRADA = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    TIPO = table.Column<int>(type: "INT", nullable: false),
                    VALOR = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    CANCELADA_EM = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    FOI_CANCELADA = table.Column<bool>(type: "BIT", nullable: false),
                    MOTIVO_CANCELAMENTO = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENTRADAS_CAIXAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ENTRADAS_CAIXAS_CAIXAS_CAIXA_ID",
                        column: x => x.CAIXA_ID,
                        principalTable: "CAIXAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SAIDAS_CAIXAS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAIXA_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    DATA_SAIDA = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    TIPO = table.Column<int>(type: "INT", nullable: false),
                    VALOR = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    FOI_CANCELADA = table.Column<bool>(type: "BIT", nullable: false),
                    CANCELADA_EM = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    MOTIVO_CANCELAMENTO = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAIDAS_CAIXAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SAIDAS_CAIXAS_CAIXAS_CAIXA_ID",
                        column: x => x.CAIXA_ID,
                        principalTable: "CAIXAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SUPRIMENTOS_CAIXAS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAIXA_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    TIPO = table.Column<int>(type: "INT", nullable: false),
                    DATA_SUPRIMENTO = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    VALOR = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    FOI_CANCELADO = table.Column<bool>(type: "BIT", nullable: false),
                    CANCELADO_EM = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    MOTIVO_CANCELAMENTO = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUPRIMENTOS_CAIXAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SUPRIMENTOS_CAIXAS_CAIXAS_CAIXA_ID",
                        column: x => x.CAIXA_ID,
                        principalTable: "CAIXAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "VENDAS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAIXA_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    VOLUME = table.Column<long>(type: "BIGINT", nullable: false),
                    VALOR_TOTAL = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    VALOR_TOTAL_DESCONTO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    TROCO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    CPF_CNPJ_NOTA = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    ABERTA_EM = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    FECHADA_EM = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    CANCELADA_EM = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    EM_ESPERA = table.Column<bool>(type: "BIT", nullable: false),
                    CFE_XML = table.Column<string>(type: "VARCHAR(max)", maxLength: -1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENDAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VENDAS_CAIXAS_CAIXA_ID",
                        column: x => x.CAIXA_ID,
                        principalTable: "CAIXAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "VENDAS_ITENS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VENDA_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    ITEM_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    CANCELADO_EM = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CODIGO_BARRAS = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CODIGO_REFERENCIA = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: true),
                    UNIDADE_MEDIDA = table.Column<int>(type: "INT", nullable: false),
                    TIPO_ITEM = table.Column<int>(type: "INT", nullable: false),
                    NCM = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    CFOP = table.Column<string>(type: "VARCHAR(125)", maxLength: 125, nullable: false),
                    TIPO_ICMS = table.Column<long>(type: "BIGINT", nullable: false),
                    ICMS = table.Column<string>(type: "VARCHAR(max)", maxLength: -1, nullable: false),
                    TIPO_PIS = table.Column<long>(type: "BIGINT", nullable: false),
                    PIS = table.Column<string>(type: "VARCHAR(max)", maxLength: -1, nullable: false),
                    TIPO_COFINS = table.Column<long>(type: "BIGINT", nullable: false),
                    COFINS = table.Column<string>(type: "VARCHAR(max)", maxLength: -1, nullable: false),
                    VALOR_UNITARIO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    VALOR_UNITARIO_DESCONTO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true),
                    QUANTIDADE = table.Column<decimal>(type: "DECIMAL(18,3)", precision: 18, scale: 3, nullable: false),
                    VALOR_TOTAL = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    VALOR_TOTAL_DESCONTO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENDAS_ITENS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VENDAS_ITENS_ITENS_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "ITENS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_VENDAS_ITENS_VENDAS_VENDA_ID",
                        column: x => x.VENDA_ID,
                        principalTable: "VENDAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "VENDAS_PAGAMENTOS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VENDA_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    CAIXA_ENTRADA_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    CANCELADO_EM = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    TIPO = table.Column<int>(type: "INT", nullable: false),
                    VALOR_PAGO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    VALOR_PAGO_LIQUIDO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENDAS_PAGAMENTOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VENDAS_PAGAMENTOS_ENTRADAS_CAIXAS_CAIXA_ENTRADA_ID",
                        column: x => x.CAIXA_ENTRADA_ID,
                        principalTable: "ENTRADAS_CAIXAS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_VENDAS_PAGAMENTOS_VENDAS_VENDA_ID",
                        column: x => x.VENDA_ID,
                        principalTable: "VENDAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CLIENTES_LANCAMENTOS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FATURA_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    VENDA_PAGAMENTO_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    CRIADO_EM = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    VALOR_LANCAMENTO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    PARCIALMENTE_PAGO = table.Column<bool>(type: "BIT", nullable: false),
                    PAGO = table.Column<bool>(type: "BIT", nullable: false),
                    VALOR_RESTANTE = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false),
                    VALOR_PAGO = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES_LANCAMENTOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CLIENTES_LANCAMENTOS_CLIENTES_FATURAS_FATURA_ID",
                        column: x => x.FATURA_ID,
                        principalTable: "CLIENTES_FATURAS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CLIENTES_LANCAMENTOS_VENDAS_PAGAMENTOS_VENDA_PAGAMENTO_ID",
                        column: x => x.VENDA_PAGAMENTO_ID,
                        principalTable: "VENDAS_PAGAMENTOS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CAIXAS_TERMINAL_ID",
                table: "CAIXAS",
                column: "TERMINAL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CAIXAS_USUARIO_ID",
                table: "CAIXAS",
                column: "USUARIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CLIENTES_FATURAS_CLIENTE_ID",
                table: "CLIENTES_FATURAS",
                column: "CLIENTE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CLIENTES_LANCAMENTOS_FATURA_ID",
                table: "CLIENTES_LANCAMENTOS",
                column: "FATURA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CLIENTES_LANCAMENTOS_VENDA_PAGAMENTO_ID",
                table: "CLIENTES_LANCAMENTOS",
                column: "VENDA_PAGAMENTO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENTRADAS_DESTINATARIO_ID",
                table: "ENTRADAS",
                column: "DESTINATARIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENTRADAS_EMITENTE_ID",
                table: "ENTRADAS",
                column: "EMITENTE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENTRADAS_TERMINAL_ID",
                table: "ENTRADAS",
                column: "TERMINAL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENTRADAS_TRANSPORTADORA_ID",
                table: "ENTRADAS",
                column: "TRANSPORTADORA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENTRADAS_CAIXAS_CAIXA_ID",
                table: "ENTRADAS_CAIXAS",
                column: "CAIXA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENTRADAS_ITENS_ENTRADA_ID",
                table: "ENTRADAS_ITENS",
                column: "ENTRADA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENTRADAS_ITENS_PRODUTO_ID",
                table: "ENTRADAS_ITENS",
                column: "PRODUTO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FUNCIONARIOS_CARGO_ID",
                table: "FUNCIONARIOS",
                column: "CARGO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDOS_FuncionarioId",
                table: "PEDIDOS",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDOS_ITENS_ITEM_ID",
                table: "PEDIDOS_ITENS",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDOS_ITENS_PEDIDO_ID",
                table: "PEDIDOS_ITENS",
                column: "PEDIDO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SAIDAS_CAIXAS_CAIXA_ID",
                table: "SAIDAS_CAIXAS",
                column: "CAIXA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SUPRIMENTOS_CAIXAS_CAIXA_ID",
                table: "SUPRIMENTOS_CAIXAS",
                column: "CAIXA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TERMINAIS_EMPRESA_ID",
                table: "TERMINAIS",
                column: "EMPRESA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIOS_FUNCIONARIO_ID",
                table: "USUARIOS",
                column: "FUNCIONARIO_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VENDAS_CAIXA_ID",
                table: "VENDAS",
                column: "CAIXA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_VENDAS_ITENS_ITEM_ID",
                table: "VENDAS_ITENS",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_VENDAS_ITENS_VENDA_ID",
                table: "VENDAS_ITENS",
                column: "VENDA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_VENDAS_PAGAMENTOS_CAIXA_ENTRADA_ID",
                table: "VENDAS_PAGAMENTOS",
                column: "CAIXA_ENTRADA_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VENDAS_PAGAMENTOS_VENDA_ID",
                table: "VENDAS_PAGAMENTOS",
                column: "VENDA_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENTES_LANCAMENTOS");

            migrationBuilder.DropTable(
                name: "ENTRADAS_ITENS");

            migrationBuilder.DropTable(
                name: "PEDIDOS_ITENS");

            migrationBuilder.DropTable(
                name: "SAIDAS_CAIXAS");

            migrationBuilder.DropTable(
                name: "SUPRIMENTOS_CAIXAS");

            migrationBuilder.DropTable(
                name: "VENDAS_ITENS");

            migrationBuilder.DropTable(
                name: "CLIENTES_FATURAS");

            migrationBuilder.DropTable(
                name: "VENDAS_PAGAMENTOS");

            migrationBuilder.DropTable(
                name: "ENTRADAS");

            migrationBuilder.DropTable(
                name: "PEDIDOS");

            migrationBuilder.DropTable(
                name: "ITENS");

            migrationBuilder.DropTable(
                name: "CLIENTES");

            migrationBuilder.DropTable(
                name: "ENTRADAS_CAIXAS");

            migrationBuilder.DropTable(
                name: "VENDAS");

            migrationBuilder.DropTable(
                name: "FORNECEDORES");

            migrationBuilder.DropTable(
                name: "TRANSPORTADORAS");

            migrationBuilder.DropTable(
                name: "CAIXAS");

            migrationBuilder.DropTable(
                name: "TERMINAIS");

            migrationBuilder.DropTable(
                name: "USUARIOS");

            migrationBuilder.DropTable(
                name: "EMPRESAS");

            migrationBuilder.DropTable(
                name: "FUNCIONARIOS");

            migrationBuilder.DropTable(
                name: "CARGOS");
        }
    }
}
