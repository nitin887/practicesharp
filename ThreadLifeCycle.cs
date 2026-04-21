/*
🧩 5. Thread Lifecycle & States
🎯 Concept: Thread States

Problem:
Create a thread and display its state:

Before start
After start
After completion
*/
class ThreadLifeCycle
{
    static void Main()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("thread is running");
            Thread.Sleep(1000);





        });
        Console.WriteLine(thread.ThreadState);
        thread.Start();
        Console.WriteLine(thread.ThreadState);

        Thread.Sleep(100);
        Console.WriteLine(Thread.CurrentThread.ThreadState);
        Console.WriteLine(thread.ThreadState);
        Thread.SpinWait(1000);
        Console.WriteLine(thread.ThreadState);

        Thread.Sleep(1000);
        Console.WriteLine(thread.ThreadState);

        thread.Join();




        Console.WriteLine(thread.ThreadState);









    }
}