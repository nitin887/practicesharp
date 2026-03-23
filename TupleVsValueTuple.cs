/*
4️⃣ Compare Tuple vs ValueTuple

Create a program that:

Requirements:

Creates one Tuple

Creates one ValueTuple

Prints both values

Compare readability of access.

*/
class TupleVsValueTuple
{
    static void Main(string[] args)
    {
        Tuple<string, int> oldTuple = new Tuple<string, int>("nuksh", 34);
        (string name, int marks) valueTuple = ("nitin", 45);
        Console.WriteLine(oldTuple);
        Console.WriteLine($"{valueTuple.name}-{valueTuple.marks}");


    }
}