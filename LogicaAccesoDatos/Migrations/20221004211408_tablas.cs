using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class tablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoIso",
                table: "Region");

            migrationBuilder.DropColumn(
                name: "NombreCont",
                table: "Region");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Region",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Pais",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Region_Nombre",
                table: "Region",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pais_CodigoIso",
                table: "Pais",
                column: "CodigoIso",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pais_Nombre",
                table: "Pais",
                column: "Nombre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Region_Nombre",
                table: "Region");

            migrationBuilder.DropIndex(
                name: "IX_Pais_CodigoIso",
                table: "Pais");

            migrationBuilder.DropIndex(
                name: "IX_Pais_Nombre",
                table: "Pais");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Region",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "CodigoIso",
                table: "Region",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreCont",
                table: "Region",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Pais",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 3);
        }
    }
}
