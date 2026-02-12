/*
🔴 ADVANCED LEVEL
7️⃣ Custom Exception

Concept: Custom exception class

Problem:
Create a custom exception:

InsufficientBalanceException


Throw it when withdrawal amount exceeds balance.
*/

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
        
    }
    
}
class CustomException
{
    public int Totalamount = 1000;
    
    static void Main(string[] args)
    {
        try
        {
            CustomException customException = new CustomException();
            Console.WriteLine("Enter the withdrawal amount:");
            int n = int.Parse(Console.ReadLine());
            
            if (n > customException.Totalamount)
            {
                throw new InsufficientBalanceException("Withdrawal amount is larger than balance.");
            }
            
            customException.Totalamount -= n;
            Console.WriteLine($"Withdrawal successful. Remaining balance: {customException.Totalamount}");
        }
        catch(InsufficientBalanceException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch(FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
    }
    
}
