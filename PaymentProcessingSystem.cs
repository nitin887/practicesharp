/*
🔥 FINAL BOSS (INTERVIEW LEVEL)
🔟 Payment Processing System

Concepts Used:

Custom exceptions

Multiple catch

finally block

Problem:
Create:

PaymentFailedException

ProcessPayment(amount)

Throw exception if:

Amount ≤ 0

Network error (simulate)
*/
public class PaymentFailedException : Exception
{
    public PaymentFailedException(string message):base(message)
    {
    
        
    }
}
class Payment
{
    private bool Connection=false;
    public int Amount
    {
        get;
        set;
        
    }
    public Payment(int amount,bool connection)
    {
        Amount=amount;
        Connection=connection;
    }
    public void ProcessPayment(int amount)
    {
        if (amount <= 0)
            throw new PaymentFailedException("Enter a valid amount to process.");
        if (!Connection)
            throw new PaymentFailedException("Network error: connection unavailable.");
        // simulate intermittent network failure
        if (new Random().Next(0, 5) == 0)
            throw new PaymentFailedException("Network error: timeout during processing.");

        Amount += amount;
        Console.WriteLine("amount processed: " + Amount);
    }
    public void Deposit(int amount)
    {
        if (amount <= 0)
        {
            throw new PaymentFailedException("Enter any valid amount to deposit");
        }
        Amount += amount;
        Console.WriteLine("amount deposited: " + Amount);
        
    }
    public void Withdraw(int amount )
    { 
        if (amount <= 0)
        {
            throw new PaymentFailedException("Enter a valid amount to withdraw");
        }
        if (amount > 0 && amount <= Amount)
        {
            Amount -= amount;
            Console.WriteLine("remaining balance: " + Amount);
        }
        else if (amount > Amount)
        {
            throw new PaymentFailedException("Withdraw amount greater than deposit amount");
        }
    }
        
}
class PaymentProcessingSystem
{
    static void Main(string[] args)
    {
        // demo usage with exception handling
        Payment p = new Payment(100, true);
        try
        {
            p.Deposit(50);
            p.Withdraw(30);
            p.ProcessPayment(20);
            // trigger an error
            p.ProcessPayment(0);
        }
        catch (PaymentFailedException ex)
        {
            Console.WriteLine("Payment failed: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction attempted. Current balance: " + p.Amount);
        }
    }
}