using Garagem.Models;

namespace  Garagem.Services.Repositories;
public interface IGaragemRepository{
    public Task<IEnumerable<VeiculoDto>> GetAllVeiculos();

}

public class GaragemRepository : IGaragemRepository
{
    public Task<IEnumerable<VeiculoDto>> GetAllVeiculos()
    {
        throw new NotImplementedException();
    }
}