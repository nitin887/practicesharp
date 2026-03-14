/*
3️⃣ Action Delegate – Logger

Create a logging system.

Requirements:

Use Action<string>

Print messages to console

Pass different messages dynamically
*/
class Action
{
    static void Main(string[] args)
    {
        string mesaage = "myname is lakhan";
        Action<string> action = Logging;
        action(mesaage);


    }
    static void Logging(string message)
    {
        Console.WriteLine("you have been logged in");

    }

}