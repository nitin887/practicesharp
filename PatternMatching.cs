/*
🧩 9. Pattern Matching
💻 Coding Problem

Create a program:

Accept an object
Use pattern matching (is, switch) to:
Identify type (int, string, double)
Print message accordingly
*/
class PatternMatching
{
    static void Main()
    {
        string text = "my name is lakhan";
        if (text is string)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }

    }
}