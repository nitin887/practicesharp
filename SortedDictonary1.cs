/*
🧩 8. SortedDictionary
💻 Coding Problem

Create a SortedDictionary:

Store product ID and price
Display sorted by key
*/
class SortedDictionary1
{
    static void Main()
    {
        Console.WriteLine("Enter the ID And Price:");
        SortedDictionary<int, int> keyValuePairs = new SortedDictionary<int, int>();
        for (int i = 0; i < 3; i++)
        {
            int id = Convert.ToInt32(Console.ReadLine());
            int price = Convert.ToInt32(Console.ReadLine());
            keyValuePairs.Add(id, price);
        }
        foreach (var result in keyValuePairs)
        {
            Console.WriteLine($"{result.Key}-{result.Value}");
        }

    }
}