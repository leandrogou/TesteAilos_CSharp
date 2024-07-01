using MediatR;
using Questao5.Infrastructure.Database.CommandStore.Requests;

namespace Questao5.Application.Handlers
{
    public class CustomeHandler : IRequestHandler<APIBanco, string>
    {
        private readonly IMediator _mediator;
        private readonly IAPIBanco _aPIBanco;

        public CustomeHandler(IMediator mediator, IAPIBanco aPIBanco)
        {
            _mediator = mediator;
            _aPIBanco = aPIBanco;
        }

        public Task<string> Handle(APIBanco request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
