class PrimeCheck
{
    bool Prime(int x)
    {
        int a=x%2;
        if (a == 0)
        {
            return true;
        }
        else {  
         return false;}
        
    }
    static void Main(string[] args)
    {
        int x=3;
        PrimeCheck primeCheck =new();
        Console.WriteLine(primeCheck.Prime(x));
        
        
    }
}