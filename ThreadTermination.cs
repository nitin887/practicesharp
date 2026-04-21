/*
🧩 11. Thread Termination
🎯 Concept: Stopping Threads Safely

Problem:
Create a thread that runs in a loop.

⚠️ Requirements:
Stop it using a flag (not Abort)
Demonstrate graceful termination
*/
class ThreadTermination
{


    public static bool flag = true;

    static void Operation()
    {


        Console.WriteLine("Thread is running");

    }
    static void Main()
    {

        for (int i = 0; i <= 5; i++)
        {
            int temp = i;
            Thread thread = new Thread(Operation);
            thread.Start();
            thread.IsBackground = true;
            flag = false;

            while (flag == true)
            {
                Console.WriteLine("Continued...");
                break;

            }
            Console.WriteLine("stopped..");


        }





    }
}