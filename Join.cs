/*
🧩 10. Joining Threads
🎯 Concept: Thread Join

Problem:
Create two threads:

Thread 1 prints numbers
Thread 2 waits for Thread 1 using Join()
*/
class Join
{

    static void Main()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine(1);
            Console.WriteLine(2);
        });
        Thread thread1 = new Thread(() =>
        {
            Console.WriteLine("second thread");
        });
        thread.Start();
        thread1.Start();
        thread1.Join();
        thread.Join();




    }
}