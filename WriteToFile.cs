/*
2️⃣ Write to File

Concept: Writing files

Problem:
Write a program that:

Takes user input

Writes the input to a file output.txt
*/
class WriteToFile
{
    static void Main(string[] args)
    {
        string filepath="data.txt";
        if (!File.Exists(filepath))
        {
            File.WriteAllText(filepath,"you are done here");
            Console.WriteLine("file created successfully");

            
        }
        StreamReader streamReader =null;
        try
        {
            streamReader =new StreamReader(filepath);
            Console.WriteLine("File opened successfully");
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
            }
        }

        
    }
}