/*
🧩 3. Creating Threads
🎯 Concept: Thread Creation Methods

Problem:
Create threads using:

Thread class
Lambda expression
⚠️ Requirements:
Each thread prints a message 5 times
*/
class ThreadCreationMethod
{
    static void Main()
    {
        Thread thread = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name = "current thread 1 "} is running");


            }


        });
        Thread thread1 = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name = "current thread 2"} is running");
            }


        });
        thread.Start();
        thread1.Start();
        thread.Join();
        thread1.Join();
    }
}