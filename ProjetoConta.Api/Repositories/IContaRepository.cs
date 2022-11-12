using ProjetoConta.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoConta.Api.Repositories
{
    public interface IContaRepository
    {
        Task<IEnumerable<Conta>> BuscarTodasContas();
        Task<Conta> BuscarConta(int id);
        Task<Conta> IncluirConta(Conta conta);
        Task AtualizarConta(Conta conta);
        Task DeletaConta(int id);
    }
}
