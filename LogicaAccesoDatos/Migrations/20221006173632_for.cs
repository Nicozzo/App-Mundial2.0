using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class @for : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seleccion_Pais_paisId",
                table: "Seleccion");

            migrationBuilder.DropIndex(
                name: "IX_Seleccion_paisId",
                table: "Seleccion");

            migrationBuilder.DropColumn(
                name: "paisId",
                table: "Seleccion");

            migrationBuilder.AddColumn<int>(
                name: "IdPais",
                table: "Seleccion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SeleccionesGrupo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idseleccion = table.Column<int>(nullable: false),
                    IdGrupo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeleccionesGrupo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SeleccionesGrupo_Grupo_IdGrupo",
                        column: x => x.IdGrupo,
                        principalTable: "Grupo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeleccionesGrupo_Seleccion_Idseleccion",
                        column: x => x.Idseleccion,
                        principalTable: "Seleccion",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seleccion_IdPais",
                table: "Seleccion",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_SeleccionesGrupo_IdGrupo",
                table: "SeleccionesGrupo",
                column: "IdGrupo");

            migrationBuilder.CreateIndex(
                name: "IX_SeleccionesGrupo_Idseleccion",
                table: "SeleccionesGrupo",
                column: "Idseleccion");

            migrationBuilder.AddForeignKey(
                name: "FK_Seleccion_Pais_IdPais",
                table: "Seleccion",
                column: "IdPais",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seleccion_Pais_IdPais",
                table: "Seleccion");

            migrationBuilder.DropTable(
                name: "SeleccionesGrupo");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropIndex(
                name: "IX_Seleccion_IdPais",
                table: "Seleccion");

            migrationBuilder.DropColumn(
                name: "IdPais",
                table: "Seleccion");

            migrationBuilder.AddColumn<int>(
                name: "paisId",
                table: "Seleccion",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seleccion_paisId",
                table: "Seleccion",
                column: "paisId");

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
