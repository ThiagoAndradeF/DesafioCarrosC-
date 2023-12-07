using Garagem.Models;

namespace  Garagem.Services.Repositories;
public interface IModelo{
    public Task<List<ModeloDto>>GetModelosByIdMarcAsync();
}