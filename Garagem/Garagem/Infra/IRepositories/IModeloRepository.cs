using Garagem.Models;
using Garagem.Infra.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace Garagem.Infra.Repositories;
public interface IModeloRepository
{
    public Task<List<ModeloDto>> GetModelosByIdMarcaAsync(string marcaId);
}

