
namespace programa2
{
    public class ContaBancaria
    {
        private int _numeroConta;
        public string Titular { get; private set; } 
        public double Saldo { get; private set;}

        public ContaBancaria(int numero, string titular)
        {
            _numeroConta = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Depositar(saldo);
        }

        public void Status()
        {
            System.Console.WriteLine($"Conta {_numeroConta}, Titular: {Titular}, Saldo: $ {Saldo:F2}");
        }

        public void Depositar(double valor)
        {    
            Saldo += valor;
        }


        public void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }


    }
}