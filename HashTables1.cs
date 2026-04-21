/*
🧩 9. Hashtable
💻 Coding Problem

Create a Hashtable:

Store mixed key-value pairs
Print all entries
*/
using System.Collections;
using System.Security.Cryptography;

class Hashtables1
{
    static void Main()
    {
        Hashtable hashtable = new Hashtable
        {
            { 1, 6 },{"nitin","mukesh"},{2,4}
        };
        foreach (var result in hashtable)
        {
            Console.WriteLine(result);
        }

    }
}