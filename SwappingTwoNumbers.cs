class SwappingTwoNumbers
{
    void Swap(int n1,int n2)
    {
        int temp;
            temp= n1;
            n1 = n2;     
            n2 =temp;
            Console.WriteLine("n1:{0},n2:{1}",n1,n2);

        
    }

    static void Main(string[] args)
    {
        int n1=2;
        int n2=3;
        SwappingTwoNumbers swappingTwoNumbers =new();
        swappingTwoNumbers.Swap(n1,n2);
        
    }
}