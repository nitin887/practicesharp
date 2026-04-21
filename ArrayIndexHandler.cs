/*

🧩 9. Array Index Handler
🎯 Concept: System Exception Handling

Problem:
Access elements of an array based on user input index.

⚠️ Requirements:
Handle:
IndexOutOfRangeException
FormatException
*/
using System.ComponentModel.Design.Serialization;
using System.Data;

class ArrayIndexHandler
{

    static void Main()
    {
        try
        {
            Console.WriteLine("enter the length of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("Enter the elements of array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }



            Console.WriteLine("enter the  index value");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == a)
                {
                    Console.WriteLine($"{numbers[i]} is at index {a}");
                }
                else
                {
                    throw new IndexOutOfRangeException();

                }

            }
        }
        catch (FormatException es)
        {
            Console.WriteLine(es.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }





    }
}