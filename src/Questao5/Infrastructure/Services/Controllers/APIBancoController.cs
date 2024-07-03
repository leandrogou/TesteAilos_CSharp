using IdempotentAPI.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questao5.Domain.Entities;
using Questao5.Infrastructure.Database.CommandStore.Requests;

namespace Questao5.Infrastructure.Services.Controllers
{
    [ApiController]
    [Route("/api/[controller]/")]
    [Consumes("application/json")]
    [Produces("application/json")]
    //[Idempotent(Enabled = true)]
    public class APIBancoController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IAPIBanco _banco;

        public APIBancoController(IMediator mediator, IAPIBanco banco)
        {
            _mediator = mediator;
            _banco = banco;
        }

        /// <summary>
        /// Movimenta o saldo da conta
        /// </summary>
        /// <param name="conta"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("MovimentaConta")]
        public IActionResult MovimentarConta(CustomerCreateMovimentoCommand conta)
        {
            _mediator.Send(conta);
            return Ok();
        }

        /// <summary>
        /// Retorna o saldo da conta
        /// </summary>
        /// <param name="conta"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("SaldoConta/{conta}")]
        public IActionResult RetornarSaldoConta(int conta)
        {
            _mediator.Send(conta);
            if(conta== 0)
            return Ok();
            else return BadRequest();
        }
    }
}
