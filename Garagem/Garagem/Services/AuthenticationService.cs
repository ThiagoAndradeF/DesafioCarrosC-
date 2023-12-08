
using System.Text;
using Garagem.Models;
using Garagem.Infra.Repositories;
using Newtonsoft.Json;

namespace  Garagem.Services;
public class AuthenticationService
{
    private readonly IAuthenticationRepository _authRepository;

    public AuthenticationService(IAuthenticationRepository authRepository)
    {
        _authRepository = authRepository;
    }
    public async Task<bool> ExecuteLoginAsync(string username, string password){
        bool loginSuccessful = await _authRepository.SignInAsync(username, password);
        if (loginSuccessful)
        {
            Console.WriteLine("Login bem-sucedido.");
            return true;
        }
        else
        {
            Console.WriteLine("Falha no login.");
            return false;
        }
    }


}