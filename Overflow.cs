/*
Create a program that detects overflow in integer addition.*/
class BasicDataTypes{
static void Main(){
int number=int.MaxValue;
int number1=1;

try
{checked{
   int  c=number+number1;
   Console.WriteLine(c);
   
   }
    
}
catch(Exception e)
{
    Console.WriteLine("exception caught with :"+e.Message);
}

        unchecked
        {
            int c1=number+number1;
            Console.WriteLine(c1);
        }
}
}
