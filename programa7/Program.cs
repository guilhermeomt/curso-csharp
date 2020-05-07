using System;

namespace programa7
{
    class Program
    {
        static void Main(string[] args)
        {
          OutsourcedEmployee em = new OutsourcedEmployee()
          {Name = "Robert", Hours = 50, ValuePerHour = 12, AdditionalCharge = 200 };
         
          Console.WriteLine(em);
        }
    }
}
