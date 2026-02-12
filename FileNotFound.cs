/*
3️⃣ File Not Found

Concept: try / catch

Problem:
Try to open a file that does not exist and catch the exception.
*/
class FileNotFound
{
    static void Main(string[] args)
    {
     
        try
        {
            string text=File.ReadAllText("Abc.txt");
            Console.WriteLine(text);
        }
        catch(FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

    }
    
}