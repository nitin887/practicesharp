/*

🧩 11. Temperature Converter
🎯 Concept: Exception + Validation

Problem:
Convert Celsius to Fahrenheit.

⚠️ Requirements:
Handle invalid input
Throw exception if temperature < absolute zero (-273.15°C)
*/
class TemperatureConverter
{
    static void Main()
    {
        try
        {
            Console.WriteLine("enter the temperature in celsius");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = c * (9 / 5) + 32;
            Console.WriteLine("f:" + f);
            if (f < -273.15)
            {
                throw new Exception("tempertaure limited exceeded");
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception es)
        {
            Console.WriteLine(es.Message);
        }

    }
}