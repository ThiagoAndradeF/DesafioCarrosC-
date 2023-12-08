using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Garagem.Data.Entities
{
    public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> entity)
        {
           entity.HasKey(e =>e.Id);
           entity.Property(e => e.Placa).HasColumnName("Placa");
           entity.Property(e => e.Chassi).HasColumnName("Chassi");
           entity.Property(e => e.AnoFabricacao).HasColumnName("AnoFabricacao");
           entity.Property(e => e.AnoModelo).HasColumnName("AnoModelo");
           entity.Property(e => e.ValorFIPE).HasColumnName("ValorFIPE");
           entity.Property(e => e.ValorVenda).HasColumnName("ValorVenda");
           entity.Property(e => e.Observacoes).HasColumnName("Observacoes");
           entity.Property(e => e.IdMarca).HasColumnName("IdMarca");
           entity.Property(e => e.IdModelo).HasColumnName("IdModelo");
        } 
    }
}
