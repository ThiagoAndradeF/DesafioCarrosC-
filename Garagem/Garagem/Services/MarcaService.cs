using Garagem.Models;
using Garagem.Infra.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System.DirectoryServices.ActiveDirectory;

namespace  Garagem.Services;

public class MarcaService{
    private readonly IMarcaRepository _marcaRepository;

    public MarcaService(IMarcaRepository marcaRepository)
    {
        _marcaRepository = marcaRepository;
    }
    public async Task<List<MarcaDto>> ListarMarcasAsync(){
        try
        {
            return await _marcaRepository.GetMarcasAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Desculpe", "Erro ao obter as marcas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("Houve um erro ao obter as marcas: ", ex);
        }
        
    }   

}