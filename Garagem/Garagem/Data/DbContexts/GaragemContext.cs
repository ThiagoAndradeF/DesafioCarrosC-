using Microsoft.EntityFrameworkCore;
using Garagem.Data.Entities;

namespace Garagem.Data.DbContexts
{
    public class GaragemContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Garagem;Username=postgres;Password=3309;Include Error Detail=true");

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
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.Chassi)
                    .IsRequired()
                    .HasMaxLength(17);

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

                entity.Property(e => e.IdMarca)
                    .IsRequired()
                    .HasMaxLength(15); 

                entity.Property(e => e.IdModelo)
                    .IsRequired()
                    .HasMaxLength(15); 
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
