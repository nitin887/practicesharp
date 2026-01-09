/*
### 5️⃣ Reverse an Array (In-Place)

*Concept Tested:* Two-pointer technique
❗ Very common interview question
*/
class ReverseAnArray
{
    static void Main()
    {
        int[] arr =[1,2,3,4,5];
        int start=0;
        int end=arr.Length-1;
        Console.Write("rev array:");
        while (start < end)
        { int temp =arr[start];
          arr[start]=arr[end];
          arr[end]=temp;
          
          end--;
          start++;
            
        }
        Console.Write("[");
      for(int i = 0; i < arr.Length; i++) {
           
         Console.Write(arr[i]);
             Console.Write(",");  

        }
        Console.Write("]");

        
        
        
            
    }
}