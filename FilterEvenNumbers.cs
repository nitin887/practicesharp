    List<int> numbers=[1,2,3,4,6,7];
    List<int> number=numbers.Where(n=>n%2==0).ToList();
    foreach(int num in number)
{
    Console.WriteLine(num);
}


        