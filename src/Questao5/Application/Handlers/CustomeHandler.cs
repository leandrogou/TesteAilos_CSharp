using MediatR;
using Questao5.Domain.Entities;
using Questao5.Infrastructure.Database.CommandStore.Requests;

namespace Questao5.Application.Handlers
{
    public class CustomeHandler : IRequestHandler<CustomerCreateIdEmpotenciaCommand, string>,
        IRequestHandler<CustomerUpdateIdEmpotenciaCommand,string>,
        IRequestHandler<CustomerCreateMovimentoCommand,string>,
        IRequestHandler<CustomerUpdateMovimentoCommand,string>
    {
        private readonly IMediator _mediator;
        private readonly IAPIBanco _aPIBanco;

        public CustomeHandler(IMediator mediator, IAPIBanco aPIBanco)
        {
            _mediator = mediator;
            _aPIBanco = aPIBanco;
        }

        public async Task<string> Handle(CustomerCreateIdEmpotenciaCommand request, CancellationToken cancellationToken)
        {
            var idemp = new IdEmpotencia(request.chave_IdEmpotencia, request.Requisicao, request.Resultado);
            await _aPIBanco.Save(idemp);

            //await _mediator.Publish(new Cu)
            return await Task.FromResult("IdEmpotencia Criado");
                }
        public async Task<string> Handle(CustomerUpdateIdEmpotenciaCommand request, CancellationToken cancellationToken)
        {
            var idemp = new IdEmpotencia(request.chave_IdEmpotencia, request.Requisicao, request.Resultado);
            await _aPIBanco.Update(idemp);

            //await _mediator.Publish(new Cu)
            return await Task.FromResult("IdEmpotencia Atualizado");
        }
        public async Task<string> Handle(CustomerCreateMovimentoCommand request, CancellationToken cancellationToken)
        {
            var movimento = new Movimento(request.IdMovimento,request.DataMovimento,request.TipoMovimento,request.Valor,request.IdContaCorrente);
            await _aPIBanco.Save(movimento);

            //await _mediator.Publish(new Cu)
            return await Task.FromResult("Movimento Criado");
        }
        public async Task<string> Handle(CustomerUpdateMovimentoCommand request, CancellationToken cancellationToken)
        {
            var movimento = new Movimento(request.IdMovimento, request.DataMovimento, request.TipoMovimento, request.Valor, request.IdContaCorrente);
            await _aPIBanco.Save(movimento);

            //await _mediator.Publish(new Cu)
            return await Task.FromResult("Movimento Atualizado");
        }
    }
}
