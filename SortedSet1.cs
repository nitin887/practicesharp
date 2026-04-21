/*
🧩 6. SortedSet<T>
💻 Coding Problem

Create a SortedSet<int>:

Add random numbers
Display them in ascending order
*/
class SortedSet1
{
    static void Main()
    {
        Console.WriteLine("Enter the  random numbers:");
        SortedSet<int> numbers = new SortedSet<int>();

        for (int i = 0; i < 5; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            numbers.Add(number);

        }

        foreach (var result in numbers)
        {
            Console.WriteLine(result);
        }




    }
}