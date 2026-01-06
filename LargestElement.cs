/*
### 1️⃣ Find the Largest Element in an Array

*Problem:*
Given an integer array, find the maximum element.

*Concept Tested:* Traversal, comparison
*Interview Level:* Beginner
*/

class LargestElement
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 9, 5 };
        int max=arr[0];
       
        for(int i = 1; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max=arr[i];
                
            }
            

        }
        Console.WriteLine($"max value :{max}");
        
        
    }
}