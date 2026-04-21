/*
🧩 10. Stack
💻 Coding Problem

Implement stack operations:

Push 5 elements
Pop 2 elements
Display top element
*/
class Stack1
{
    static void Main()
    {
        Stack<int> elements = new Stack<int>();
        elements.Push(1);
        elements.Push(3);
        elements.Push(4);
        elements.Push(5);

        for (int i = 0; i < 2; i++)
        {
            elements.Pop();
        }
        foreach (var result in elements)
        {
            Console.WriteLine(result);
        }
    }
}