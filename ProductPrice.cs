/*
Here are multiple C# coding problems on Exception Handling, arranged from basic to advanced, covering all the concepts you mentioned 👇









🧩 12. Product Price Calculator
🎯 Concept: Try-Catch-Finally + Business Rules

Problem:
Calculate total price with discount.

⚠️ Requirements:
Throw exception if price < 0
Use finally to print "Calculation complete"
*/
Console.WriteLine("enter the price of a product");
double price = Convert.ToDouble(Console.ReadLine());
try
{
    Console.WriteLine("discount price:");
    double discount = 0.06;
    Console.WriteLine(discount + "%");
    Console.WriteLine("final price:");
    double newprice = price + price * discount;
    Console.WriteLine(newprice);





}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("calculation completed");
}