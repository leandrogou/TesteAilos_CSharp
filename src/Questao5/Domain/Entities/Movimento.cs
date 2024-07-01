namespace Questao5.Domain.Entities
{
    public class Movimento
    {
        public Guid IdMovimento { get; private set; }
        public DateTime DataMovimento { get; private set; }
        public char TipoMovimento { get; private set; }
        public decimal Valor { get; private set; }
        public Guid IdContaCorrente { get; private set; }

        public Movimento(Guid idMovimento, DateTime dataMovimento, char tipoMovimento, decimal valor, Guid idContaCorrente)
        {
            IdMovimento = idMovimento;
            DataMovimento = dataMovimento;
            TipoMovimento = tipoMovimento;
            Valor = valor;
            IdContaCorrente = idContaCorrente;
        }
    }

}
