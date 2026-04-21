/*
🧩 4. Main Thread Identification
🎯 Concept: Main Thread

Problem:
Write a program to:

Display details of the main thread
Change its name
*/
class MainThreadIdentification
{
    static void Main()
    {

        Console.WriteLine("Enter the number:");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"{Thread.CurrentThread.Name = "Main thread"} is running");
        }
        Thread thread = Thread.CurrentThread;
        Console.WriteLine(thread.Priority);
        Console.WriteLine(thread.Name);
        Console.WriteLine(thread.IsAlive);
        Console.WriteLine(thread.IsBackground);
        Console.WriteLine(thread.ManagedThreadId);




    }
}