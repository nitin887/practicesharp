/*
🧩 8. Banking Transfer System (Advanced)
🎯 Concept: Nested Try-Catch + Custom Exceptions

Problem:
Transfer money between two accounts.

⚠️ Requirements:
Validate:
Sender balance
Transfer amount
Use:
Nested try-catch
Custom exceptions
Ensure transaction rollback if error occurs
*/
class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {

    }

}
interface Operations
{
    void Deposit();
    void Withdraw(double withdrawAmount);

}
class Account1 : Operations
{
    private static double balance = 5000.0d;

    public static double Balance
    {
        get
        {
            return balance;
        }
        set
        {
            balance = value;
        }
    }
    public void Deposit()
    {
        Console.WriteLine("Enter the deposit amount:");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        balance += depositAmount;
        Console.WriteLine($"balance after deposit of {depositAmount}:" + balance);

    }
    public void Withdraw(double withdrawAmount)
    {
        Console.WriteLine("Enter the withdraw amount:");
        balance -= withdrawAmount;
        Console.WriteLine($"balance after withdrwal of {withdrawAmount}:" + balance);

    }


}
class Account2 : Operations
{
    private static double balance = 6000.0d;
    public static double Balance
    {
        get
        {
            return balance;
        }
        set
        {
            balance = value;
        }
    }
    public void Deposit()
    {
        Console.WriteLine("Enter the deposit amount:");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        balance += depositAmount;
        Console.WriteLine($"balance after deposit of {depositAmount}:" + balance);

    }
    public void Withdraw(double withdrawAmount)
    {
        Console.WriteLine("Enter the withdraw amount:");
        balance -= withdrawAmount;
        Console.WriteLine($"balance after withdrwal of {withdrawAmount}:" + balance);

    }


}
class BankingTransferSystem
{
    static void Main()
    {
        try
        {
            if (Account1.Balance <= 0 | Account2.Balance <= 0)
            {
                throw new InsufficientFundsException("Account do not have sufficent balance to procced transfer");
            }
            else
            {
                Console.WriteLine("enter the amount to perform the transfer ");
                double amount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Choose the sender:\n 1.Account1 \n 2.Account2");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Account1 account1 = new Account1();
                        account1.Withdraw(amount);
                        Account2.Balance += amount;
                        Console.WriteLine("Money tranferred from account1 to account2");
                        break;

                    case 2:
                        Account2 account2 = new Account2();
                        account2.Withdraw(amount);
                        Account1.Balance += amount;
                        Console.WriteLine("Money transferred from account2 from account1");
                        break;

                }
            }
        }
        catch (InsufficientFundsException es)
        {
            Console.WriteLine(es.Message);
        }
    }
}