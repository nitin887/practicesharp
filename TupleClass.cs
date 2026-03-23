/*
2️⃣ Tuple Class – Store Product Details

Create a list of Tuple<string, double>.

Requirements:

Store ProductName and Price

Add at least 5 products

Print all product details.
*/
using System.Diagnostics.Contracts;

class TupleClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the number of record:");
        int number = Convert.ToInt32(Console.ReadLine());

        List<Tuple<string, double>> product = new List<Tuple<string, double>>();


        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("enter the productname and price");
            string productName = Console.ReadLine();
            double price = Convert.ToDouble(Console.ReadLine());
            product.Add(new Tuple<string, double>(productName, price));



        }
        foreach (var tuple in product)
        {
            Console.WriteLine(tuple);
        }



    }
}