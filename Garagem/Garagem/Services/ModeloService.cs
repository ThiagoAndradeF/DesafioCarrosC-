
using Garagem.Infra.Repositories;
using Garagem.Models;

namespace  Garagem.Services;
public class ModeloService{
    private readonly IModeloRepository _modeloRepository;
    public ModeloService(IModeloRepository modeloRepository)
    {
        _modeloRepository = modeloRepository;
    }

    public async Task<List<ModeloDto>> ListarModelosByIdMarcaAsync(string idMarca){
        try
        {
            if(idMarca != null){
                return await _modeloRepository.GetModelosByIdMarcaAsync(idMarca);
            }else{
                return [];
            }
        }
        catch (System.Exception ex)
        {
            throw new Exception("Houve um erro ao obter os modelos dessa marca: ", ex);
        }
        
    }   
    
}

