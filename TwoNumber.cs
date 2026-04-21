/*
🧩 1. Basic Input Validation Program
🎯 Concept: System-Level Exceptions + Try-Catch

Problem:
Write a program that asks the user to enter two numbers and prints their division.

⚠️ Requirements:
Handle:
FormatException (non-numeric input)
DivideByZeroException
Use try-catch-finally
Always print "Operation finished" in finally
*/
class TwoNumber
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter The Two Numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            try
            {
                int c = a / b;
                Console.WriteLine($"divison of {a} and {b} is:" + c);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("number is not divisible by zero");
            }






        }

        catch (FormatException e)
        {
            Console.WriteLine(e.Message);


        }
        finally
        {
            Console.WriteLine("Operation finished");
        }





    }
}