/*
🧩 4. File Reader Program
🎯 Concept: System-Level Exceptions

Problem:
Read a file path from the user and display its content.

⚠️ Requirements:
Handle:
FileNotFoundException
UnauthorizedAccessException
Use finally to close resources
*/
class FileReaderProgram
{

  static void Main()
  {
    StreamReader streamReader = null;
    try
    {
      Console.WriteLine("enter the file path :");
      string filePath = Console.ReadLine();
      //

      streamReader = new StreamReader(filePath);
      string file = streamReader.ReadLine();
      Console.WriteLine(file);



    }
    catch (FileNotFoundException e)
    {
      Console.WriteLine(e.Message);
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
    finally
    {

      streamReader.Close();
      Console.WriteLine("file closed");



    }





  }
}