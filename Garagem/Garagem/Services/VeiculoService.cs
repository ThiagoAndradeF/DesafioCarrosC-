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
            MessageBox.Show( "Ocorreu um erro inesperado ao criar um veículo" + ex, "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("Ocorreu um erro inesperado ao criar um veículo: " + ex, ex);
        }
    }
    public async Task<bool> EditarVeiculoAsync(int idVeiculo , VeiculoUpdateDto atualizacoesVeiculo)
    {
        try
        {
            var atualizacaoVeiculo = await _veiculoRepository.AtualizarVeiculoAsync(idVeiculo , atualizacoesVeiculo);
            MessageBox.Show( "Veiculo atualizado com sucesso", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return atualizacaoVeiculo;
        }
        catch (Exception ex)
        {
            MessageBox.Show( "Ocorreu um erro inesperado ao editar o veículo selecionado", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MessageBox.Show( "Ocorreu um erro inesperado ao excluir o veículo selecionado", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("Ocorreu um erro inesperado ao excluir o veículo selecionado: ", ex);
        }
    }
    public async Task<VeiculoDto> DetalhesVeiculoAsync(int idVeiculo)
    {
        try
        {
             var veiculoFiltrado = await _veiculoRepository.BuscarVeiculoPorIdAsync(idVeiculo);
            return veiculoFiltrado;
        }
        catch (Exception ex)
        {
            MessageBox.Show( "Ocorreu um erro inesperado ao inesperado ao obter detalhes desse veículo", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("Ocorreu um erro inesperado ao detalhar esse veículo: ", ex);
        }
    }



  

}