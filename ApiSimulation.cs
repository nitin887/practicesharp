/*
1️⃣2️⃣ API Simulation

Problem:
Simulate fetching data from an API using Task.Delay().
*/
using System.Diagnostics;
using Microsoft.VisualBasic;

class ApiSimulation
{
    static async Task Main(string[] args)
    {
        await Task.Delay(3000);
        Task t1 = Api();
        await Task.WhenAll(t1);
        Console.WriteLine("calling api method");




    }
    static async Task Api()
    {
        await Task.Delay(4000);
        Console.WriteLine("api fetching data");
    }
}