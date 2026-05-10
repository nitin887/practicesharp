/*
🧩 8. Index and Range
💻 Coding Problem

Create an array:

Extract:
Last element using ^1
Range using [1..4]
*/
class IndexAndRange
{
    static void Main()
    {
        int[] arr = [1, 2, 3];
        Console.WriteLine(arr[^1]);
        var pa = arr[0..3];
        foreach (var data in pa)
        {
            Console.WriteLine(data);
        }


    }
}