/*
🧩 6. Thread Class Usage
🎯 Concept: Thread Methods

Problem:
Use Thread class methods:

Start()
Sleep()
IsAlive
⚠️ Requirements:
Show thread execution with delays
*/
class ThreadMethods
{
    static void Main()
    {
        Thread thread = new Thread(() =>
        {
            Thread.Sleep(1000);


        });
        Console.WriteLine(thread.ThreadState);
        thread.Start();
        Thread.Sleep(1000);

        Console.WriteLine(thread.ThreadState);
        thread.Join();

        Console.WriteLine(thread.ThreadState);
        Console.WriteLine(thread.ThreadState);















    }
}