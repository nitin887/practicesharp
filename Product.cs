/*
1️⃣1️⃣ Predicate + RemoveAll

Given a list of products:

Requirements:

Use Predicate<Product>S

Remove products that are out of stock

Print remaining products
*/
using System.Globalization;

class Data
{
    public string Name
    {
        get;
        set;
    }
    public int Stock
    {
        get;
        set;
    }
    public Data(string name, int stock)
    {
        Name = name;
        Stock = stock;
    }
}
class Product
{
    static void Main(string[] args)
    {
        List<Data> data1 = new List<Data>
        {
            new Data("electronics",0),
            new Data("toys",2),
            new Data("cloth",3)

        };
        // Use a predicate that matches the list element type (Data)
        Predicate<Data> predicate = Status;
        // no argument is available here, so don't invoke the delegate without data
        // you can pass it to RemoveAll directly

        data1.RemoveAll(predicate);

        foreach (var number in data1)
        {
            Console.WriteLine(number.Name);
        }











    }
    public static bool Status(Data data)
    {
        return data.Stock == 0;


    }

}