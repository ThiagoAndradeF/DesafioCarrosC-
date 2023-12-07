namespace Garagem.Data.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string Chassi { get; set; } = string.Empty;
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public decimal ValorFIPE { get; set; }
        public decimal ValorVenda { get; set; }
        public string Observacoes { get; set; } = string.Empty;
        public string IdMarca { get; set; } = string.Empty;
        public string IdModelo { get; set; }= string.Empty;
    }
}
