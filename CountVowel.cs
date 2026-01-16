class CountVowel
{
    static void Main(string[] args)
    {
        string message ="nitin";
        int vowel=0;
        char[] message1=message.ToArray();
        for(int i = 0; i < message1.Length; i++) {
            if(message1[i]=='a'|| message1[i]=='e'||message1[i]=='i' || message1[i]=='o' || message1[i] == 'u')
            {
                vowel++;
            }
            }
            Console.WriteLine("no of vowels:{0}",vowel);
    

        
    }
}