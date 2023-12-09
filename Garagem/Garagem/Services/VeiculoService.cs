using Garagem.Models;
using Garagem.Infra.Repositories;
namespace  Garagem.Services;
public class VeiculoService {
    private readonly IVeiculoRepository _veiculoRepository;
    public VeiculoService(IVeiculoRepository veiculoRepository)
    {
        _veiculoRepository = veiculoRepository;
    }
    public async Task<bool> CriarVeiculoAsync(VeiculoCreateDto veiculo)
    {
        try
        {
            return await _veiculoRepository.CriarVeiculoAsync(veiculo);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocorreu um erro inesperado ao criar um veículo: ", ex);
        }
    }
    public async Task<bool> EditarVeiculoAsync(int idVeiculo , VeiculoUpdateDto atualizacoesVeiculo)
    {
        try
        {
            return await _veiculoRepository.AtualizarVeiculoAsync(idVeiculo , atualizacoesVeiculo);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocorreu um erro inesperado ao editar o veículoselecionado: ", ex);
        }
    }
    public async Task<bool> ExcluirVeiculoAsync(int idVeiculo)
    {
        try
        {
            return await _veiculoRepository.RemoverVeiculoAsync(idVeiculo);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocorreu um erro inesperado ao excluir o veículo selecionado: ", ex);
        }
    }
    public async Task<VeiculoDto> DetalhesVeiculoAsync(int idVeiculo)
    {
        try
        {
            return await _veiculoRepository.BuscarVeiculoPorIdAsync(idVeiculo);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocorreu um erro inesperado ao detalhar esse veículo: ", ex);
        }
    }



  

}