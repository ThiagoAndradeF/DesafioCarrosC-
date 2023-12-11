
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
        try
        {
            bool loginSuccessful = await _authRepository.SignInAsync(username, password);
            if (loginSuccessful)
            {
                Console.WriteLine("Login bem-sucedido.");
                // MessageBox.Show("Login bem sucedido.", "Parab�ns.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Desculpe, Credenciais n�o cadastradas.", "Desculpe.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }catch (Exception ex)
        {
            MessageBox.Show("Problelma ao comparar credenciais, error: " + ex.Message, "Desculpe.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("Exception: " + ex);
        }
        
    }


}