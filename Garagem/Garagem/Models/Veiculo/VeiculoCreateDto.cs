namespace  Garagem.Models;
public class VeiculoCreateDto
    {
        public int Id { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string Chassi { get; set; } = string.Empty;
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public decimal ValorFIPE { get; set; }
        public decimal ValorVenda { get; set; }
        public string Observacoes { get; set; } = string.Empty;
        public MarcaDto Marca  { get; set; } = default!;
        public ModeloDto Modelo { get; set; } = default!;
    }