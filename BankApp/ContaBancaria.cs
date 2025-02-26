public class ContaBancaria
{
    public int Numero_Conta { get; private set; }
    public string Titular { get; set; }
    public double Deposito_Inicial { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(int numero_conta, string titular)
    {
        this.Titular = titular;
        this.Numero_Conta = numero_conta;
        this.Deposito_Inicial = 0.0f;
        this.Saldo = 0.0f;
    }
    public ContaBancaria(int numero_conta, string titular, double deposito_inicial) : this(numero_conta, titular)
    {
        Deposito(deposito_inicial);
    }


    public void Deposito(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
    }
    public void Saque(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor + 5.0;
        }
    }


}
