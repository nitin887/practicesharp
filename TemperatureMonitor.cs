/*
6️⃣ Custom Event – Temperature Monitor

Create a class TemperatureSensor.

Requirements:

Create event TemperatureExceeded

Trigger event when temperature > 100

Another class should subscribe and display warning
*/
using System.Diagnostics;
class TemperatureMonitor
{
    public delegate void MyDelegate();

    public static event MyDelegate TemperatureExceeded;


    public static void Process()
    {
        Console.WriteLine("enter the temperature");
        int temperature = Convert.ToInt32(Console.ReadLine());
        if (temperature > 100)
        {
            TemperatureExceeded?.Invoke();


        }

    }


    static void Main(string[] args)
    {
        TemperatureExceeded += () => Console.WriteLine("temperature is greater than 100");
        Process();









    }

}