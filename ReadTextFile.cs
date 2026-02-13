/*
1️⃣ Read Text File

Concept: Reading files

Problem:
Create a text file data.txt with some text.
Write a C# program to:

Read the file

Print its content to the console
*/
class ReadTextFile
{
    static void Main(string[] args)
    {
        string filePath="data.txt";
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath,"welcome to my jungle");
            Console.WriteLine("file created successfully");
        }
        StreamReader streamReader = null;
        try
        {
            streamReader=new StreamReader(filePath);
            Console.WriteLine("file opened successfully");
            string  reader=streamReader.ReadToEnd();
            Console.WriteLine(reader);
            
            
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);

        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Close();
            }
        }

    }
}