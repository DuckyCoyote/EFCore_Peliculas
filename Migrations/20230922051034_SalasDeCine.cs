using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Peliculas.Migrations
{
    /// <inheritdoc />
    public partial class SalasDeCine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PeliculaSalaDeCine",
                columns: table => new
                {
                    PeliculasId = table.Column<int>(type: "integer", nullable: false),
                    SalasDeCineId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculaSalaDeCine", x => new { x.PeliculasId, x.SalasDeCineId });
                    table.ForeignKey(
                        name: "FK_PeliculaSalaDeCine_Peliculas_PeliculasId",
                        column: x => x.PeliculasId,
                        principalTable: "Peliculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeliculaSalaDeCine_SalasDeCine_SalasDeCineId",
                        column: x => x.SalasDeCineId,
                        principalTable: "SalasDeCine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaSalaDeCine_SalasDeCineId",
                table: "PeliculaSalaDeCine",
                column: "SalasDeCineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeliculaSalaDeCine");
        }
    }
}
