/*
Implement a calculator that supports int, float, and double.
*/
using System.Runtime.InteropServices;

class Calculator
{
  static  int Sum(int a,int b)
    {
        int sum=a+b;
        return sum;
    }
  static  float Sum(float c,float d)
    {
        float sum=c+d;
        return sum;
    }
   static double Sum(double e ,double f)
    {
        double sum=e+f;
        return sum;
    }
    static void Main(string[] args)
    {
        string input =Console.ReadLine();
        string input1=Console.ReadLine();
        if (int.TryParse(input, out int a) && int.TryParse( input1, out int b)==true )
        {
         
          Console.WriteLine( (int)Sum(a, b));
        }
        if (float.TryParse(input,out float c) && float.TryParse(input1,out float d)==true)
        {
          
            
        Console.WriteLine((float)Sum(c,d));
        }
        if(double.TryParse(input,out double e) && double.TryParse(input1,out double f)==true )
        {
            
            
        Console.WriteLine((double)Sum( e , f));
        }
        else
        {
            Console.WriteLine("Invalid operations");
        }
    

        

    }
    
}