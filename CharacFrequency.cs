using System;
using System.Collections.Generic;

class CharacFrequency
{
    static void Main(string[] args)
    {//h e l l o
      // 1   
        string text = "hello";
        var pairs = new Dictionary<char, int>();

        foreach (char c in text)
        {
            if (pairs.ContainsKey(c))
                pairs[c]++;
            else
                pairs[c] = 1;
        }

        foreach (var item in pairs)
            Console.WriteLine($"{item.Key} {item.Value}");
    }
}