/*
🔥 Challenge (Optional)
🔟 First Non-Repeating Element

Question:
Find the first non-repeating number in an array.

Example:
Input: {4, 5, 1, 2, 1, 4}
Output: 5
        */
class GroupElements
{
    static void Main(string[] args)
    {
        int[] array={1,2,3,3,2};
        Dictionary<int,int> ? pairs= [];
        foreach(int num in array)
        {
            if(pairs.ContainsKey(num)){
                pairs[num]++;

            }
            else{
                pairs[num]=1;
            }

        }
        foreach(int num in array)
        {
            if(pairs[num]==1)
            {
                Console.WriteLine(num);
                break;
            }

        }

    
    }

        
        
    }
