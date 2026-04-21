/*
🧩 13. BitArray Class
💻 Coding Problem

Create a BitArray:

Store boolean values
Perform AND operation with another BitArray
*/
using System.Collections;

class BitArray1
{
    static void Main()
    {
        bool[] bools = [true, false, true, false, true];
        BitArray bitArray = new BitArray(bools);
        BitArray bitArrays = new BitArray(bools);
        foreach (var obj in bitArray)
        {
            Console.WriteLine(obj.And(bitArrays));
        }

    }
}