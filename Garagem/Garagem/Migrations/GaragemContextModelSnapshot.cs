﻿// <auto-generated />
using Garagem.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Garagem.Migrations
{
    [DbContext(typeof(GaragemContext))]
    partial class GaragemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Garagem.Data.Entities.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("integer");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("integer");

                    b.Property<string>("Chassi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IdMarca")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IdModelo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomeMarca")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("NomeModelo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("ValorFIPE")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnoFabricacao = 2020,
                            AnoModelo = 2021,
                            Chassi = "9BWZZZ377VT004251",
                            IdMarca = "Marca1",
                            IdModelo = "Modelo1",
                            NomeMarca = "CarMaker",
                            NomeModelo = "Sedan Lux",
                            Observacoes = "Veículo em excelente estado, único dono.",
                            Placa = "ABC1234",
                            ValorFIPE = 80000.00m,
                            ValorVenda = 85000.00m
                        },
                        new
                        {
                            Id = 2,
                            AnoFabricacao = 2019,
                            AnoModelo = 2020,
                            Chassi = "3VWFE21C04M000001",
                            IdMarca = "Marca2",
                            IdModelo = "Modelo2",
                            NomeMarca = "Speedster",
                            NomeModelo = "Coupe Sport",
                            Observacoes = "Veículo esportivo em ótimo estado, revisões em dia.",
                            Placa = "XYZ9876",
                            ValorFIPE = 75000.00m,
                            ValorVenda = 80000.00m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
