using System;
using System.Collections.Generic;

namespace Code
{
        class Problem
        {
            public enum Dias{
                Domingo, 
                Segunda,
                Terca,
                Quarta,
                Quinta,
                Sexta,
                Sabado
            };
            static void Main(string[] args)
            {
                int i = (int) Dias.Sabado;
                System.Console.WriteLine(i);

                var numeros = new Dictionary<int,int>();

                numeros.Add(1,10);

                foreach(int n in numeros.Keys){
                    System.Console.WriteLine("Chave {0}, Valor {1}",n, numeros[n]);
                }   
            }
        }
}