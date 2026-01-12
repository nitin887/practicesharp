class NumberOfDigits
{
    static void Main(string[] args)
    {
        /*
        153
        remainder=153%10=3;
        count++;
        actual number=0+3;
        number=153/10=15

        */
        int number=1234;
        int count=0;
        int actualNUmber=0;

        while (number != 0)
        {
          int temp=number%10;
         actualNUmber=actualNUmber+temp*10;
         number/=10;
           count++;
        }
        Console.WriteLine("no of digits:{0}",count);
        
    }
}