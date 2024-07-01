using IdempotentAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Services.Controllers
{
    [ApiController]
    [Route("/api/[controller]/")]
    [Consumes("application/json")]
    [Produces("application/json")]
    [Idempotent(Enabled = true)]
    public class APIBancoController : ControllerBase
    {
        public APIBancoController() { }

        /// <summary>
        /// Movimenta o saldo da conta
        /// </summary>
        /// <param name="conta"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("MovimentaConta")]
        public IActionResult MovimentarConta(RequisicaoConta conta)
        {
            return Ok();
        }

        /// <summary>
        /// Retorna o saldo da conta
        /// </summary>
        /// <param name="conta"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("SaldoConta")]
        public IActionResult RetornarSaldoConta(int conta)
        {
            if(conta== 0)
            return Ok();
            else return BadRequest();
        }
    }
}
