using System;
using System.Collections.Generic;
using System.Globalization;
    class Program
    {
        static void Main(string[] args)
        {           
           System.Console.Write("Quantos funcionários serào cadastrados? ");
           int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();
            for(int i = 0; i < n; i++)
            {
                System.Console.Write("Funcionario #" + (i+1) + ":\nID: ");
                int id = int.Parse(Console.ReadLine());
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(){Id = id, Nome = nome, Salario = salario} );
                System.Console.WriteLine();
            }

            System.Console.Write("Entre com o id do funcionario que recebera um aumento:");
            int idBusca = int.Parse(Console.ReadLine());
            
            Funcionario func = list.Find(x => x.Id == idBusca);
            if(func != null)
            {
                System.Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.aumentarSalario(porcentagem);
                
            }
            else   
                System.Console.WriteLine("ID de funcionario não encontrado!");

            System.Console.WriteLine("Lista atualizada dos funcionarios:");
            foreach(Funcionario f in list)
                System.Console.WriteLine($"{f.Id}, {f.Nome}, {f.Salario.ToString("F2")}");            

        }

    }

