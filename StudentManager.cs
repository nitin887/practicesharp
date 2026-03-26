/*
🔹 GENERICS WITH COLLECTIONS
🔟 Generic Collection – Student Manager

Create a class StudentManager<T>.

Requirements:

Store students in List<T>
Methods:
Add student
Remove student
Display students.
*/
using System.ComponentModel;

class Student<T>
{
    private static List<T> studentNames = new List<T>();

    public void AddStudent(T addvalue)
    {
        studentNames.Add(addvalue);
        Console.WriteLine("student record added");
    }
    public void RemoveStudent(T removeValue)
    {
        studentNames.Add(removeValue);
        Console.WriteLine("remove value from the list");
    }
    public void Display()
    {
        foreach (var result in studentNames)
        {
            Console.WriteLine(result);
        }

    }

}
class StudentManager
{
    static void Main()
    {
        Student<string> student = new Student<string>();
        Console.WriteLine("enter the number of records:");
        int size = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("enter the name:");
            string name = Console.ReadLine();
            student.AddStudent(name);
        }
        student.Display();





    }
}