using Garagem.Models;
using Garagem.Infra.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace Garagem.Infra.Repositories;
public interface IMarcaRepository
{
    public Task<List<MarcaDto>> GetMarcasAsync();
}
