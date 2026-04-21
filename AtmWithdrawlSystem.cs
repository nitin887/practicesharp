/*
🧩 3. ATM Withdrawal System
🎯 Concept: Custom Exception + Multiple Catch

Problem:
Simulate ATM withdrawal.

⚠️ Requirements:
Initial balance = ₹5000
Throw:
InsufficientBalanceException if withdrawal > balance
InvalidAmountException if amount ≤ 0
Handle:
FormatException
Custom exceptions
Use multiple catch blocks
*/
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {

    }
}
class InvalidAmountException : Exception
{
    public InvalidAmountException(string message) : base(message)
    {


    }
}
class Operation
{
    public static double balance = 5000;
    public void Withdraw()
    {
        try
        {
            Console.WriteLine("Enter the amount to withdraw:");
            double WithdrawAmount = Convert.ToDouble(Console.ReadLine());
            balance -= WithdrawAmount;
            if (WithdrawAmount > balance)
            {
                throw new InsufficientBalanceException("withdrawl amount is greater than balance");
            }
            else if (WithdrawAmount <= 0)
            {
                throw new InvalidAmountException("Withdraw amount cannot be negative or zero");
            }
        }
        catch (FormatException es)
        {
            Console.WriteLine(es.Message);
        }

        catch (InvalidAmountException ep)
        {
            Console.WriteLine(ep.Message);
        }
        catch (InsufficientBalanceException e)
        {
            Console.WriteLine(e.Message);
        }


    }
    public void Deposit()
    {
        try
        {
            Console.WriteLine("Enter the amount to deposit:");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            balance += depositAmount;
            if (depositAmount <= 0)
            {
                throw new InvalidAmountException("deposit amount cannot be negative or zero");

            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (InvalidAmountException es)
        {
            Console.WriteLine(es.Message);
        }
        finally
        {
            Console.WriteLine("Transaction cOMPLETED");
        }



    }
    public void Balance()
    {
        Console.WriteLine("current balance:" + balance);

    }
}
class AtmWithdrawlSystem
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter the operation to perform:\n1.Deposit\n2.Withdraw\n3.balance");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Operation operation = new Operation();
                        operation.Deposit();
                        break;
                    case 2:
                        operation = new Operation();
                        operation.Withdraw();
                        break;
                    case 3:
                        operation = new Operation();
                        operation.Balance();
                        break;

                    default:
                        Console.WriteLine("Invalid Operation");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Transaction Completed");
            }

        }


    }
}