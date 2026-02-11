/*
2️⃣ Bank Account (Encapsulation Intro)

Concepts: Encapsulation, Properties

Problem:
Create a BankAccount class:

Private field: balance

Public property: Balance (read-only)

Methods: Deposit(amount), Withdraw(amount)

Rules:

Withdrawal should not be allowed if amount > balance
*/
using System.Runtime;

class BankAccount
{
    private double balance;
    public double Balance
    {
        get
        {
         return balance;   
        }
    }
    public BankAccount(double initialBalance)
    {
        if (initialBalance > 0)
        {
            balance=initialBalance;
        }
        else
        {
            balance=0;
        }
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance+=amount;
         Console.WriteLine("balance after  deposit:"+balance);
        }
        else if (amount <= 0)
        {
            Console.WriteLine("invaid amount to deposit");
        }
        
        
    }
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount < balance)
        {
            balance-=amount;
            Console.WriteLine("current balance after withdraw:"+balance);
        }
        else if(amount<0 && amount>balance)
        {
            Console.WriteLine("invalid ammount to debit");
        }
    }
    
    static void Main(string[] args)
    {
     BankAccount bankAccount=new BankAccount(100);
     Console.WriteLine("current money in bank:"+bankAccount.Balance);
     bankAccount.Deposit(50);
     bankAccount.Withdraw(30);
    Console.WriteLine("current money in bank:"+bankAccount.Balance);
      


        
    }
}