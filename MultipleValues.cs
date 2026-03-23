/*
BASIC LEVEL
1️⃣ Return Multiple Values Using Tuple

Create a method that returns two values using Tuple.

Requirements:

Method GetStudentInfo()

Return Name and Marks

Access tuple values and print them.

*/
class MultipleValues
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the number of record you want to enter");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < number; i++)
        {

            Console.WriteLine("enter the name");
            string? name = Console.ReadLine();
            Console.WriteLine("enter the marks");
            int marks = Convert.ToInt32(Console.ReadLine());
            var result = GetStudentInfo(name, marks);
            Console.WriteLine("result:" + result);
        }

    }

    static Tuple<string, int> GetStudentInfo(string name, int marks)
    {
        return new Tuple<string, int>(name, marks);
    }
}