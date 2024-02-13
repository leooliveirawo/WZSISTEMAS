using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WZSISTEMAS.Dados.EF.Migrations
{
    /// <inheritdoc />
    public partial class rv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CodigoReferencia",
                table: "EMPRESAS",
                newName: "CODIGO_REFERENCIA");

            migrationBuilder.AlterColumn<string>(
                name: "CODIGO_REFERENCIA",
                table: "EMPRESAS",
                type: "VARCHAR(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CODIGO_REFERENCIA",
                table: "EMPRESAS",
                newName: "CodigoReferencia");

            migrationBuilder.AlterColumn<string>(
                name: "CodigoReferencia",
                table: "EMPRESAS",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldMaxLength: 150);
        }
    }
}
