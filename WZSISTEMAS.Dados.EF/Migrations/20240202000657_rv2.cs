using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WZSISTEMAS.Dados.EF.Migrations
{
    /// <inheritdoc />
    public partial class rv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ENTRADAS_CAIXAS_CAIXAS_CAIXA_ID",
                table: "ENTRADAS_CAIXAS");

            migrationBuilder.DropForeignKey(
                name: "FK_SAIDAS_CAIXAS_CAIXAS_CAIXA_ID",
                table: "SAIDAS_CAIXAS");

            migrationBuilder.DropForeignKey(
                name: "FK_SUPRIMENTOS_CAIXAS_CAIXAS_CAIXA_ID",
                table: "SUPRIMENTOS_CAIXAS");

            migrationBuilder.DropForeignKey(
                name: "FK_VENDAS_PAGAMENTOS_ENTRADAS_CAIXAS_CAIXA_ENTRADA_ID",
                table: "VENDAS_PAGAMENTOS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SUPRIMENTOS_CAIXAS",
                table: "SUPRIMENTOS_CAIXAS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SAIDAS_CAIXAS",
                table: "SAIDAS_CAIXAS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ENTRADAS_CAIXAS",
                table: "ENTRADAS_CAIXAS");

            migrationBuilder.RenameTable(
                name: "SUPRIMENTOS_CAIXAS",
                newName: "CAIXAS_SUPRIMENTOS");

            migrationBuilder.RenameTable(
                name: "SAIDAS_CAIXAS",
                newName: "CAIXAS_SAIDAS");

            migrationBuilder.RenameTable(
                name: "ENTRADAS_CAIXAS",
                newName: "CAIXAS_ENTRADAS");

            migrationBuilder.RenameIndex(
                name: "IX_SUPRIMENTOS_CAIXAS_CAIXA_ID",
                table: "CAIXAS_SUPRIMENTOS",
                newName: "IX_CAIXAS_SUPRIMENTOS_CAIXA_ID");

            migrationBuilder.RenameIndex(
                name: "IX_SAIDAS_CAIXAS_CAIXA_ID",
                table: "CAIXAS_SAIDAS",
                newName: "IX_CAIXAS_SAIDAS_CAIXA_ID");

            migrationBuilder.RenameIndex(
                name: "IX_ENTRADAS_CAIXAS_CAIXA_ID",
                table: "CAIXAS_ENTRADAS",
                newName: "IX_CAIXAS_ENTRADAS_CAIXA_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAIXAS_SUPRIMENTOS",
                table: "CAIXAS_SUPRIMENTOS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAIXAS_SAIDAS",
                table: "CAIXAS_SAIDAS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAIXAS_ENTRADAS",
                table: "CAIXAS_ENTRADAS",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CAIXAS_ENTRADAS_CAIXAS_CAIXA_ID",
                table: "CAIXAS_ENTRADAS",
                column: "CAIXA_ID",
                principalTable: "CAIXAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CAIXAS_SAIDAS_CAIXAS_CAIXA_ID",
                table: "CAIXAS_SAIDAS",
                column: "CAIXA_ID",
                principalTable: "CAIXAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CAIXAS_SUPRIMENTOS_CAIXAS_CAIXA_ID",
                table: "CAIXAS_SUPRIMENTOS",
                column: "CAIXA_ID",
                principalTable: "CAIXAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_VENDAS_PAGAMENTOS_CAIXAS_ENTRADAS_CAIXA_ENTRADA_ID",
                table: "VENDAS_PAGAMENTOS",
                column: "CAIXA_ENTRADA_ID",
                principalTable: "CAIXAS_ENTRADAS",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAIXAS_ENTRADAS_CAIXAS_CAIXA_ID",
                table: "CAIXAS_ENTRADAS");

            migrationBuilder.DropForeignKey(
                name: "FK_CAIXAS_SAIDAS_CAIXAS_CAIXA_ID",
                table: "CAIXAS_SAIDAS");

            migrationBuilder.DropForeignKey(
                name: "FK_CAIXAS_SUPRIMENTOS_CAIXAS_CAIXA_ID",
                table: "CAIXAS_SUPRIMENTOS");

            migrationBuilder.DropForeignKey(
                name: "FK_VENDAS_PAGAMENTOS_CAIXAS_ENTRADAS_CAIXA_ENTRADA_ID",
                table: "VENDAS_PAGAMENTOS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAIXAS_SUPRIMENTOS",
                table: "CAIXAS_SUPRIMENTOS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAIXAS_SAIDAS",
                table: "CAIXAS_SAIDAS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAIXAS_ENTRADAS",
                table: "CAIXAS_ENTRADAS");

            migrationBuilder.RenameTable(
                name: "CAIXAS_SUPRIMENTOS",
                newName: "SUPRIMENTOS_CAIXAS");

            migrationBuilder.RenameTable(
                name: "CAIXAS_SAIDAS",
                newName: "SAIDAS_CAIXAS");

            migrationBuilder.RenameTable(
                name: "CAIXAS_ENTRADAS",
                newName: "ENTRADAS_CAIXAS");

            migrationBuilder.RenameIndex(
                name: "IX_CAIXAS_SUPRIMENTOS_CAIXA_ID",
                table: "SUPRIMENTOS_CAIXAS",
                newName: "IX_SUPRIMENTOS_CAIXAS_CAIXA_ID");

            migrationBuilder.RenameIndex(
                name: "IX_CAIXAS_SAIDAS_CAIXA_ID",
                table: "SAIDAS_CAIXAS",
                newName: "IX_SAIDAS_CAIXAS_CAIXA_ID");

            migrationBuilder.RenameIndex(
                name: "IX_CAIXAS_ENTRADAS_CAIXA_ID",
                table: "ENTRADAS_CAIXAS",
                newName: "IX_ENTRADAS_CAIXAS_CAIXA_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SUPRIMENTOS_CAIXAS",
                table: "SUPRIMENTOS_CAIXAS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SAIDAS_CAIXAS",
                table: "SAIDAS_CAIXAS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ENTRADAS_CAIXAS",
                table: "ENTRADAS_CAIXAS",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ENTRADAS_CAIXAS_CAIXAS_CAIXA_ID",
                table: "ENTRADAS_CAIXAS",
                column: "CAIXA_ID",
                principalTable: "CAIXAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SAIDAS_CAIXAS_CAIXAS_CAIXA_ID",
                table: "SAIDAS_CAIXAS",
                column: "CAIXA_ID",
                principalTable: "CAIXAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SUPRIMENTOS_CAIXAS_CAIXAS_CAIXA_ID",
                table: "SUPRIMENTOS_CAIXAS",
                column: "CAIXA_ID",
                principalTable: "CAIXAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_VENDAS_PAGAMENTOS_ENTRADAS_CAIXAS_CAIXA_ENTRADA_ID",
                table: "VENDAS_PAGAMENTOS",
                column: "CAIXA_ENTRADA_ID",
                principalTable: "ENTRADAS_CAIXAS",
                principalColumn: "ID");
        }
    }
}
