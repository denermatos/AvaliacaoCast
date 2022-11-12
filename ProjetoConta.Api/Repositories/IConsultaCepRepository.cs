using ProjetoConta.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoConta.Api.Repositories
{
    public interface IConsultaCepRepository
    {
        Task<ConsultaCep> BuscarCep(int cep);
    }
}
