/*
### 2️⃣ Find the Smallest Element in an Array

*Concept Tested:* Traversal
*Follow-up:* What if array is very large?

*/
class SmallestElement
{
    static void Main()
    {
        int[] arr=[1,2,3,4,5];
        int min=arr[0];
        for(int i = 1; i <arr.Length ; i++) {
            if (min>arr[i])
            {
                min=arr[i];
            }
            
            
        }

        Console.WriteLine($"min value is {min}");
        
    }
}