using System;
using System.Collections.Generic;

class Dict
{
    static void Main(string[] args)
    {
        Console.Write("enter the word to count nubers of occurence: ");
        string? word = Console.ReadLine();
        int occurence=0;
        if ( word==null )
        {
            Console.WriteLine("Invalid word input. that do not exist");
            return;
        }

        Dictionary<int,string> data= new Dictionary<int, string>
        {
            { 1, "apple" },
            { 2, "banana" },
            {3,"apple"}
        };
        foreach(KeyValuePair<int,string> keyValue in data)
        {
            if (word == keyValue.Value)
            {
                occurence++;
            }
          
        }
            Console.WriteLine($"no of occurenece of key vlaue :{word} is{occurence}");

    }
}
