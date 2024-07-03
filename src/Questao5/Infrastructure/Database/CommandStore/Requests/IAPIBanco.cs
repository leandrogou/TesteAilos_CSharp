using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Database.CommandStore.Requests
{
    public interface IAPIBanco
    {
        //Task<Movimento> AdicionarMovimentacao(Movimento movimento);
        //Task<IdEmpotencia> AdicionarIdEmpotent(IdEmpotencia idEmpotencia);
        Task Save(Movimento movimento);
        Task Update(Movimento movimento);
        Task Save(IdEmpotencia idEmpotencia);
        Task Update(IdEmpotencia idEmpotencia);
        Task<RequisicaoConta> RetornarSaldo(int numeroConta);
    }
}
