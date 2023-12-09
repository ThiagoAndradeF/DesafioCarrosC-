
using Garagem.Models;
using Newtonsoft.Json;
using System.Text;

namespace Garagem.Infra.Repositories
{

    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly string _signInUrl = "https://test-api-y04b.onrender.com/signIn";
        public async Task<bool> SignInAsync(string username, string password)
        {
            using (var httpClient = new HttpClient())
            {
                var loginRequest = new LoginRequestDto
                {
                    user = username,
                    password = password
                };

                var content = new StringContent(JsonConvert.SerializeObject(loginRequest), Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync(_signInUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        var loginResponse = JsonConvert.DeserializeObject<LoginResponseDto>(jsonResponse);

                        // Se o login não retornar erro e um token for recebido, considere como sucesso
                        return !loginResponse.Error && !string.IsNullOrWhiteSpace(loginResponse.user.token);
                    }
                    else
                    {
                        return false; // Resposta não bem-sucedida
                    }
                }
                catch
                {
                    // Trate os erros de conexão, etc.
                    return false;
                }
            }
        }
    }
}
