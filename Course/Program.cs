using System;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter client data:");
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client{
                Name = name,
                Email = email,
                BirthDate = birthDate
            };

            System.Console.WriteLine("\nEnter order data:");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime moment = DateTime.Now;

            Order order = new Order(moment, status, client);
            System.Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Enter #{i} item data: ");
                System.Console.Write("Product name: ");
                string productName = Console.ReadLine();
                System.Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Product quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem{
                    Quantity = quantity,
                    Price = price,
                    Product = new Product{
                        Name = productName,
                        Price = price,
                    }
                                };

                order.addItem(item);
            }

            System.Console.WriteLine("\nORDER SUMMARY: ");
            System.Console.WriteLine(order);

        }
    }
}