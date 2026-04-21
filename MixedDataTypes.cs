/*
🧩 3. ArrayList
💻 Coding Problem

Create an ArrayList:

Add mixed data types (int, string, double)
Iterate and print only integers
*/
using System.Collections;

class MixedDataType
{
    static void Main()
    {
        ArrayList arrayList = [1, "nitin", 2.56];
        foreach (var data in arrayList)
        {
            if (data is int)
                Console.WriteLine(data);
        }



    }
}