/*
5️⃣ Copy File Content

Concept: Read + Write

Problem:
Copy content from source.txt to destination.txt.
*/
class CopyFileCContent
{
    static void Main(string[] args)
    {
        string sourceFilePath="data.txt";
        string destinationFilePath="abc.txt";
        try
        {
            if (File.Exists(sourceFilePath))
            {
                string content =File.ReadAllText(sourceFilePath);
                File.WriteAllText(destinationFilePath,content);
                Console.WriteLine("file copied successfully");
            }
            else
            {
                Console.WriteLine("source file does not exist");
            }

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sourceFilePath != null)
            {
                
                Console.WriteLine("source file path is not null");
            }
            if (destinationFilePath != null)
            {
                Console.WriteLine("destination file path is not null"); 
                }

        }

    }
}