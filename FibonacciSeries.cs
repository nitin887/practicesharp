using System.Diagnostics.CodeAnalysis;

class FibonacciSeries
{
    void Iteration()
    {
        int first=0;
        int second=1;
        
        
        int sequence=4;
        for(int i = 0; i <sequence ; ++i) {
            Console.Write(first+" ");
           int  sum = first + second;
             first=second;
             second=sum;
        }
        Console.WriteLine();
     

     
        
        
       
        
      
        
        
    }
    static void Main(string[] args)
    {
        FibonacciSeries fibonacciSeries=new();
        fibonacciSeries.Iteration();



       
        
    }
}