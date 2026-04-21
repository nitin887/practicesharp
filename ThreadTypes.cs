/*

🧩 2. Types of Threads (Foreground vs Background)
🎯 Concept: Thread Types

Problem:
Create:

One foreground thread
One background thread
⚠️ Requirements:
Background thread prints numbers with delay
Observe behavior when main thread exits
*/
class ThreadType
{

    static void Main()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"{Thread.CurrentThread.Name = "operation thread 1 is a foreground thread"} is running");
            }


        });
        Thread thread1 = new Thread(() =>
        {

            Thread.Sleep(100);


            Console.WriteLine("enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Thread.Sleep(100);

                Console.WriteLine($"{Thread.CurrentThread.Name = "operation thread 2 is a background thread"} is running");
            }


        });
        thread1.IsBackground = true;


        thread.Start();
        thread1.Start();
        thread.Join();
        Console.WriteLine($"{Thread.CurrentThread.Name = "MAIN THREAD"} finished");


    }
}