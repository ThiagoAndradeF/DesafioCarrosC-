using System.Text;
using Garagem.Models;
using Newtonsoft.Json;

namespace Garagem.Infra.Repositories;
public interface IAuthenticationRepository
{
    public Task<bool> SignInAsync(string username, string password);
}

