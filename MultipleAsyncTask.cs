/*
🟡 INTERMEDIATE
1️⃣1️⃣ Multiple Async Tasks

Problem:
Run two async methods in parallel and wait for both to complete.
*/
class MultipleAsyncTask
{
    static async Task Main(string[] args)
    {
        try
        {
            Task t1 = Personal();
            Task t2 = Personal1();
            await Task.WhenAll(t1, t2);


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }



    }
    static async Task Personal()
    {
        await Task.Delay(8000);
        Console.WriteLine("PERSONAL DONE");

    }
    static async Task Personal1()
    {
        await Task.Delay(4000);
        Console.WriteLine("personal1 done");

    }
}