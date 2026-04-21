/*
🧩 7. Dictionary<TKey, TValue>
💻 Coding Problem

Create a Dictionary<int, string>:

Store employee ID and name
Search by key
*/
class Dictionary1
{
    static void Main()
    {
        Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
        Console.WriteLine("Enter the ID AND name:");
        for (int i = 0; i < 3; i++)
        {
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();

            keyValuePairs.Add(id, name);
        }
        foreach (var item in keyValuePairs)
        {
            Console.WriteLine($"{item.Key}-{item.Value}");

        }

    }
}