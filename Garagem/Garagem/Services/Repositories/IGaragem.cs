using Garagem.Models;

namespace  Garagem.Services.Repositories;
public interface IGaragem{
    public Task<IEnumerable<VeiculoDto>> GetAllVeiculos();
}