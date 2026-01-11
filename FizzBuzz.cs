using System.ComponentModel;

class FizzBuzz
{
    static void Main(string[] args)
    {
        int sequence=15;
        for(int i = 1; i <=sequence; i++) {
            
         if (i % 3 == 0 && i % 5 == 0)
        {
         Console.WriteLine("FIZZBUZZ");    
        }
      else  if (i% 3 == 0)
        {
            Console.WriteLine("FIZZ");

        }
        else if (i%5==0)
        {
            Console.WriteLine("BUZZ");
            
        }
    
        }


    }
}