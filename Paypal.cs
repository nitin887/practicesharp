using System;
using System.Collections.Generic;

abstract class Payment
{
    public int amount;
    public abstract string Pay(int amount);
}
class Creditcard : Payment
{
    public override string Pay(int amount)
    {
        return "amount received via creditcard: " + amount;
    }
}
class Upi : Payment
{
    public override string Pay(int amount)
    {
        return "amount received via upi: " + amount;
    }
}
class Program : Payment
{
    public override string Pay(int amount)
    {
        return "amount received via paypal: " + amount;
    }

    static void Main(string[] args)
    {
        List<Payment> payments = new List<Payment>
        {
            new Creditcard(),
            new Upi(),
            new Program()
        };

        foreach (Payment payment in payments)
        {
            Console.WriteLine(payment.Pay(2));
        }
    }
}