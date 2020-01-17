using System;

namespace programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] vect = new Aluguel[10];

            for(int i = 0; i < n; i++){
                System.Console.Write("Rent #" + (i + 1) + "\nName: ");
                string name = Console.ReadLine();
                System.Console.Write("Email: ");
                string email = Console.ReadLine();
                System.Console.Write("Room: ");
                int selected_room = int.Parse(Console.ReadLine());
                
                vect[selected_room] = new Aluguel { Nome = name, Email = email };
            }

            System.Console.WriteLine("Quartos Ocupados: ");

            for(int i = 0; i < 10; i++)
            {
               
                if(vect[i] != null){
                     System.Console.WriteLine($"{i}: {vect[i].Nome}, {vect[i].Email}");      
                }
            }
          
        }
    }
}
