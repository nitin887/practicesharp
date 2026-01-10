class Vowel
{
    static void Main(string[] args)
    {
        string message="nitin";
        int Vowel=0;
        char[] message1=message.ToArray();
        for(int i = 0; i <message.Length; i++) 
        {
            if (message1[i]== 'a' || message1[i] == 'e' || message1[i] == 'i' || message1[i] == 'o' || message1[i] == 'u')
            {
                Vowel++;
            }
        }
        Console.WriteLine("no of vowel is {0}",Vowel);
        
    }
}