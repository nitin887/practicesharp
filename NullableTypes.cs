/*
🧩 3. Nullable Types
💻 Coding Problem

Create a program:

Declare nullable integers (int?)
Assign null and non-null values
Use HasValue and Value
*/
class NullableTypes
{
    static void Main()
    {
        int? number = null;

        if (number.HasValue)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine(number);

        }
    }
}