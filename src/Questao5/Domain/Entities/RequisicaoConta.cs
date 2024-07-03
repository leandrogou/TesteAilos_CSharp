using MediatR;

namespace Questao5.Domain.Entities
{
    public class RequisicaoConta : INotification
    {
        public string IdRequisicao { get; set; }
        public int IdContacorrente { get; set; }
        public double ValorMovimentar { get; set; }
        public DateTime Resposta { get; set; }
    }
}
