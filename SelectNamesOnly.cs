/*
2️⃣ Select Names Only

Problem:
Given a list of Student { Id, Name, Marks }, use LINQ to return only names.
*/
using System.Reflection.Metadata.Ecma335;

class Student
{
    public int Id;
    public string Name;
    public int Marks;
    public Student(int id,string name,int marks)
    {
        Id=id;
        Name=name;
        Marks=marks;
    }
}
class SelectNamesOnly()
{

   static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student(1,"Alice",85),
            new Student(2,"Bob",90),
            new Student(3,"Charlie",78)
        };

        var names = students.Select(s => s.Name).ToList();

        Console.WriteLine("Names of Students:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
       

        
    }
    
    
}