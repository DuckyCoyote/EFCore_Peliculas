using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFCore_Peliculas.Migrations
{
    /// <inheritdoc />
    public partial class SalaDeCineMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Cines");

            migrationBuilder.CreateTable(
                name: "SalasDeCine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Precio = table.Column<decimal>(type: "numeric(9,2)", precision: 9, scale: 2, nullable: false),
                    Ubicacion = table.Column<Point>(type: "geometry", nullable: true),
                    CineOfertaId = table.Column<int>(type: "integer", nullable: true),
                    SalaDeCineId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalasDeCine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalasDeCine_CineOfertas_CineOfertaId",
                        column: x => x.CineOfertaId,
                        principalTable: "CineOfertas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalasDeCine_SalasDeCine_SalaDeCineId",
                        column: x => x.SalaDeCineId,
                        principalTable: "SalasDeCine",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalasDeCine_CineOfertaId",
                table: "SalasDeCine",
                column: "CineOfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_SalasDeCine_SalaDeCineId",
                table: "SalasDeCine",
                column: "SalaDeCineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalasDeCine");

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Cines",
                type: "numeric(9,2)",
                precision: 9,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }
    }
}
