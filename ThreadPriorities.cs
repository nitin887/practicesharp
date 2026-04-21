/*
🧩 7. Thread Priority
🎯 Concept: Priority Scheduling

Problem:
Create two threads:

One with Highest priority
One with Lowest priority
⚠️ Requirements:
Compare execution behavior
*/
class ThreadPriorities
{
    static void Main()
    {
        Thread t1 = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("t1 is running");

            }
        });
        t1.Priority = ThreadPriority.Highest;
        Thread t2 = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("t2 is ruuning");

            }
        });
        t2.Priority = ThreadPriority.Lowest;
        t1.Start();
        t2.Start();



    }
}