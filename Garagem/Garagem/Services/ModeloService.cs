using Garagem.Models;
using Garagem.Services.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace  Garagem.Services;
public class ModeloService: IModelo{
        private readonly IMemoryCache _cache;
        private readonly MemoryCacheEntryOptions _cacheOptions;

        public ModeloService(IMemoryCache cache){
            _cache = cache;
            _cacheOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30)
            };
        }
        public async Task<List<ModeloDto>> GetModelosByIdMarcaAsync(string marcaId)
        {
            try
            {
                string cacheKey = $"modelosCarros-{marcaId}";
                if (!_cache.TryGetValue(cacheKey, out List<ModeloDto> modelos))
                {
                    modelos = await FetchModelosAsync(marcaId);
                    _cache.Set(cacheKey, modelos, _cacheOptions);
                }
                return modelos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar modelos: {ex.Message}");
                return new List<ModeloDto>(); 
            }
        }

        private async Task<List<ModeloDto>> FetchModelosAsync(string marcaId)
        {
            string requestUrl = $"https://parallelum.com.br/fipe/api/v1/carros/marcas/{marcaId}/modelos";
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync(requestUrl);
                    response.EnsureSuccessStatusCode();
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<ModeloDto>>(jsonResponse) ?? new List<ModeloDto>();
                }
                catch (HttpRequestException e)
                {
                    // Log the exception
                    Console.WriteLine($"Erro na requisição HTTP: {e.Message}");
                    return new List<ModeloDto>(); 
                }
                catch (JsonException e)
                {
                    // Log the exception
                    Console.WriteLine($"Erro ao deserializar JSON: {e.Message}");
                    return new List<ModeloDto>();
                }
            }
        }
}

