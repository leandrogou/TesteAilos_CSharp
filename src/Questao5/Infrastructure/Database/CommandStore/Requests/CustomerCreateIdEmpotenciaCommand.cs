using MediatR;

namespace Questao5.Infrastructure.Database.CommandStore.Requests
{
    public class CustomerCreateIdEmpotenciaCommand : IRequest<string>
    {
        public Guid chave_IdEmpotencia { get; private set; }
        public string Requisicao { get; private set; }
        public string Resultado { get; private set; }
    }
}
