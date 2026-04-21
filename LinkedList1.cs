/*
🧩 12. LinkedList<T>
💻 Coding Problem

Create a LinkedList<int>:

Add elements at beginning and end
Remove a specific node
*/
class LinkedList1
{
    static void Main()
    {
        LinkedList<int> data = new LinkedList<int>();

        data.AddFirst(200);
        data.AddLast(300);
        data.AddAfter(data.AddFirst(100), 150);

        foreach (var data1 in data)
        {
            Console.WriteLine(data1);
        }


    }
}