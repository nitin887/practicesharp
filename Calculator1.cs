/*
🧩 5. Nested Try-Catch Calculator
🎯 Concept: Nested Try-Catch

Problem:
Create a calculator for +, −, ×, ÷.

⚠️ Requirements:
Outer try: menu & input
Inner try: division operation
Handle division-by-zero inside nested block
*/
class calculator1
{
    public static int a;
    public static int b;
    static void Info()
    {
        Console.WriteLine("Enter the two  Number:");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());



    }
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter your choice:\n1.add\n2.subtract\n3.multiply\n4.division");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Info();
                    int c = a + b;
                    Console.WriteLine("sum:" + c);
                    break;
                case 2:
                    Info();
                    int d = a - b;
                    Console.WriteLine("subtraction:" + d);
                    break;
                case 3:
                    Info();
                    int e = a * b;
                    Console.WriteLine("multiplication:" + e);
                    break;

                case 4:
                    try
                    {
                        Info();
                        int f = a / b;
                        Console.WriteLine("Divison:" + f);
                    }
                    catch (DivideByZeroException ep)
                    {
                        Console.WriteLine(ep.Message);
                    }
                    break;
                case 5:
                    Console.WriteLine("choose valid number");
                    break;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Operation Completed");
        }

    }
}