using System;
using System.Globalization;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Person> list = new List<Person>();

        System.Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            System.Console.WriteLine($"Tax Payer #{i} data:");
            System.Console.Write("Individual or company (i/c)? ");
            char ch = char.Parse(Console.ReadLine());

            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Anual income: ");
            double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            switch (ch)
            {
                case 'i':
                    System.Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),
                     CultureInfo.InvariantCulture);
                    NaturalPerson naturalPerson = new NaturalPerson(name, anualIncome, healthExpenditures);
                    list.Add(naturalPerson);
                    break;

                case 'c':
                    System.Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine(),
                     CultureInfo.InvariantCulture);
                    LegalPerson legalPerson = new LegalPerson(name, anualIncome, numberEmployees);
                    list.Add(legalPerson);
                    break;

            }
        }

        double sum = 0.0;
        System.Console.WriteLine("\nTAXES PAID:");
        foreach (Person person in list)
        {
            sum += person.Tax();
            System.Console.WriteLine($"{person.Name}: $ {person.Tax().ToString("F2",CultureInfo.InvariantCulture)}");
        }
        System.Console.WriteLine($"\nTOTAL TAXES: {sum.ToString("F2",CultureInfo.InvariantCulture)}");   

    }
}

