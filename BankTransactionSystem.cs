/*
💻 Problem: Bank Transaction System with Exception Handling
🧩 Problem Statement

Create a simple Bank Account Management System in C# that performs the following operations:
 
Deposit money
Withdraw money
Check balance

The program must handle runtime errors gracefully using Exception Handling concepts.

⚙️ Requirements
🔹 1. Basic Functionality
Initialize account with a balance (e.g., ₹10,000).
Allow user to:
Deposit amount
Withdraw amount
Exit program
🔹 2. Exception Handling Rules
✅ System-Level Exceptions

Handle:

Invalid input (e.g., user enters text instead of number → FormatException)
Division by zero (simulate somewhere if needed)
✅ Application-Level Exceptions (Custom)

Create custom exceptions:

InsufficientBalanceException → when withdrawal amount > balance
InvalidAmountException → when amount ≤ 0
🔹 3. Use Try-Catch-Finally
Wrap all user operations in try-catch-finally
finally block should display: "Transaction completed."
🔹 4. Multiple Catch Blocks

Use multiple catch blocks to handle:

FormatException
InsufficientBalanceException
InvalidAmountException
General Exception
🔹 5. Nested Try-Catch
Inside withdrawal logic, use a nested try-catch block to:
Validate amount
Throw custom exceptions
🧪 Sample Input/Output
Enter choice:
1. Deposit
2. Withdraw
3. Exit

Choice: 2
Enter amount: 15000

Error: Insufficient balance!
Transaction completed.
Choice: 1
Enter amount: -500

Error: Invalid amount!
Transaction completed.
Choice: 1
Enter amount: abc

Error: Input must be a number!
Transaction completed.
🎯 Bonus Challenge
Add logging (print error messages with timestamps)
Allow retry without crashing the program
Add a menu loop until user exits
🧠 Concepts Covered
Exception Handling (try-catch-finally)
Multiple Catch Blocks
Nested Try-Catch
Custom Exceptions
System vs Application Exceptions
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
    private static double balance = 0;
    public void DepositMoney()
    {
        try
        {
            Console.WriteLine("enter the deposit amount:");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            if (depositAmount > 0)
            {
                balance += depositAmount;
                Console.WriteLine($"Amount {depositAmount} has been credited");
                Console.WriteLine($"balance after deposit: {balance}");

            }
            else if (depositAmount <= 0)
            {
                throw new InvalidAmountException("amount is less than or equal to zero");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InsufficientBalanceException ew)
        {
            Console.WriteLine(ew.Message);

        }
        catch (InvalidAmountException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception ep)
        {
            Console.WriteLine(ep.Message);

        }
        finally
        {
            Console.WriteLine("Transaction completed");
        }




    }
    public void WithdrawMoney()
    {
        try
        {
            Console.WriteLine("enter the withdraw amount:");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            if (withdrawAmount <= balance && withdrawAmount > 0)
            {
                balance -= withdrawAmount;
                Console.WriteLine($"Amount {withdrawAmount} has been deducted");
                Console.WriteLine($"balance after withdrawl: {balance}");

            }
            else if (withdrawAmount > balance)
            {
                throw new InsufficientBalanceException("withdrawl amount is greater than balance");
            }
            else if (withdrawAmount <= 0)
            {
                throw new FormatException("withdraw amount is negative");
            }

        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (InsufficientBalanceException ew)
        {
            Console.WriteLine(ew.Message);

        }
        catch (InvalidAmountException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception ep)
        {
            Console.WriteLine(ep.Message);

        }
        finally
        {
            Console.WriteLine("transaction completed");
        }



    }
    public void CheckBalance()
    {

        Console.WriteLine("Current balance:" + balance);
    }


}
class BankTransactionSystem
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter choice:\n1. Deposit\n2. Withdraw\n3. view balance");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Operation operation = new Operation();
                    operation.DepositMoney();
                    break;
                case 2:
                    operation = new Operation();
                    operation.WithdrawMoney();
                    break;
                case 3:
                    operation = new Operation();
                    operation.CheckBalance();
                    break;
                default:
                    Console.WriteLine("please choose appropriate operation to perform");
                    break;
            }

        }


    }
}