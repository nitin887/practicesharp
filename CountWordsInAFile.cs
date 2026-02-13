using System;
using System.IO;

/*
🟡 INTERMEDIATE LEVEL
4️⃣ Count Words in a File

Concept: File reading + logic

Problem:
Read a text file and count:

Total number of words

Total number of lines*/
class CountWordsInAFile
{
    static void Main(string[] args)
    {
        string filePath="data.txt";
        int lineCount=0;
        int WordCount=0;
        if (File.Exists(filePath))
        {
         string reader=File.ReadAllText(filePath);
         
         Console.WriteLine(reader);
         }
        try
        {
            using(StreamReader streamReader = new StreamReader(filePath))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lineCount++;
                    string[] words=line.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                    WordCount+=words.Length;
                }
            }
                Console.WriteLine($"Total lines: {lineCount}");
                Console.WriteLine($"Total words: {WordCount}");

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    

        
    }
}