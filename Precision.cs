class Precision
{
    static void Main(String[] args)
    {
        float number=3.6f;
        double number2=3.6d;
        float f=number/2;
        double d=number2/2;
        Console.WriteLine("diff b/w float value{0}  and dividend {1} and double  vlaue {2} and dividend {3} precision is {4}",number,f,number2,d,d-f);
    }
}