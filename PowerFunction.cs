class PowerFunction
{
    void Power(int number,int power)
    {
        int multiplication;
        multiplication=number*number*number;
        Console.WriteLine("multiplication of {0}^{1}:{2}",number,power,multiplication);
        
    }
    static void Main(string[] args)
    {
        int number=2;
        int  power=3;
        PowerFunction powerFunction =new();
        powerFunction.Power(number,power);

        
        
    }
}