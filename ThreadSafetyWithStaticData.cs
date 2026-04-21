/*
🧩 14. Thread Safety with Static Data
🎯 Concept: Shared Resources

Problem:
Multiple threads modify a static variable.

⚠️ Requirements:
Ensure thread safety using lock
*/
using System.ComponentModel;

class ThreadSafetyWithStaticWithStaticData
{
    static int a = 10;
    static object lockobj = new object();

    static void Main()
    {
        Thread thread = new Thread(() =>
        {
            lock (lockobj)
            {
                Thread.Sleep(1000);
                int b = 1;
                a -= b;
                Console.WriteLine("reduced value:" + a);
            }

        });
        Thread thread1 = new Thread(() =>
        {
            lock (lockobj)
            {
                Thread.Sleep(4000);

                int c = 1;
                a += c;
                Console.WriteLine("exceeded value:" + a);
            }


        });
        thread.Start();
        thread1.Start();



    }
}