/*
2️⃣ Array Index Error

Concept: try / catch

Problem:
Create an array of 5 elements.
Try to access the 7th element and handle the exception gracefully.
*/
class ArrayIndexError
{
    static void Main(string[] args)
    {
        int[] array = [1,3,4,5,6,7];
        try
        {
            Console.WriteLine(array[7]);
        } 
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }

        
    }
}