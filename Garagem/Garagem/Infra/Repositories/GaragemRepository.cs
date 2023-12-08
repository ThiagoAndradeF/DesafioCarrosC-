
using Garagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem.Infra.Repositories
{
    public class GaragemRepository : IGaragemRepository
    {
        public Task<IEnumerable<VeiculoDto>> GetAllVeiculos()
        {
            throw new NotImplementedException();
        }
    }
}
