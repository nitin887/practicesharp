/*
🧩 7. Extension Methods
💻 Coding Problem

Create an extension method:

Extend string
Add method WordCount() to count words
*/
public static class StringExtensions
{
    public static int WordCount(this string str)
    {
        return str.Split([',', ' ']).Length;
    }
}
public class Program
{
    static void Main()
    {
        string text = "hello world c#";
        int count = text.WordCount();
        Console.WriteLine(count);
    }
}