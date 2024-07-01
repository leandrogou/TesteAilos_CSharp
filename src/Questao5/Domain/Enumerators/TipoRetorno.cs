namespace Questao5.Domain.Enumerators
{
    public enum TipoRetorno
    {
        INVALID_ACCOUNT = 0,//Apenas contas correntes cadastradas podem receber movimentação; OU Apenas contas correntes cadastradas podem consultar o saldo;
        INACTIVE_ACCOUNT = 1,//Apenas contas correntes ativas podem receber movimentação; OU Apenas contas correntes ativas podem consultar o saldo; 
        INVALID_VALUE = 2,//Apenas valores positivos podem ser recebidos; 
        INVALID_TYPE = 3//Apenas os tipos “débito” ou “crédito” podem ser aceitos; 
    }
}
