using MediatR;

namespace Questao5.Domain.Entities
{
    public class IdEmpotencia 
    {
        public Guid chave_IdEmpotencia { get; private set; }
        public string Requisicao { get; private set; }
        public string Resultado { get; private set; }

        public IdEmpotencia(Guid chave_IdEmpotencia, string requisicao, string resultado)
        {
            this.chave_IdEmpotencia = chave_IdEmpotencia;
            Requisicao = requisicao;
            Resultado = resultado;
        }
    }

}
