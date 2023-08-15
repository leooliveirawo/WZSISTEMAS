using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WZSISTEMAS.Migrations
{
    /// <inheritdoc />
    public partial class rv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    NomeCompleto_RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF_CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RG_InscricaoEstadual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogradourNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado_UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
