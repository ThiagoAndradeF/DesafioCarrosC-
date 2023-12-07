using Garagem.Models;
using Garagem.Services.Repositories;

namespace  Garagem.Services;


public class VeiculoService : IVeiculo
{
    public Task<bool> AtualizarVeiculoAsync(int id, VeiculoUpdateDto atualizacoesVeiculo)
    {
        throw new NotImplementedException();
    }

    public Task<VeiculoDto> BuscarVeiculoPorIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CriarVeiculoAsync(VeiculoCreateDto veiculo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoverVeiculoAsync(int id)
    {
        throw new NotImplementedException();
    }
}