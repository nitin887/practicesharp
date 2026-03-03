/*
🔴 ADVANCED
1️⃣3️⃣ Async Exception Handling

Problem:
Throw and handle an exception inside an async method.
*/
class AsyncExceptionHandling
{
    static async Task Main(string[] args)
    {
        try
        {
            Task task = Operation();
            await Task.WhenAll(task);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }





    }
    static async Task Operation()
    {
        await Task.Delay(600);
        int s = 0;
        if (s == 0)
        {
            throw new Exception("number is zero");
        }


    }

}