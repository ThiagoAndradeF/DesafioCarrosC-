using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Garagem.Migrations
{
    /// <inheritdoc />
    public partial class garagemMigratioar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Placa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Chassi = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AnoFabricacao = table.Column<int>(type: "int", nullable: false),
                    AnoModelo = table.Column<int>(type: "int", nullable: false),
                    ValorFIPE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ValorVenda = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Observacoes = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdMarca = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdModelo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeModelo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeMarca = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "Id", "AnoFabricacao", "AnoModelo", "Chassi", "IdMarca", "IdModelo", "NomeMarca", "NomeModelo", "Observacoes", "Placa", "ValorFIPE", "ValorVenda" },
                values: new object[,]
                {
                    { 1, 2020, 2021, "9BWZZZ377VT004251", "Marca1", "Modelo1", "CarMaker", "Sedan Lux", "Veículo em excelente estado, único dono.", "ABC1234", 80000.00m, 85000.00m },
                    { 2, 2019, 2020, "3VWFE21C04M000001", "Marca2", "Modelo2", "Speedster", "Coupe Sport", "Veículo esportivo em ótimo estado, revisões em dia.", "XYZ9876", 75000.00m, 80000.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
