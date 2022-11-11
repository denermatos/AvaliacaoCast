using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoConta.Api.Data;
using ProjetoConta.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoConta.Api.Repositories
{
    public class ContaRepository : IContaRepository
    {
        public readonly DataContext _context;

        public ContaRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Conta> IncluirConta(Conta conta)
        {
            _context.Conta.Add(conta);
            await _context.SaveChangesAsync();

            return conta;
        }

        public async Task DeletaConta(int id)
        {
            var contaToDelete = await _context.Conta.FindAsync(id);
            _context.Conta.Remove(contaToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Conta>> BuscarTodasContas()
        {
            return await _context.Conta.ToListAsync();
        }

        public async Task<Conta> BuscarConta(int id)
        {
            return await _context.Conta.FindAsync(id);
        }

        public async Task AtualizarConta(Conta conta)
        {
            _context.Entry(conta).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
    }
}
