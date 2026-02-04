class Array
{
    static void Main(string[] args)
    {
        int[] numbers=[1,2,3,3,2,4];
       HashSet<int> unique=[];
       foreach(int numb in numbers)
        {
            unique.Add(numb);
        }
        foreach(int numb in unique)
        {
            Console.Write(numb+" ");
        }
      
            

        }
     
}