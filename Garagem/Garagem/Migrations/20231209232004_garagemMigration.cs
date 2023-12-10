using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Garagem.Migrations
{
    /// <inheritdoc />
    public partial class garagemMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Placa = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    Chassi = table.Column<string>(type: "character varying(17)", maxLength: 17, nullable: false),
                    AnoFabricacao = table.Column<int>(type: "integer", nullable: false),
                    AnoModelo = table.Column<int>(type: "integer", nullable: false),
                    ValorFIPE = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    ValorVenda = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Observacoes = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    IdMarca = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    IdModelo = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    NomeModelo = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    NomeMarca = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });

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
