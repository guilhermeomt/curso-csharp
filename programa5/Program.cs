using System;

namespace programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de linhas n da matriz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de linhas m da matriz: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,m];

            for(int i = 0; i < n; i++){
                string[] valores = Console.ReadLine().Split(' ');                
                
                for(int j = 0; j < m; j++)
                    matriz[i,j] = int.Parse(valores[j]);
            }

            int elemento = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {

                for(int j  = 0; j < m; j++)
                {
                    if(matriz[i,j] == elemento)
                    {
                        System.Console.WriteLine("Posicao " + i + ',' + j + ':');
                        if(i > 0)
                            System.Console.WriteLine("Cima:" + matriz[i-1,j]);

                        if(i < n -1)
                        {
                            System.Console.WriteLine("Baixo:" + matriz[i+1,j]);
                        }

                        if(j > 0)
                            System.Console.WriteLine("Esquerda:" + matriz[i,j-1]);

                        if(j < m - 1)
                        {
                            System.Console.WriteLine("Direita:" + matriz[i,j+1]);
                        }

                    }
                }
            }

        }
    }
}
