class ListSort
{
    static void Main(string[] args)
    {
        List<int> sort=[9,6,5,2,7];
        for(int i = 0; i < sort.Count; i++) {
            for(int j = i+1; j <sort.Count ; j++) {
                if (sort[i] < sort[j])
                {
                    (sort[j], sort[i]) = (sort[i], sort[j]);
                }

            }
            

        }
        foreach(int num in sort)
        {
            Console.WriteLine(num+" ");
        }
    }
}