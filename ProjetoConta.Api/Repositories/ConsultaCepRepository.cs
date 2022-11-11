using Newtonsoft.Json;
using ProjetoConta.Api.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoConta.Api.Repositories
{
    public class ConsultaCepRepository : IConsultaCepRepository
    {
        public async Task<ConsultaCep> BuscarCep(int cep)
        {            
            var client = new RestClient($"http://viacep.com.br/ws/{cep}/json/");

            var request = new RestRequest("", Method.Get);

            var response = await client.ExecuteAsync<ConsultaCep>(request);

            return JsonConvert.DeserializeObject<ConsultaCep>(response.Content);            
        }
    }
}
