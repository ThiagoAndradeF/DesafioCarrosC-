using Garagem.Models;
using Garagem.Services.Repositories;
namespace  Garagem.Services;
public class GaragemService : IGaragem
{
    public Task<IEnumerable<VeiculoDto>> GetAllVeiculos()
    {
        throw new NotImplementedException();
    }
}