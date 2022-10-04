using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class FKanda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pais_Region_IdRegion",
                table: "Pais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Region",
                table: "Region");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Region");

            migrationBuilder.AddColumn<int>(
                name: "IdRegion",
                table: "Region",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pais_Region_IdRegion",
                table: "Pais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Region",
                table: "Region");

            migrationBuilder.DropColumn(
                name: "IdRegion",
                table: "Region");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Region",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Region",
                table: "Region",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pais_Region_IdRegion",
                table: "Pais",
                column: "IdRegion",
                principalTable: "Region",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
