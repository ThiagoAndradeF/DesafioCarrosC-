using Garagem.Models;
using Garagem.Infra.Repositories;
namespace  Garagem.Services;
public class VeiculoService {
    private readonly IVeiculoRepository _veiculoRepository;
    public VeiculoService(IVeiculoRepository veiculoRepository)
    {
        _veiculoRepository = veiculoRepository;
    }


  

}