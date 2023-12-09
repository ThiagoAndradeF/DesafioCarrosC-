
using AutoMapper;
using Garagem.Data.DbContexts;
using Garagem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem.Infra.Repositories
{
    public class GaragemRepository : IGaragemRepository
    { 
        private readonly GaragemContext _context;
        private readonly IMapper _mapper;
        public GaragemRepository(GaragemContext context, IMapper mapper){
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<VeiculoDto>> GetAllVeiculos()
        {
            var veiculos = await _context.Veiculos.ToListAsync();
            return _mapper.Map<List<VeiculoDto>>(veiculos);
        }
    }
}
