/*
🔹 BASIC LEVEL
1️⃣ Generic Method – Swap Values

Create a generic method Swap<T>().

Requirements:

Accept two parameters of the same type
Swap their values
Test the method with:
integers
strings
doubles
*/
using System.Runtime.Serialization;

class SwapValues
{
    (T, T) Swap<T>(ref T a, ref T b)
    {
        T Temp = a;
        a = b;
        b = Temp;
        return (a, b);

    }
    static void Main()
    {
        Console.Write("enter the value of a and b:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        SwapValues swapValues = new SwapValues();

        Console.WriteLine(swapValues.Swap<int>(ref a, ref b));
        string e = "ref";
        string f = "erf";
        Console.WriteLine(swapValues.Swap<string>(ref e, ref f));

        double g = 9.7d;
        double h = 3.4d;
        Console.WriteLine(swapValues.Swap<double>(ref g, ref h));


    }
}