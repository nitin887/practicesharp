/*
6️⃣ try / catch / finally

Concept: Resource cleanup

Problem:
Open a file, read data, and ensure:

File is always closed using finally
*/
using System;
using System.IO;
class ResourceCleanup
{
    static void Main(string[] args)
    {
        string filepath="abc.txt";
            // Create the file with sample content if it doesn't exist
            if (!File.Exists(filepath))
            {
                File.WriteAllText(filepath, "Sample file content\nThis file was created by the program.");
                Console.WriteLine("file created successfully");
            }
        StreamReader streamReader =null;
        try
        {
            streamReader=new StreamReader(filepath);
            Console.WriteLine("file opened successfully");
        
          string reader=streamReader.ReadToEnd();
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
                Console.WriteLine("file closed successfully");
            }
            
          
        }
    }
}