using MediatR;
using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Database.CommandStore.Requests
{
    public class APIBanco : IRequest<string>
    {
        public Task<IdEmpotencia> AdicionarIdEmpotent(IdEmpotencia idEmpotencia)
        {
            throw new NotImplementedException();
        }

        public Task<Movimento> AdicionarMovimentacao(Movimento movimento)
        {
            throw new NotImplementedException();
        }

        public Task<RequisicaoConta> RetornarSaldo(int numeroConta)
        {
            throw new NotImplementedException();
        }
    }
}
