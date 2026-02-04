class MergeTwoList
{
    static void Main(string[] args)
    {
        List<int> list=[1,2,3,4,5];
        List<int> list1=[4,5];
        List<int> common=[];
        foreach(int num in list)
        {
            if (list1.Contains(num))
            {
                common.Add(num);
            }

        }
       foreach(int num in common)
        {
            Console.WriteLine(num+ " ");
        }
    }
}