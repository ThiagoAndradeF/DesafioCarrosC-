namespace  Garagem.Models;

public class VeiculoUpdateDto
{
    public decimal ValorFIPE { get; set; }
    public decimal ValorVenda { get; set; }
    public string Observacoes { get; set; } = string.Empty;
}