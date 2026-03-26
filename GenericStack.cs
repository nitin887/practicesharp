/*
5️⃣ Generic Stack Implementation

Create a custom generic stack.

Requirements:

Class MyStack<T>
Methods:
Push(T item)
Pop()
Peek()
Store elements in a list internally.
*/
using System.Diagnostics;

class MyStack<T>
{
    private List<T> Value = new List<T>();
    public void Push(T item)
    {
        Value.Add(item);


    }

    public T Peek()
    {
        return Value.Last();

    }
    public void Pop()
    {
        Value.RemoveAt(Value.Count - 1);
        Console.WriteLine("item removed");
    }
    public void GetAll()
    {
        foreach (var result in Value)
        {
            Console.WriteLine(result);
        }



    }
}
class GenericStack
{
    static void Main()
    {
        MyStack<int> myStack = new MyStack<int>();
        myStack.Push(5);
        myStack.Push(7);
        myStack.Push(8);
        Console.WriteLine("elements added successfully");
        Console.WriteLine(myStack.Peek());
        myStack.Pop();
        Console.WriteLine(myStack.Peek());
        myStack.GetAll();




    }
}
