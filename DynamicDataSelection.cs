/*
Write a program that dynamically selects data types based on input size.
*/
class DynamicDataSelection
{
    static void Main()
    {
        string input =Console.ReadLine();
        if(int.TryParse(input,out int a))
        {
           Console.WriteLine("int");
        }
        else if(float.TryParse(input,out float b))
        {
            Console.WriteLine("flaot");
            
        }
        else
        {
            Console.WriteLine("string");
        }
     
    }
}