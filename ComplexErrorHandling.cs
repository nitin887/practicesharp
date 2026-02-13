/*
9️⃣ Nested try / catch

Concept: Complex error handling

Problem:
Read data from a file and convert content to integer.
Handle:

File not found

Format exception

General exception
*/
using System.Threading.Tasks.Dataflow;

class ComplexErrorHandling
{
    static void Main(string[] args)
    {
        string file="abc.txt";
        StreamReader streamReader = null;
        try
        {
            streamReader= new StreamReader(file);
            string reader=streamReader.ReadToEnd();
            Console.WriteLine(reader);
        }
         catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
       
        catch(Exception ep)
        {
            Console.WriteLine(ep.Message);
        }

        
    }
}