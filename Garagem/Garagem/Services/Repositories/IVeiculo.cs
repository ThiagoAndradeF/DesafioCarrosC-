using Garagem.Models;

namespace  Garagem.Services.Repositories;
public interface IVeiculo{
    public Task<bool> CriarVeiculoAsync(VeiculoCreateDto veiculo);
    Task<VeiculoDto> BuscarVeiculoPorIdAsync(int id);
    Task<bool> AtualizarVeiculoAsync(int id, VeiculoUpdateDto atualizacoesVeiculo);
    Task<bool> RemoverVeiculoAsync(int id);
}