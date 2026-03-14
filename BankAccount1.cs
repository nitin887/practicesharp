/*
1️⃣2️⃣ Event with Multiple Subscribers (Advanced)

Create a BankAccount class.

Requirements:

Event BalanceChanged

When deposit/withdraw happens, trigger event

Multiple subscribers:

SMS notification

Email notification

Audit logger

*/
class BankAccount1
{
    public delegate void MyDelegate();
    public event MyDelegate BalanceChanged;
    public int amountInBank = 1000;

    static void Main(string[] args)
    {

        Console.WriteLine("enter the amount : ");
        int amount = Convert.ToInt32(Console.ReadLine());

        BankAccount1 bankAccount1 = new BankAccount1();
        bankAccount1.BalanceChanged += bankAccount1.SmsNotification;
        bankAccount1.BalanceChanged += bankAccount1.EmailNotification;
        bankAccount1.BalanceChanged += bankAccount1.AuditLogger;

        bankAccount1.Withdraw(amount);
        bankAccount1.Depsoit(amount);





    }
    void Withdraw(int amount)
    {
        amountInBank -= amount;
        BalanceChanged?.Invoke();
        Console.WriteLine("amount in bank:" + amountInBank);


    }
    void Depsoit(int amount)
    {
        amountInBank += amount;
        BalanceChanged?.Invoke();
        Console.WriteLine("amount in bank:" + amountInBank);


    }
    void SmsNotification()
    {
        Console.WriteLine("amount debited or credited");
    }
    void EmailNotification()
    {
        Console.WriteLine("change in account has been deducted");
    }
    void AuditLogger()
    {
        Console.WriteLine("new transaction detected");
    }
}