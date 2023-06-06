using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial1_JoseMiguel.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingresos",
                columns: table => new
                {
                    IngresoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<int>(type: "INTEGER", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: false),
                    Monto = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingresos", x => x.IngresoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingresos");
        }
    }
}
