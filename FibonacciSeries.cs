using System.Diagnostics.CodeAnalysis;

class FibonacciSeries
{
    void Iteration()
    {
        int first=0;
        int second=1;
        int nextTerm=0;
        int sequence=4;
        for(int i = 2; i <sequence ; ++i) {
           int  sum = first + second;
            nextTerm  = sum;
            

          
                    
        }
        Console.WriteLine("{0}+{1}+{2}",first,second,nextTerm);

     
        
        
       
        
      
        
        
    }
    static void Main(string[] args)
    {
        FibonacciSeries fibonacciSeries=new();
        fibonacciSeries.Iteration();



       
        
    }
}