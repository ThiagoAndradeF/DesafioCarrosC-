using System.Net;
using Garagem.Models;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
public class CacheManager
{
    private IMemoryCache _cache;
    private MemoryCacheEntryOptions _cacheOptions;
    private readonly string _marcasUrl = "https://parallelum.com.br/fipe/api/v1/carros/marcas";

    public CacheManager()
    {
        _cache = new MemoryCache(new MemoryCacheOptions());
        _cacheOptions = new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30) // Tempo de expiração do cache
        };
    }

    public async Task<List<MarcaDto>> GetMarcasAsync()
    {            
        if (!_cache.TryGetValue("marcas", out List<MarcaDto>?marcas))
        {
            marcas = await FetchMarcasAsync() ;
            _cache.Set("marcas", marcas, _cacheOptions);
        }
        if(marcas!= null){
            return marcas;
        } 
        return null;
    }

    private async Task<List<MarcaDto>> FetchMarcasAsync()
    {
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(_marcasUrl);
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<MarcaDto>>(jsonResponse);
        }
    }
}