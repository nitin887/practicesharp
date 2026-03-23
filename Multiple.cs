/*
 Method Returning Multiple Calculations

Create a method Calculate().

Requirements:

Accept two numbers

Return (Sum, Difference, Product)

Print all returned values.

*/

class Multiple
{
    static void Main()
    {
        Console.WriteLine(Operations());







    }
    static (int a, int b) Data()
    {
        Console.WriteLine("enter the value of a and b:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        return (a, b);




    }
    static (int sum, int product, int difference) Operations()
    {
        (int a, int b) = Data();
        return (a + b, a * b, a - b);


    }
}