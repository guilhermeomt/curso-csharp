using System;
using System.Collections.Generic;
using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
           List<Product> list = new List<Product>();

            System.Console.Write("Enter the number of product(s): ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Product #{i} data:");
                System.Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch(ch)
                {
                    case 'c':
                        Product product = new Product(name,price);
                        list.Add(product);
                        break;

                    case 'u':
                        System.Console.Write("Manufacture date (DD/MM/YYYY): ");   
                        DateTime dateTime = DateTime.Parse(Console.ReadLine(), CultureInfo.CurrentCulture); 
                        UsedProduct usedProduct = new UsedProduct(name, price, dateTime);
                        list.Add(usedProduct);
                        break;  
                    
                    case 'i':
                        System.Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        ImportedProduct importedProduct = new ImportedProduct(name, price, customsFee);
                        list.Add(importedProduct);   
                        break;
                }
            }

            System.Console.WriteLine("PRICE TAGS: ");
            foreach(Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
