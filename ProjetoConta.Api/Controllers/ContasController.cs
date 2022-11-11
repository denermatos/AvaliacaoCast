using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoConta.Api.Data;
using ProjetoConta.Api.Models;
using ProjetoConta.Api.Repositories;

namespace ProjetoConta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private readonly IContaRepository _contaRepository;

        public ContasController(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Conta>> BuscarTodasContas()
        {
            return await _contaRepository.BuscarTodasContas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Conta>> BuscarConta(int id)
        {
            var conta = await _contaRepository.BuscarConta(id);
            if (conta == null)
                return NotFound();

            return conta;
        }

        [HttpPost]
        public async Task<ActionResult<Conta>> IncluirConta([FromBody] Conta conta)
        {
            var newConta = await _contaRepository.IncluirConta(conta);
            return CreatedAtAction(nameof(BuscarConta), new { id = conta.Id }, conta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarConta(int id, [FromBody] Conta conta)
        {
            if (id != conta.Id)
            {
                return BadRequest();
            }

            await _contaRepository.AtualizarConta(conta);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletaConta(int id)
        {
            var conta = await _contaRepository.BuscarConta(id);
            if (conta == null)
            {
                return NotFound();
            }

            await _contaRepository.DeletaConta(conta.Id);
            return NoContent();
        }

    }
}