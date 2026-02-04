using System;
using System.Collections.Generic;

class CharacFrequency
{
    static void Main(string[] args)
    {
        // use command-line input if provided, otherwise default to "hello"
        string text = args.Length > 0 ? string.Join(" ", args) : "hello";

        var pairs = new Dictionary<char, int>();
        foreach (char c in text)
        {
            if (char.IsWhiteSpace(c))
                continue;

            // case-insensitive count
            char key = char.ToLowerInvariant(c);

            if (pairs.ContainsKey(key))
                pairs[key]++;
            else
                pairs[key] = 1;
        }

        foreach (var item in pairs)
            Console.WriteLine($"{item.Key} {item.Value}");
    }
}