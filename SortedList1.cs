/*
🧩 4. SortedList
💻 Coding Problem

Create a SortedList:

Add student ID and name
Display in sorted order of keys
*/
class SortedList1
{
    static void Main()
    {
        Console.WriteLine("Enter the length of data:");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Id,name:");
        SortedList<int, string> keyValuePairs = new SortedList<int, string>();
        for (int i = 0; i < size; i++)
        {
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();

            keyValuePairs.Add(id, name);


        }
        Console.WriteLine("element has been added to list");
        foreach (var data in keyValuePairs)
        {
            Console.WriteLine($"{data.Key}-{data.Value}");
        }




    }
}