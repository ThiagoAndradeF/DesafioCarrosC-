using Garagem.Models;
using Garagem.Services.Repositories;
namespace  Garagem.Services;
public class GaragemService{
    private readonly IGaragemRepository _garagemRepository;
    public GaragemService(IGaragemRepository garagemRepository)
    {
        _garagemRepository = garagemRepository;
    }





}