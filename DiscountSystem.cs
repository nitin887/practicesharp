/*
7️⃣ Anonymous Method – Discount System

Create a delegate for calculating discount.

Requirements:

Use anonymous method (not lambda)

Calculate 10% discount

Apply on product price
*/
class DiscountSystem
{//100  10
    public delegate void Discount();
    static void Main(string[] args)
    {
        Discount discount = delegate ()
        {
            Console.WriteLine("enter the prize:");
            int prize = Convert.ToInt32(Console.ReadLine());
            int discount = 10;
            int calculation = discount % prize;
            int newPrize = prize - calculation;
            Console.WriteLine("" + newPrize);

        };
        discount();




    }
}