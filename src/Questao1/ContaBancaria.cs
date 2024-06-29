using System.Globalization;

namespace Questao1
{
    class ContaBancaria
    {
        public long Conta { get; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(long conta, string titular, double saldo)
        {
            Conta = conta;
            Titular = titular;
            Saldo = saldo;
        }
        public ContaBancaria(long conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            Saldo -= (valor+3.50);
        }
        public override string ToString()
        {
            return string.Format("Conta {0}, Titular: {1}, Saldo: $ {2}",Conta,Titular,Saldo.ToString("n2",CultureInfo.InvariantCulture));
        }
    }
}
