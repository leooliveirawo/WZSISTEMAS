using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WZSISTEMAS.Dados.EF.Migrations
{
    /// <inheritdoc />
    public partial class rv5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ITEM_PRINCIPAL_ID",
                table: "ITENS",
                type: "BIGINT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ITENS_ITEM_PRINCIPAL_ID",
                table: "ITENS",
                column: "ITEM_PRINCIPAL_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ITENS_ITENS_ITEM_PRINCIPAL_ID",
                table: "ITENS",
                column: "ITEM_PRINCIPAL_ID",
                principalTable: "ITENS",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ITENS_ITENS_ITEM_PRINCIPAL_ID",
                table: "ITENS");

            migrationBuilder.DropIndex(
                name: "IX_ITENS_ITEM_PRINCIPAL_ID",
                table: "ITENS");

            migrationBuilder.DropColumn(
                name: "ITEM_PRINCIPAL_ID",
                table: "ITENS");
        }
    }
}
