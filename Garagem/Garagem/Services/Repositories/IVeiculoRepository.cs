using Garagem.Models;

namespace  Garagem.Services.Repositories;
public interface IVeiculoRepository{
    public Task<bool> CriarVeiculoAsync(VeiculoCreateDto veiculo);
    Task<VeiculoDto> BuscarVeiculoPorIdAsync(int id);
    Task<bool> AtualizarVeiculoAsync(int id, VeiculoUpdateDto atualizacoesVeiculo);
    Task<bool> RemoverVeiculoAsync(int id);
}

public class VeiculoRepository : IVeiculoRepository
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