/*
🔹 INTERMEDIATE LEVEL
4️⃣ Generic Repository Class

Create a class Repository<T>.

Requirements:

Store objects in a List<T>
Methods:
Add(T item)
Remove(T item)
GetAll()
Test repository with:
Student objects
Product objects
*/
class Repository<T>
{
    private List<T> values = new List<T>();

    public void Add(T item)
    {
        values.Add(item);
        Console.WriteLine("data added successfully");

    }
    public void Remove(T item)
    {
        values.Remove(item);
        Console.WriteLine("data deleted successfully");
    }
    public void GetAll()
    {
        foreach (var result in values)
        {
            Console.WriteLine(result);
        }






    }
}
class RepositoryClass
{
    static void Main()
    {
        Repository<int> repository = new Repository<int>();
        repository.Add(5);
        repository.Add(6);
        repository.Add(7);
        repository.GetAll();

    }
}