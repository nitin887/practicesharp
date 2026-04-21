/*

🧩 13. Parallel Task Execution
🎯 Concept: Multiple Threads

Problem:
Run 3 tasks simultaneously:

Print even numbers
Print odd numbers
Print alphabets
*/
class ParallelTaskExceution
{
    static int numbers;

    private async Task Operation()
    {
        Console.WriteLine("Enter the Numbers to find even: ");
        numbers = Convert.ToInt32(Console.ReadLine());
        if (numbers % 2 == 0)
        {
            Console.WriteLine("even");
        }


    }
    private async Task Operation1()
    {
        Console.WriteLine("Enter the numbers to find the odd: ");
        numbers = Convert.ToInt32(Console.ReadLine());
        if (numbers % 2 != 0)
        {
            Console.WriteLine("odd");
        }


    }
    private async Task Operation2()
    {
        Console.WriteLine("Enter the alphabet:");
        char a = (char)Console.Read();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(a);
        }


    }

    static async Task Main()
    {
        try
        {
            ParallelTaskExceution parallelTaskExceution = new ParallelTaskExceution();
            Task task = parallelTaskExceution.Operation();
            Task t1 = parallelTaskExceution.Operation1();
            Task task1 = parallelTaskExceution.Operation2();
            await Task.WhenAll(task, t1, task1);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }


    }

}