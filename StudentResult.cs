/*
3️⃣ ValueTuple – Student Result

Create a method returning (string Name, int Marks) using ValueTuple.

Requirements:

Return student name and marks

Access values using named fields

Display result.
*/
class StudentResult
{


    static void Main(string[] args)
    {
        Console.WriteLine("enter the student name and marks:");
        string name = Console.ReadLine();
        int marks = Convert.ToInt32(Console.ReadLine());
        var result = Result(name, marks);
        Console.WriteLine(result);
        Console.WriteLine(result.marks);
        Console.WriteLine(result.name);




    }
    static (string name, int marks) Result(string name, int marks)
    {
        return new(name, marks);


    }

}