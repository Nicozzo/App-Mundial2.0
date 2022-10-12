using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class re : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Incidenciaid",
                table: "ResultadoPartido",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Incidencia",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resultado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidencia", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoPartido_Incidenciaid",
                table: "ResultadoPartido",
                column: "Incidenciaid");

            migrationBuilder.AddForeignKey(
                name: "FK_ResultadoPartido_Incidencia_Incidenciaid",
                table: "ResultadoPartido",
                column: "Incidenciaid",
                principalTable: "Incidencia",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResultadoPartido_Incidencia_Incidenciaid",
                table: "ResultadoPartido");

            migrationBuilder.DropTable(
                name: "Incidencia");

            migrationBuilder.DropIndex(
                name: "IX_ResultadoPartido_Incidenciaid",
                table: "ResultadoPartido");

            migrationBuilder.DropColumn(
                name: "Incidenciaid",
                table: "ResultadoPartido");
        }
    }
}
