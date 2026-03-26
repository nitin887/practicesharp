/*
🔥 ADVANCED LEVEL (INTERVIEW)
1️⃣2️⃣ Generic Cache System

Create a class Cache<TKey, TValue>.

Requirements:

Internally use dictionary
Methods:
Add(TKey key, TValue value)
Get(TKey key)
Remove(TKey key)
*/
class Cache<TKey, TValue>
{
    private Dictionary<TKey, TValue> keyValuePairs = new();

    public void AddValue(TKey key, TValue value)
    {
        keyValuePairs.Add(key, value);
        Console.WriteLine("cache added");

    }
    public TValue Get(TKey key)
    {
        return keyValuePairs[key];
    }
    public void RemoveValue(TKey key)
    {
        Console.WriteLine("item removed:" + keyValuePairs.Remove(key));

    }
}
class GenericCacheSystem
{
    static void Main()
    {
        Cache<int, string> cache = new Cache<int, string>();
        Console.WriteLine("Enter the Length of Record:");
        int size = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("enter the value of key and pair");
            int key = Convert.ToInt32(Console.ReadLine());
            string value = Console.ReadLine();
            cache.AddValue(key, value);
        }
        cache.Get(2);
        Console.WriteLine("enter the key remove:");
        int id = Convert.ToInt32(Console.ReadLine());
        cache.RemoveValue(id);




    }
}