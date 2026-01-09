using System;

class CopyingArray
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int[] arr1 = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
            arr1[i] = arr[i];

        Console.WriteLine("New array:");
        Console.Write("[");
        for (int i = 0; i < arr1.Length; i++)
        {
            if (i > 0) Console.Write(",");
            Console.Write(arr1[i]);
        }
        Console.WriteLine("]");
    }
}