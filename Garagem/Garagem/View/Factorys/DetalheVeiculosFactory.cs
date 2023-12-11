using Garagem.Infra.Repositories;
using Garagem.Services;
using Garagem.View;
using Microsoft.Extensions.DependencyInjection;

public interface IDetalhesVeiculoFactory
{
    DetalhesVeiculo Create(int idVeiculo);
}
public class DetalhesVeiculoFactory : IDetalhesVeiculoFactory
{
   private readonly IServiceProvider _serviceProvider;

    public DetalhesVeiculoFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public DetalhesVeiculo Create(int idVeiculo)
    {
        // Resolve a dependência IVeiculoRepository
        var veiculoRepository = _serviceProvider.GetService<IVeiculoRepository>();
        var serviceProvider = _serviceProvider;

        // Cria a instância de DetalhesVeiculo com as dependências necessárias
        return new DetalhesVeiculo(idVeiculo, veiculoRepository, serviceProvider);
    }
}

