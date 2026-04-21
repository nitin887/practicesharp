/*
🧩 1. Introduction to Threads
🎯 Concept: Basic Multithreading

Problem:
Create a program that prints numbers from 1 to 5 using:

Main thread
A separate thread
⚠️ Requirements:
Show both threads running concurrently
Print thread names
*/
class Multithreading
{
    static void Operation()
    {
        Console.WriteLine("Enter the numbers to print in sequence:");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("number:" + i);
            Console.WriteLine(Thread.CurrentThread.Name);

        }

    }
    static void Main()
    {
        Thread thread = new Thread(Operation) { Name = "operation thread" };

        thread.Start();


        Console.WriteLine($"thread:{Thread.CurrentThread.Name = "main thread"} is running");








    }
}