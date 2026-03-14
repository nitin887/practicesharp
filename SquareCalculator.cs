/*
4️⃣ Func Delegate – Square Calculator

Create a function using Func<int, int>.

Requirements:

Accept a number

Return its square

Print result
*/
class SquareCalculator
{
    static int operation(int a)
    {
        // return square of the input
        return a * a;
    }

    static void Main(string[] args)
    {
        Func<int, int> factory = operation;
        Console.WriteLine("Enter a number:");
        int a = Convert.ToInt32(Console.ReadLine());
        int result = factory(a);
        Console.WriteLine(result);



    }
}