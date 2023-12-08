
using Garagem.Infra.Repositories;

namespace  Garagem.Services;
public class ModeloService{
    private readonly IModeloRepository _modeloRepository;
    public ModeloService(IModeloRepository modeloRepository)
    {
        _modeloRepository = modeloRepository;
    }
    
}

