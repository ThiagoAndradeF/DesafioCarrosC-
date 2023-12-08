using System.Text;
using Garagem.Models;
using Newtonsoft.Json;

namespace Garagem.Services.Repositories;
public interface IAuthenticationRepository{
    public Task<bool> SignInAsync(string username, string password);
}


public class AuthenticationRepository: IAuthenticationRepository{
    private readonly string _signInUrl = "https://test-api-y04b.onrender.com/signIn";
    public async Task<bool> SignInAsync(string username, string password){
        using (var httpClient = new HttpClient())
        {
            var loginRequest = new LoginRequestDto
            {
                User = username,
                Password = password
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
                    return !loginResponse.Error && !string.IsNullOrWhiteSpace(loginResponse.User.Token);
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