/*
5️⃣ Bank Withdrawal (Real-World)

Concept: Custom logic + exceptions

Problem:
Create a BankAccount class with:

Withdraw(amount)

Throw exception if:

Amount > balance

Amount ≤ 0
*/

class BankAccount
{

    private double totalAmount=1000;
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new OverflowException("amount is less than or equal to zero");
        }
        else if (amount > totalAmount)
        {
            throw new Exception("amount is greater than available balance");
        }
    totalAmount -= amount;
    Console.WriteLine(totalAmount);

    }
        

        


    
    }
    

class BankWithdrawl
{
    static void Main(string[] args)
    {
        try{
        BankAccount bankAccount = new BankAccount();
          bankAccount.Withdraw(500);
        bankAccount.Withdraw(-9);
      
        bankAccount.Withdraw(1000);
        
        }
        catch(OverflowException es)
        {
            Console.WriteLine(es.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }


        
    }
}