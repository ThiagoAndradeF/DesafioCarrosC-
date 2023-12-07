using Garagem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem.Data.DbContexts
{
    public  class GaragemContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public GaragemContext(DbContextOptions<GaragemContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações para Veiculo
            modelBuilder.Entity<Veiculo>()
                .Property(v => v.Placa)
                .HasMaxLength(7)
                .IsRequired();
            modelBuilder.Entity<Veiculo>()
                .Property(v => v.Chassi)
                .HasMaxLength(10)
                .IsRequired();
            modelBuilder.Entity<Veiculo>()
                .Property(v => v.AnoFabricacao)
                .HasMaxLength(4)
                .IsRequired();
            modelBuilder.Entity<Veiculo>()
                .Property(v => v.AnoModelo)
                .HasMaxLength(4)
                .IsRequired();
            modelBuilder.Entity<Veiculo>()
                .Property(v => v.ValorFIPE)
                .HasMaxLength(10)
                .IsRequired();
            modelBuilder.Entity<Veiculo>()
                .Property(v => v.ValorVenda)
                .HasMaxLength(10)
                .IsRequired();
            modelBuilder.Entity<Veiculo>()
                .Property(v => v.IdModelo)
                .HasMaxLength(10)
                .IsRequired();
            modelBuilder.Entity<Veiculo>()
                .Property(v => v.IdMarca)
                .HasMaxLength(10)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
    
}
