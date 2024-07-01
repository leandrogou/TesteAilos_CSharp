using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Database.CommandStore.Requests
{
    public interface IAPIBanco
    {
        Task<Movimento> AdicionarMovimentacao(Movimento movimento);
        Task<IdEmpotencia> AdicionarIdEmpotent(IdEmpotencia idEmpotencia);
        Task<RequisicaoConta> RetornarSaldo(int numeroConta);
    }
}
