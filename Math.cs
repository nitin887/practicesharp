public static class SimpleMathProgram
{
    static void Main()
    {
        Console.WriteLine("Basic Math: add, subtract, multiply two integers.");

        int a = ReadInt("Enter first integer: ");
        int b = ReadInt("Enter second integer: ");

        Console.WriteLine("Sum: " + (a + b));
        Console.WriteLine("Difference (a - b): " + (a - b));
        Console.WriteLine("Product: " + (a * b));
    }

    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            var s = Console.ReadLine();
            try
            {
                return int.Parse(s);
            }
            catch
            {
                Console.WriteLine("Invalid integer, please try again.");
            }
        }
    }
}
