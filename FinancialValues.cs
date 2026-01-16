/*
9. Use decimal to calculate financial interest accurately.
*/
class FinancialValues
{
    static void Main(String[] args)
    {
        decimal amount=decimal.Parse(Console.ReadLine());
        decimal interest=decimal.Parse(Console.ReadLine());
        decimal timePeriod=decimal.Parse(Console.ReadLine());
        decimal interestAmount=amount*interest*timePeriod/100;
        decimal financialAmount=amount+interestAmount;
        Console.WriteLine($"financial amount :{financialAmount}");



        
    }
}