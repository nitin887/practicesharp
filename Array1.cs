/*
🧩 1. Array Class
💻 Coding Problem

Create an integer array and:

Sort it using Array.Sort()
Reverse it using Array.Reverse()
Find index of an element
*/
class Array1
{
    static void Main()
    {
        // * 1 >  2
        //  2  = 1
        int[] arrays = [1, 5, 3, 6, 5];
        //reverse array
        var result = arrays.Reverse();
        foreach (int data in result)
        {
            Console.WriteLine(data);
        }
        //sort
        Array.Sort(arrays);
        foreach (int data1 in arrays)
        {
            Console.WriteLine(data1);
        }

        Console.WriteLine(arrays[1]);




    }
}