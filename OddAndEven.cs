/*
### 4️⃣ Count Even and Odd Numbers

*Concept Tested:* Modulus operation

*/

class OddAndEven
{
    static void Main()
    {
        int[] arr=[1,2,3,4,5];
        int even=0;
        int odd=0;
        for(int i = 0; i < arr.Length; i++) {
            if (arr[i]%2==0)
            {
                even++;
                
            }
            else
            {
                odd++;
            }
        }
        Console.WriteLine($"even number {even} and odd number {odd}");
        

    }
}