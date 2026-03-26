/*
1️⃣1️⃣ Dictionary with Generics

Create a program that:

Requirements:

Use Dictionary<int, T>
Store student ID and student object
Retrieve student by ID.
*/
using System.Security.AccessControl;

class Student<T> where T : IComparable<T>
{
    private Dictionary<int, T> keyValuePairs = new Dictionary<int, T>();


    private int Id;
    private T Name;

    public void AddValues(int id, T name)
    {
        Id = id;
        Name = name;
        keyValuePairs.Add(Id, Name);
    }
    public void Retrieve(int id)
    {
        Console.WriteLine(keyValuePairs[id]);



    }



}

class DictionaryWithGenerics
{
    static void Main()
    {
        Student<string> student = new Student<string>();

        Console.WriteLine("enter the length of record:");
        int size = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("enter the id:");
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine() ?? "null";
            student.AddValues(id, name);




        }
        try
        {
            student.Retrieve(3);
        }
        catch (Exception e)
        {
            Console.WriteLine("index do not exist" + e.Message);
        }














    }
}