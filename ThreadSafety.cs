/*
🧩 9. Race Condition Demo
🎯 Concept: Thread Safety

Problem:
Create a bank account where multiple threads withdraw money.

⚠️ Requirements:
Show race condition
Fix using synchronization
*/
using System.Transactions;

class ThreadSafety
{
    static int balance = 10000;
    private static object lockobject = new object();

    public void Operation()
    {
        lock (lockobject)
        {
            Console.WriteLine("Enter the amount to withdraw:");
            int amount = Convert.ToInt32(Console.ReadLine());
            balance -= amount;
        }

    }






    static void Main()
    {
        ThreadSafety threadSafety = new ThreadSafety();
        Thread thread = new Thread(threadSafety.Operation);
        Thread thread1 = new Thread(threadSafety.Operation);
        thread1.Start();
        thread.Start();
        thread.Join();
        thread1.Join();
        Console.WriteLine("balance=" + balance);








    }
}