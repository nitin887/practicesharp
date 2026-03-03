/*
🔟 Async File Read

Problem:
Read a text file asynchronously and display content.
*/
class AsyncFileRead
{
    static async Task Main(string[] args)
    {
        string filepath = "abc.txt";

        using (StreamReader streamReader = new StreamReader(filepath))
        {
            await Task.Delay(9000);

            string content = await streamReader.ReadToEndAsync();
            Console.WriteLine(content);
        }


    }
}