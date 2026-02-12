/*
🟢 BASIC LEVEL
1️⃣ Divide Two Numbers

Concept: What are exceptions, try / catch

Problem:
Write a program that:

Takes two numbers from the user

Divides them

Handles division by zero exception

Real-world analogy:
ATM tries to divide money into zero accounts → system crash if not handled.
*/
class DivideTwoNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter two numbers:");
        int a =int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        try{
        int c=a/b;
        Console.WriteLine(c);
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
     

        
    }
}