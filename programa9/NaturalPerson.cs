public class NaturalPerson : Person
{
    public double HealthExpenditures { get; set; }
    public NaturalPerson(string name, double anualIncome, double healthExpenditures)
        : base(name, anualIncome)
    {
        HealthExpenditures = healthExpenditures;
    }

    public override double Tax()
    {
        if (this.AnualIncome < 20000)
            return AnualIncome * 0.15 - HealthExpenditures * 0.5;
        else
            return AnualIncome * 0.25 - HealthExpenditures * 0.5;
    }
}