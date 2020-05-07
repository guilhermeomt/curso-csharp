public class LegalPerson : Person
{
    public int NumberEmployees { get; set; }
    public LegalPerson(string name, double anualIncome, int numberEmployees) 
           : base(name, anualIncome)
    {   
        NumberEmployees = numberEmployees;
    }

    public override double Tax()
    {
        if(NumberEmployees <= 10)
            return AnualIncome * 0.16;
        else
            return AnualIncome * 0.14;
    }  
}