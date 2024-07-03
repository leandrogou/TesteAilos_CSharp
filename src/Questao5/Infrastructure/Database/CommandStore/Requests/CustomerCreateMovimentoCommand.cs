using MediatR;

namespace Questao5.Infrastructure.Database.CommandStore.Requests
{
    public class CustomerCreateMovimentoCommand : IRequest<string>
    {
        public Guid IdMovimento { get; private set; }
        public DateTime DataMovimento { get; private set; }
        public char TipoMovimento { get; private set; }
        public decimal Valor { get; private set; }
        public Guid IdContaCorrente { get; private set; }
    }
}
