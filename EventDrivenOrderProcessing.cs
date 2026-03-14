/*
🔹 ADVANCED LEVEL
9️⃣ Event-Driven Order Processing System

Create an Order class.

Requirements:

Event OrderPlaced

Event OrderShipped

Trigger events in correct sequence

Subscribe handlers that log messages
*/
class EventDrivenOrderProcessing
{


    static void Main(string[] args)
    {
        Order order = new Order();
        order.OrderPlaced += () => Console.WriteLine("order palced");
        order.OrderShipped += () => Console.WriteLine("order shipped");

        order.Operation();

    }
}
class Order
{
    public delegate void MyDelegate();
    public event MyDelegate OrderPlaced;
    public event MyDelegate OrderShipped;
    public void Operation()
    {
        Console.WriteLine("!processing order");
        OrderPlaced?.Invoke();
        OrderShipped?.Invoke();








    }
}