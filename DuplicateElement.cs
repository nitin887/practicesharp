using System.Globalization;
using System.Security.Cryptography;

class DuplicateElement
{
    static void Main(string[] args)
    {
        int[] arr={1,2,3,4,5,1,2,3};
        int duplicates=0;
        
        for(int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j]){
                    duplicates++;
                    
                }
            }
            
        }
        Console.WriteLine("duplicate value:"+duplicates);

        
    }
}