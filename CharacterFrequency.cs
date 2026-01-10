class CharacterFrequency
{
    static void Main(string[] args)
    {
        string message="nitin";
        char[] message1=message.ToArray();
        char m='n';
        int repetition=0;
        for(int i =0; i <message1.Length; i++) {
            if (message1[i]==m)
            {
                repetition++;
                }

                }
Console.WriteLine("element {0} is repeated {1} times",m,repetition);
    
     }
 
}