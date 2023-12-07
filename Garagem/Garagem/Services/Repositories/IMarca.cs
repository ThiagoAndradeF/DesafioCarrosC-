using Garagem.Models;

namespace  Garagem.Services.Repositories;
public interface IMarca{
    public Task<List<MarcaDto>>GetMarcasAsync();

}