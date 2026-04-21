/*
🧩 11. Queue
💻 Coding Problem

Implement queue:

Enqueue 5 elements
Dequeue 2 elements
*/
class Queue1
{
    static void Main()
    {
        Queue<int> elements = new Queue<int>();
        elements.Enqueue(5);
        elements.Enqueue(4);
        elements.Enqueue(3);
        elements.Enqueue(2);
        elements.Dequeue();
        elements.Dequeue();
        foreach (var data in elements)
        {
            Console.WriteLine(data);
        }


    }
}