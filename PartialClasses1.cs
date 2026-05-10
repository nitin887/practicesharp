/*
🧩 4. Partial Classes
💻 Coding Problem

Split a class Student into two files:

File 1 → properties
File 2 → methods
⚠️ Requirements:
Use partial keyword
Combine and use the class
*/
partial class PartialClasses1
{
    public int a = 3;
    public int b = 5;




}
partial class PartialClasses1
{
    public void Methods()
    {
        Console.WriteLine(a + b);
    }
}
public class Program
{
    static void Main()
    {
        PartialClasses1 partialClasses1 = new PartialClasses1();
        partialClasses1.a = 4;
        partialClasses1.b = 7;
        partialClasses1.Methods();


    }
}

