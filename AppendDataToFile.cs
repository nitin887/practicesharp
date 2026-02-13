/*
3️⃣ Append Data to File

Concept: File writing (append)

Problem:
Append new lines to an existing file without overwriting old content.
*/
class AppendDataToFile
{
    static void Main(string[] args)
    {
        string filepath="data.txt";
        if (File.Exists(filepath))
        {
            File.AppendAllText(filepath,"/nbullshit");
            Console.WriteLine("file appended successfully");
        }
        StreamReader streamReader = null;
        try
        {
            streamReader= new StreamReader(filepath);
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
            }
        }

        
    }
}