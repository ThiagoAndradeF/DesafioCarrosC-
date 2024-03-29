using Garagem.Models;
using Garagem.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Serialization;
namespace  Garagem.Services;
public class GaragemService{
    private readonly IGaragemRepository _garagemRepository;
    public GaragemService(IGaragemRepository garagemRepository)
    {
        _garagemRepository = garagemRepository;
    }
    public Task<IEnumerable<VeiculoDto>> ListarVeiculosCadastrados(){
        try
        {
            return  _garagemRepository.GetAllVeiculos();
        }
        catch (DbUpdateException ex)
        {
            // Logar a exceção
            // Notificar o usuário de uma forma genérica
            // Retornar um valor padrão, se aplicável
            MessageBox.Show("Desculpe", "Problema na conexão com o banco de dados.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("Erro na transferência de dados", ex);
        }
        catch (Exception ex)
        {
            // Logar a exceção
            // Notificar o usuário de uma forma genérica
            // Retornar um valor padrão, se aplicável, ou relançar
            MessageBox.Show("Desculpe", "Erro ao obter veículos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("Erro ao obter veículos", ex);
        }
    }

}