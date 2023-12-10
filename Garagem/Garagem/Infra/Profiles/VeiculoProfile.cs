
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
            .ForMember(dto => dto.Marca, opt => opt.MapFrom(src => new MarcaDto { codigo = src.IdMarca, nome = src.NomeMarca }))
            .ForMember(dto => dto.Modelo, opt => opt.MapFrom(src => new ModeloDto { codigo = src.IdModelo, nome = src.NomeModelo }))
            .ReverseMap()
            .ForMember(src => src.IdMarca, opt => opt.MapFrom(dto => dto.Marca.codigo))
            .ForMember(src => src.NomeMarca, opt => opt.MapFrom(dto => dto.Marca.nome))
            .ForMember(src => src.IdModelo, opt => opt.MapFrom(dto => dto.Modelo.codigo))
            .ForMember(src => src.NomeModelo, opt => opt.MapFrom(dto => dto.Modelo.nome));
        
        CreateMap<Veiculo, VeiculoUpdateDto>()
            .ReverseMap();
    }
}