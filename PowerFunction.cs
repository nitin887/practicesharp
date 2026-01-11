class PowerFunction
{
    void Power(int number,int power)
    {
        int multiplication=1;
        for(int i = 0; i <power ; i++){

        multiplication*=number;}
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