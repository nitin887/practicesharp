/*




















*/
using System.Diagnostics;

class Delegates
{
    /*
    1️⃣ Simple Delegate Calculator

     Create a delegate that performs a mathematical operation on two numbers.

     Requirements:

     Define a delegate Operation

    Create methods: Add, Subtract, Multiply

    Assign methods to delegate dynamically

    Execute based on user choice
    */
    static void Main(string[] args)
    {
        Console.WriteLine("enter the two numbers:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Operation operation = Addition;
        Console.WriteLine(operation(a, b));
        Operation operation1 = Subtraction;
        Console.WriteLine(operation1(a, b));
        Operation operation2 = Multiplication;
        Console.WriteLine(operation2(a, b));


    }
    public delegate int Operation(int a, int b);
    public static int Addition(int a, int b)
    {
        return a + b;

    }
    public static int Subtraction(int a, int b)
    {
        return a - b;
    }
    public static int Multiplication(int a, int b)
    {
        return a * b;
    }

}