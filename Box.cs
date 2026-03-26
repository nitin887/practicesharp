/*
3️⃣ Generic Class – Box

Create a generic class Box<T>.

Requirements:

Store a value of type T
Method SetValue(T value)
Method GetValue()
Test with:
int
string
*/
class Box<T>
{
    private T Value;

    public void SetValue(T item)
    {
        Value = item;
    }
    public T GetValue()
    {
        return Value;

    }
}
class Program
{
    static void Main()
    {
        Box<int> box = new Box<int>();
        box.SetValue(100);
        Console.WriteLine(box.GetValue());
    }

}