using Garagem.Models;

namespace Garagem.Infra.Repositories;
public interface IGaragemRepository
{
    public Task<IEnumerable<VeiculoDto>> GetAllVeiculos();

}

