/*
🧩 2. Reflection
💻 Coding Problem

Write a program that:

Takes a class name as input
Displays:
Methods
Properties
Constructors
*/

using System.Reflection;

public class MyAttribute : Attribute
{
    public string Message;
    public MyAttribute(string message)
    {
        Message = message;

    }
}
[My("use new class")]
class Demo
{
    public int Id;
    public void Methods()
    {
        Console.WriteLine(Id);
    }
    public Demo(int id)
    {
        Id = id;

    }
}

class Reflection
{
    static void Main()
    {
        Type type = typeof(Demo);
        Console.WriteLine(type);
        foreach (var data in type.GetMethods())
        {
            Console.WriteLine(data);
        }
        foreach (var data1 in type.GetProperties())
        {
            Console.WriteLine(data1);
        }
        foreach (var data2 in type.GetConstructors())
        {
            Console.WriteLine(data2);
        }



    }

}