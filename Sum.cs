class Sum
{    int Add(int a,int b)
    {
        return a+b;
    }
    static void Main()
    {
        int a=6;
        int b=9;
      Sum s= new();
      s.Add(a,b);
        Console.WriteLine("Sum of {0} and {1} is {2}",a,b,s.Add(a,b));
   

        
    }
}