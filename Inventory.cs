/*
8️⃣ Indexer for Product Inventory

Create a class Inventory.

Requirements:

Store product prices in a list

Create an indexer to access price by index

Allow both read and write operations.
*/
class Inventory
{
    private static List<int> price = new List<int>();
    public void AddProduct(int p)
    {

        price.Add(p);

    }
    public int this[int index]
    {
        get
        {
            return price[index];
        }
        set
        {
            price[index] = value;

        }
    }

    static void Main()
    {
        Inventory inventory = new Inventory();


        inventory.AddProduct(100);
        inventory.AddProduct(200);
        Console.WriteLine(inventory[0]);
        inventory[0] = 300;
        Console.WriteLine(inventory[0]);







    }
}