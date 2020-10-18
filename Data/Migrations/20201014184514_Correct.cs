using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Correct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sobrenome",
                table: "TB_PESSOA",
                newName: "NM_SOBRENOME");

            migrationBuilder.RenameColumn(
                name: "NM_SOBRENOMEs",
                table: "TB_PESSOA",
                newName: "NM_NOME");

            migrationBuilder.AlterColumn<string>(
                name: "NM_SOBRENOME",
                table: "TB_PESSOA",
                type: "VARCHAR",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NM_SOBRENOME",
                table: "TB_PESSOA",
                newName: "Sobrenome");

            migrationBuilder.RenameColumn(
                name: "NM_NOME",
                table: "TB_PESSOA",
                newName: "NM_SOBRENOMEs");

            migrationBuilder.AlterColumn<string>(
                name: "Sobrenome",
                table: "TB_PESSOA",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 100);
        }
    }
}
