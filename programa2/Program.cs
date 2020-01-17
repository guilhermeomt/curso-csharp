using System;
using System.Globalization;

namespace programa2
{
    class Program
    {
        static void Main(string[] args)
        {
           ContaBancaria c1;
           char opcao;

           System.Console.Write("Entre com o número da conta: ");
           int numero = int.Parse(Console.ReadLine());
           
           System.Console.Write("Entre o titular da conta: "); 
           string titular = Console.ReadLine();

           System.Console.Write("Haverá depósito inicial? (s/n)? ");
           opcao = char.Parse(Console.ReadLine());

            if(opcao == 's' || opcao == 'S')
            {
                System.Console.Write("Entre o valor do depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c1 = new ContaBancaria(numero, titular, valorInicial);
            }
            else 
            {
                c1 = new ContaBancaria(numero, titular);
            }
            
            c1.Status();

            System.Console.Write("Entre com valor para depósito: ");
            double deposito  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Depositar(deposito);
            c1.Status();

            System.Console.Write("Entre com valor para saque: ");
            double saque  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Sacar(saque);


        }
    }
}
