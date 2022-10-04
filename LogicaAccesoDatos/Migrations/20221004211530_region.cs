using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class region : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Pais_IdRegion",
                table: "Pais",
                column: "IdRegion");

            migrationBuilder.AddForeignKey(
                name: "FK_Pais_Region_IdRegion",
                table: "Pais",
                column: "IdRegion",
                principalTable: "Region",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pais_Region_IdRegion",
                table: "Pais");

            migrationBuilder.DropIndex(
                name: "IX_Pais_IdRegion",
                table: "Pais");
        }
    }
}
