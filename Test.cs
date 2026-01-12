using System.Linq.Expressions;

class Test
{
    static void Main(string[] args)
    {
        /*
        n1 n2
        1   2
        n1=n1+n2=3
        n2=n1-n2=1
        n1=n1-n2=2
        
    */
    int number=153;
    int temp=number;
    int sum=0;
    int remainder;
        while (temp != 0)
        {
            remainder=temp%10;
            sum=sum+remainder*remainder*remainder;
            temp=temp/10;

            
        }
        if(number==sum)
        {
            Console.WriteLine("no is palindrome");
        }
        else
        {
            Console.WriteLine("not an palindrome");
        }

     
         


    }
} 

