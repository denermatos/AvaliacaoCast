using Microsoft.AspNetCore.Mvc;
using ProjetoConta.Api.Models;
using ProjetoConta.Api.Repositories;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoConta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaCepController : ControllerBase
    {
        private readonly IConsultaCepRepository _consultaCep;

        public ConsultaCepController(IConsultaCepRepository consultaCep)
        {
            _consultaCep = consultaCep;
        }

        [HttpGet("{cep}")]
        public async Task<ActionResult<ConsultaCep>> BuscarCep(int cep)
        {
            return await _consultaCep.BuscarCep(cep);
        }
    }
}
