
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
            MessageBox.Show("Desculpe", "Erro ao obter modelos dessa marca especificada.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("Houve um erro ao obter os modelos dessa marca: ", ex);
        }
        
    }   
    public ModeloDto? EncontrarModeloPorIndex(List<ModeloWithIndexListDto> lista, int id)
    {
        var item = lista.FirstOrDefault(m => m.id == id);
        return item?.modelo;
    }
}

