namespace programa7
{
    public class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

         public Employee(string name, int hours, double valuePerHour)
        {
            this.Name = name;
            this.Hours = hours;
            this.ValuePerHour = valuePerHour;

        }

        public virtual double CalculateSalary()
        {
            return this.Hours * this.ValuePerHour;
        }
    }

}