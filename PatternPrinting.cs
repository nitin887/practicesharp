class PatternPrinting
{
    static void Main(string[] args)
    {
        /*
        1
        1 2
        1 2 3
        */

        
        int sequence=5;
        for(int i = 1; i <=sequence ; i++) {
            for(int j = 1;j<=i ; j++) {
                Console.Write("*");
                
            }
            Console.WriteLine();

            
        }
        
    }
}