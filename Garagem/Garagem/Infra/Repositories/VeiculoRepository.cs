
using Garagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem.Infra.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        public Task<bool> AtualizarVeiculoAsync(int id, VeiculoUpdateDto atualizacoesVeiculo)
        {
            throw new NotImplementedException();
        }

        public Task<VeiculoDto> BuscarVeiculoPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CriarVeiculoAsync(VeiculoCreateDto veiculo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverVeiculoAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
