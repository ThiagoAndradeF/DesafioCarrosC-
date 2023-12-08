using Garagem.Models;
using Garagem.Services.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace  Garagem.Services.Repositories;
public interface IMarcaRepository{
    public Task<List<MarcaDto>>GetMarcasAsync();
}

public class MarcaRepository : IMarcaRepository{
     private readonly IMemoryCache _cache;
    private readonly MemoryCacheEntryOptions _cacheOptions;
    private readonly string _linkListaMarcas = "https://parallelum.com.br/fipe/api/v1/carros/marcas";
    public MarcaRepository(IMemoryCache cache){
        _cache = cache;
        _cacheOptions = new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30)
        };
    }
    public async Task<List<MarcaDto>> GetMarcasAsync(){
        try
        {
            if (!_cache.TryGetValue("marcas", out List<MarcaDto> marcas))
            {
                marcas = await FetchMarcasAsync();
                _cache.Set("marcas", marcas, _cacheOptions);
            }
            return marcas;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao buscar marcas: {ex.Message}");
            return new List<MarcaDto>(); 
        }
    }

    private async Task<List<MarcaDto>> FetchMarcasAsync()
    {
        using (var httpClient = new HttpClient())
        {
            try
            {
                var response = await httpClient.GetAsync(_linkListaMarcas);
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<MarcaDto>>(jsonResponse) ?? new List<MarcaDto>();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Erro na requisição HTTP: {e.Message}");
                return new List<MarcaDto>();
            }
            catch (JsonException e)
            {
                Console.WriteLine($"Erro ao deserializar JSON: {e.Message}");
                return new List<MarcaDto>();
            }
        }
    }
}