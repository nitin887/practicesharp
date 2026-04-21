/*
🧩 6. Online Shopping Cart
🎯 Concept: Custom Exceptions + Business Logic

Problem:
Create a cart system where users add items.

⚠️ Requirements:
Throw:
OutOfStockException
InvalidQuantityException
Use multiple catch blocks
Display meaningful messages
*/
using System.Transactions;
class OutOfStockException : Exception
{
    public OutOfStockException(string message) : base(message)
    {



    }



}
class InvalidQuantityException : Exception
{
    public InvalidQuantityException(string message) : base(message)
    {



    }

}

class Cart
{
    private int Id;
    private string Items;
    private int Quantity;

    public void AddItems()
    {
        try
        {
            Console.WriteLine("ENTER THE ID ,ITEMS,QUANTITY:");
            Id = Convert.ToInt32(Console.ReadLine());
            Items = Console.ReadLine();
            Quantity = Convert.ToInt32(Console.ReadLine());

            if (Quantity < 0)
            {
                throw new InvalidQuantityException("quantity is in invalid format");
            }
            else if (Quantity == 0)
            {
                throw new OutOfStockException("stock is unavailable");
            }

            Cart cart = new Cart();
            cart.Delivery();

        }
        catch (OutOfStockException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidQuantityException es)
        {
            Console.WriteLine(es.Message);
        }
        catch (FormatException ew)
        {
            Console.WriteLine(ew.Message);
        }
    }
    public void Delivery()
    {
        try
        {
            Console.WriteLine("Enter the product name:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the item name:");
            string items = Console.ReadLine();
            Console.WriteLine("enter the quantity to deliever");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int remaining = Quantity - quantity;
            Id = id;
            Items = items;
            Quantity = remaining;
            if (Quantity == 0)
            {

                throw new OutOfStockException("stock is unavailable");

            }
            Console.WriteLine("Id:{0},item:{1},quantity:{2}", Id, Items, Quantity);
        }
        catch (OutOfStockException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ew)
        {
            Console.WriteLine(ew.Message);
        }
    }

}
class OnlineShoppingCart
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Cart cart = new Cart();
                cart.AddItems();




            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }

    }
}