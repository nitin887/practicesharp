/*
8️⃣ Class Constraint

Create a generic class Manager<T>.

Requirements:

Allow only reference types
Store and return object of type T.

*/
class Manager<T> where T : class
{
    private T Value;

    public T GetValue()
    {
        return Value;
    }
    public T SetValue(T Value1)
    {
        Value = Value1;
        return Value;

    }

}
class Manager1
{
    static void Main()
    {
        Manager<string> manager = new Manager<string>();
        Console.WriteLine(manager.SetValue("nitin"));
        Console.Write(manager.GetValue());


    }
}