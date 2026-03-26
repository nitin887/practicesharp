/*
6️⃣ Generic Method – Find Maximum

Create a method FindMax<T>().

Requirements:

Accept three parameters
Return the largest value
Use generic constraint so only comparable types are allowed.
*/
using System.IO.Pipelines;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

class Operation<T> where T : IComparable<T>
{


    public T Comparison(T a, T b, T c)
    {
        T largest = a;

        if (b.CompareTo(largest) > 0)
        {
            largest = b;
        }
        if (c.CompareTo(largest) > 0)
        {
            largest = c;
        }
        return largest;

    }



}
class Max
{
    static void Main()
    {
        Console.WriteLine("Enter the value of three numbers:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        Operation<int> operation = new Operation<int>();

        Console.WriteLine("largest number is:" + operation.Comparison(a, b, c));


    }


}
