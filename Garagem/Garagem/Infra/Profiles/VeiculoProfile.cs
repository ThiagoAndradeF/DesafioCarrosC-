
using AutoMapper;
using Garagem.Data.Entities;
using Garagem.Models;

namespace Garagem.Infra.Profiles;

public class VeiculoProfile : Profile
{
    public VeiculoProfile()
    {
        CreateMap<Veiculo, VeiculoDto>()
            .ReverseMap();
        
        CreateMap<Veiculo, VeiculoCreateDto>()
            .ReverseMap();
        
        CreateMap<Veiculo, VeiculoUpdateDto>()
            .ReverseMap();
    }
}