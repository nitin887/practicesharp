/*
6️⃣ Error Handling with Files

Concept: File handling + exceptions

Problem:
Read a file and handle:

File not found

Access denied

*/
class ErrorHandlingWithFiles
{
    static void Main(string[] args)
    {
        string filePath="data.txt";
        try
        {
            if (File.Exists(filePath))
            {
                string reader=File.ReadAllText(filePath);
                Console.WriteLine(reader);
            }
            else
            {
                Console.WriteLine("file not found");
            }
        }
        catch(UnauthorizedAccessException e)
        {
            Console.WriteLine("access denied: "+e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine("an error occurred: "+e.Message);
        }

        
    }
}