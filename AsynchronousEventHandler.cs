/*
1️⃣4️⃣ Asynchronous Event Handler

Requirements:

Create event FileProcessed

Event handler must be async

Simulate processing delay

Ensure proper await handling
*/
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

class CustomDelegate
{
    public delegate void MyDelegate();
    public static event MyDelegate FileProcessed;
    public static EventHandler eventHandler;
    static async Task Main(string[] args)
    {
        await Task.Delay(9000);
        FileProcessed += () => Console.WriteLine("processing delayed");


        await Processing();








    }
    async static Task Processing()
    {
        await Task.Delay(6000);
        Console.WriteLine("processing item");
        FileProcessed?.Invoke();


    }
}