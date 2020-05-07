using System.Globalization;

namespace programa7
{
    public class OutsourcedEmployee : Employee
    {
      
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
             : base(name, hours, valuePerHour)
        {
            this.AdditionalCharge = additionalCharge;
        }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() + 1.1 * AdditionalCharge;            
        }

        public override string ToString()
        {
            return this.Name + " - $"  + this.CalculateSalary().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
    
}