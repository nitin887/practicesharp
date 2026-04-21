/*
🧩 8. Thread Synchronization (Lock)
🎯 Concept: Synchronization

Problem:
Simulate a shared counter accessed by multiple threads.

⚠️ Requirements:
Without lock → show incorrect result
With lock → fix the issue
*/
class Synchronization
{
    static int counter = 0;
    static object lockobj = new object();
    public void Sequence()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (lockobj)
            {
                counter++;
            }
        }



    }

    static void Main()
    {
        Synchronization synchronization = new Synchronization();
        Thread thread = new Thread(new ThreadStart(synchronization.Sequence));
        Thread thread1 = new Thread(new ThreadStart(synchronization.Sequence));

        thread.Start();
        thread1.Start();
        thread.Join();
        thread1.Join();
        Console.WriteLine(counter);



    }
}