/*
9️⃣ Async Method

Problem:
Create an async method that:

Waits 3 seconds

Prints “Task Completed”
*/
using System.Runtime.CompilerServices;

class AsyncMethod
{
  static async Task Main(string[] args)
    {
           AsyncMethod asyncMethod= new AsyncMethod();
        Task t1=asyncMethod.DoSomeWork();
        Task t2= DoAnotherTask();
        Console.WriteLine("Task Completed");
 
        await Task.WhenAll(t2);
        
   
        
    } 
 private async Task DoSomeWork()
  {
    await Task.Delay(500);
    Console.WriteLine("task1 completed");
    
  }
  private static async Task DoAnotherTask()
  {
    await Task.Delay(1344);
    Console.WriteLine("task2 has been completed");
  }
    
}