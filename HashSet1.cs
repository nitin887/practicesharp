/*
🧩 5. HashSet<T>
💻 Coding Problem

Create a HashSet<int>:

Add duplicate values
Display unique elements
*/
class HashSet
{
    static void Main()
    {
        HashSet<int> values = new HashSet<int>();
        Console.WriteLine("values to add:");
        for (int i = 0; i < 5; i++)
        {
            int numbers = Convert.ToInt32(Console.ReadLine());


            values.Add(numbers);
        }
        foreach (var result in values)
        {
            Console.WriteLine(result);
        }


    }
}