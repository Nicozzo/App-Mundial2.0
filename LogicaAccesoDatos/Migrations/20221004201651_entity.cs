using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pais_Region_RegionID",
                table: "Pais");

            migrationBuilder.DropForeignKey(
                name: "FK_Seleccion_Pais_paisId",
                table: "Seleccion");

            migrationBuilder.DropIndex(
                name: "IX_Pais_RegionID",
                table: "Pais");

            migrationBuilder.DropColumn(
                name: "RegionID",
                table: "Pais");

            migrationBuilder.AlterColumn<int>(
                name: "paisId",
                table: "Seleccion",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Seleccion",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Seleccion",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Pais",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodigoIso",
                table: "Pais",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdRegion",
                table: "Pais",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Seleccion_Pais_paisId",
                table: "Seleccion",
                column: "paisId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seleccion_Pais_paisId",
                table: "Seleccion");

            migrationBuilder.DropColumn(
                name: "IdRegion",
                table: "Pais");

            migrationBuilder.AlterColumn<int>(
                name: "paisId",
                table: "Seleccion",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Seleccion",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Seleccion",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Pais",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CodigoIso",
                table: "Pais",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3);

            migrationBuilder.AddColumn<int>(
                name: "RegionID",
                table: "Pais",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pais_RegionID",
                table: "Pais",
                column: "RegionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pais_Region_RegionID",
                table: "Pais",
                column: "RegionID",
                principalTable: "Region",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seleccion_Pais_paisId",
                table: "Seleccion",
                column: "paisId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
