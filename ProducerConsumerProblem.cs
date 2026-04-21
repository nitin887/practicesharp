/*
🧩 12. Producer-Consumer Problem (Advanced)
🎯 Concept: Synchronization + Thread Communication

Problem:
Implement a simple producer-consumer system.

⚠️ Requirements:
One thread produces data
Another consumes data
Use lock or Monitor
*/
using System.Reflection.Metadata;

class ProducerConsumerProblem
{
    static bool isTrue = true;
    static int x = 2;
    static object lockobj = new object();
    public static void Shared()
    {

        lock (lockobj)
        {
            while (isTrue == true)
            {



                Thread.Sleep(2000);
                if (x == 0)
                {
                    x += 1;
                }
                else if (x > 0)
                {
                    break;
                }
                Console.WriteLine("producer is running:" + isTrue);
                isTrue = false;
            }
            Thread.Sleep(3000);
            if (x > 0)
            {
                x -= 1;
            }
            Console.WriteLine("consumer is running");
            isTrue = true;
        }





    }
    static void Main()
    {

        Thread producer = new Thread(Shared);
        Thread consumer = new Thread(Shared);
        producer.Start();
        consumer.Start();
        producer.Join();
        consumer.Join();







    }
}