using MediatR;
using Questao5.Domain.Entities;

namespace Questao5.Application.Handlers
{
    public class EmailHandler : INotificationHandler<RequisicaoConta>
    {
        public Task Handle(RequisicaoConta notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Teste {0}", notification.IdContacorrente);
            });
        }
    }
}
