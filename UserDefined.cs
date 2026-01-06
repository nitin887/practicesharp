using System;

class UserDefined
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array:");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Invalid size. Exiting.");
            return;
        }

        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of the array (one per line):");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.Write("Invalid number. Please enter again: ");
            }
        }

        Console.WriteLine("Elements of the array:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(arr[i]);
        }

        int sum = 0;
        int min = arr[0];
        int max = arr[0];
        foreach (int v in arr)
        {
            sum += v;
            if (v < min) min = v;
            if (v > max) max = v;
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Minimum: {min}");
        Console.WriteLine($"Maximum: {max}");
    }
}