using Microsoft.EntityFrameworkCore;
using Garagem.Data.Entities;
using MySql.Data.MySqlClient;

namespace Garagem.Data.DbContexts
{
    public class GaragemContext : DbContext
    {   
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                var conexaoString = "Host=localhost;Port=5432;Database=Garagem;Username=postgres;Password=3309;Include Error Detail=true";
                optionsBuilder.UseNpgsql(conexaoString);
            } 
        }
        public DbSet<Veiculo> Veiculos { get; set; }
        public GaragemContext(DbContextOptions options): base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração da tabela Veiculos
            modelBuilder.Entity<Veiculo>(entity =>
            {
                // entity.ToTable("Veiculos");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Placa)
                    .IsRequired();

                entity.Property(e => e.Chassi)
                    .IsRequired();

                entity.Property(e => e.AnoFabricacao)
                    .IsRequired();

                entity.Property(e => e.AnoModelo)
                    .IsRequired();

                entity.Property(e => e.ValorFIPE)
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValorVenda)
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Observacoes)
                    .HasMaxLength(500); 

                entity.Property(e => e.IdMarca);

                entity.Property(e => e.IdModelo);

                entity.Property(e => e.NomeModelo)
                    .IsRequired()
                    .HasMaxLength(200); 

                entity.Property(e => e.NomeMarca)
                    .IsRequired() 
                    .HasMaxLength(200); 
            });
            modelBuilder.Entity<Veiculo>().HasData(
                new Veiculo
                {
                    Id = 1, // ID único
                    Placa = "ABC1234",
                    Chassi = "9BWZZZ377VT004251",
                    AnoFabricacao = 2020,
                    AnoModelo = 2021,
                    ValorFIPE = 80000.00m,
                    ValorVenda = 85000.00m,
                    Observacoes = "Veículo em excelente estado, único dono.",
                    IdMarca = "Marca1",
                    IdModelo = "Modelo1",
                    NomeModelo = "Sedan Lux",
                    NomeMarca = "CarMaker"
                },
                new Veiculo
                {
                    Id = 2, // ID único
                    Placa = "XYZ9876",
                    Chassi = "3VWFE21C04M000001",
                    AnoFabricacao = 2019,
                    AnoModelo = 2020,
                    ValorFIPE = 75000.00m,
                    ValorVenda = 80000.00m,
                    Observacoes = "Veículo esportivo em ótimo estado, revisões em dia.",
                    IdMarca = "Marca2",
                    IdModelo = "Modelo2",
                    NomeModelo = "Coupe Sport",
                    NomeMarca = "Speedster"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
        
       
    }
}
