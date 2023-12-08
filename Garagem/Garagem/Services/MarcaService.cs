using Garagem.Models;
using Garagem.Services.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace  Garagem.Services;

public class MarcaService{
    private readonly IMarcaRepository _marcaRepository;

    public MarcaService(IMarcaRepository marcaRepository)
    {
        _marcaRepository = marcaRepository;
    }
}