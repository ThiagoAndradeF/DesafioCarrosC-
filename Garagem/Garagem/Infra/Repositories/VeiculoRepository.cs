
using AutoMapper;
using Garagem.Data.DbContexts;
using Garagem.Data.Entities;
using Garagem.Infra.Profiles;
using Garagem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace Garagem.Infra.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly GaragemContext _context;
        private readonly IMapper _mapper;
        public VeiculoRepository(GaragemContext context, IMapper mapper){
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> AtualizarVeiculoAsync(int id, VeiculoUpdateDto atualizacoesVeiculo)
        {
            var veiculoSelecionado =  await _context.Veiculos.FirstOrDefaultAsync( v => v.Id == id);
            if(veiculoSelecionado == null) return false;

            //POR QUESTÕES DE CONTEXTO, É POSSÍVEL EDITAR APENAS VALOR DE VENDA, OBSERVACOES E VALOR FIPE
            //OS OUTROS ATRIBUTOS SÃO ESTÁTICOS

            veiculoSelecionado.ValorVenda = atualizacoesVeiculo.ValorVenda ;
            veiculoSelecionado.ValorFIPE = atualizacoesVeiculo.ValorFIPE ;
            veiculoSelecionado.Observacoes = atualizacoesVeiculo.Observacoes;
            
            return await SaveChangesAsync();
        }

        public async Task<VeiculoDto> BuscarVeiculoPorIdAsync(int veiculoId)
        {
            return _mapper.Map<VeiculoDto>(
                await _context.Veiculos
                    .FirstOrDefaultAsync(v => v.Id == veiculoId));
        }

        public async Task<bool> CriarVeiculoAsync(VeiculoCreateDto veiculo)
        {
            try
            {
                await _context.Veiculos.AddAsync(_mapper.Map<Veiculo>(veiculo));
                return await SaveChangesAsync();
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro inesperado ao criar um veículo" + ex, "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("Exception " + ex, ex);
            }    
        }

        public async Task<bool> RemoverVeiculoAsync(int id)
        {
            var veiculoSelecionado = await _context.Veiculos.FirstOrDefaultAsync(v => v.Id == id);
            if(veiculoSelecionado == null) return false; 
            _context.Veiculos.Remove(veiculoSelecionado);
            return await SaveChangesAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
