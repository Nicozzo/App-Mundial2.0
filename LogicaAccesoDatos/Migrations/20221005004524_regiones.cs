using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class regiones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pais_Region_IdRegion",
                table: "Pais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Region",
                table: "Region");

            migrationBuilder.RenameTable(
                name: "Region",
                newName: "Regiones");

            migrationBuilder.RenameIndex(
                name: "IX_Region_Nombre",
                table: "Regiones",
                newName: "IX_Regiones_Nombre");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regiones",
                table: "Regiones",
                column: "IdRegion");

            migrationBuilder.AddForeignKey(
                name: "FK_Pais_Regiones_IdRegion",
                table: "Pais",
                column: "IdRegion",
                principalTable: "Regiones",
                principalColumn: "IdRegion",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pais_Regiones_IdRegion",
                table: "Pais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regiones",
                table: "Regiones");

            migrationBuilder.RenameTable(
                name: "Regiones",
                newName: "Region");

            migrationBuilder.RenameIndex(
                name: "IX_Regiones_Nombre",
                table: "Region",
                newName: "IX_Region_Nombre");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Region",
                table: "Region",
                column: "IdRegion");

            migrationBuilder.AddForeignKey(
                name: "FK_Pais_Region_IdRegion",
                table: "Pais",
                column: "IdRegion",
                principalTable: "Region",
                principalColumn: "IdRegion",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
