using System.Security.Authentication;

class ArmstrongNumber
{
    static void Main(string[] args)
    {

        /*
        153=1^3+5^3+3^3   remain=5
                            actual number=ac*10+3;=35
                            number=15
        remain=153%10=3
        actualnumber=0+27;
        number=153/10=15;

        
        
        */
        int number=243;
        int remainder;
        int actualNUmber=0;
        int temp=number;
        while (number != 0)
        {
            remainder=number%10;
            actualNUmber+=remainder*remainder*remainder;
            number/=10;


        }
        if (actualNUmber == temp)
        {
            Console.WriteLine("no is armstrong number");
        }
        else
        {
            Console.WriteLine("it is not an armstrong number");
        }
    }
}