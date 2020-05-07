using Application.Exceptions;

namespace Application
{
    public class Account
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        
        public Account(int number, string name, double balance, double withdrawLimit)
        {
            Number = number;
            Name = name;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
                throw new DomainException("The amount exceeds witdraw limit");
            if(amount > Balance)
                throw new DomainException("Not enough balance");
           
            Balance -= amount;
        }
    }
}