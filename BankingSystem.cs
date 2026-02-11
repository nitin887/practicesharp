using System;
using System.Collections.Generic;

abstract class Account
{
    public double Balance
    {
        get;
        protected set;
    }
    public  Account(double balance)
    {
        Balance=balance;
    }
    public abstract double CalculateInterest();
}
class BankingSystem:Account
{
    private const double InterestRate=0.04;
    public BankingSystem(double balance):base(balance)
    {
        
    }
    public override double CalculateInterest()
    {
        return Balance*InterestRate;

    }
    
    static void Main(string[] args)
    {
        List<Account> accounts =new List<Account>
        {
            new BankingSystem(1000)
        };
        foreach(Account Acc in accounts)
        {
            Console.WriteLine("Balance: {0}, Interest: {1}", Acc.Balance, Acc.CalculateInterest());
        }


        
    }
}