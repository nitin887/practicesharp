/*
## 3️⃣ Find Sum of All Elements

*Concept Tested:* Looping, accumulation
*/
class SumAllELement
{
    static void Main()
    {
        Console.WriteLine("enter the size of array");
        int size =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the elements of array");
        int[]  arr =new int[size];
        int sum=0;
        for(int i = 0; i <size; i++) {
            arr[i]=Convert.ToInt32(Console.ReadLine());
            sum+=arr[i];
        }
        Console.WriteLine($"sum is {sum}");

        
    }
}