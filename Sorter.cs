/*
1️⃣4️⃣ Generic Sorting Utility

Create a class Sorter<T>.

Requirements:

Accept list of items
Sort using generic comparison
Return sorted list.
*/
class SorterUtility<T> where T : IComparable<T>
{
    private List<T> items = new List<T>();
    public void AddValue(T item)
    {
        items.Add(item);
    }
    public List<T> Sorting()
    {
        items.Sort();
        return items;

    }




}
class Sorter
{
    static void Main()
    {
        SorterUtility<int> sorterUtility = new SorterUtility<int>();
        sorterUtility.AddValue(7);
        sorterUtility.AddValue(3);
        sorterUtility.AddValue(4);
        sorterUtility.AddValue(5);
        sorterUtility.Sorting();

        List<int> sorted = sorterUtility.Sorting();
        Console.WriteLine("sorted list:");
        foreach (int number in sorted)
        {
            Console.WriteLine(number);
        }


    }


}


