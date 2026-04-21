/*

🧩 10. Login System
🎯 Concept: Multiple Catch + Custom Exception

Problem:
Simulate login with username and password.

⚠️ Requirements:
Throw InvalidCredentialsException for wrong login
Limit attempts to 3
Handle exceptions properly
*/
class InvalidCredentialsException : Exception
{
    public InvalidCredentialsException(string message) : base(message)
    {

    }

}
class LoginSystem
{
    private static string username;

    public string Username
    {
        get
        {
            return username;
        }
        set
        {
            username = value;
        }
    }
    private static int password;
    public int Password
    {
        get
        {
            return password;

        }
        set
        {
            password = value;
        }

    }
    void Credentials()
    {
        try
        {


            Console.WriteLine("enter the username and password :");
            string username = Console.ReadLine();
            int password = Convert.ToInt32(Console.ReadLine());

            Password = password;
            Username = username;



        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }




    }
    void Login()
    {
        try
        {

            Console.WriteLine("enter the username and password for attempt:");
            string username = Console.ReadLine();
            int password = Convert.ToInt32(Console.ReadLine());
            int numberOfAttempt = 1;
            int sequence = 4;
            for (int i = 0; i < sequence; i++)
            {
                if (numberOfAttempt <= 3)
                {


                    if (Username == username && Password == password)
                    {
                        Console.WriteLine("valid access provided");
                    }


                }
                else if (numberOfAttempt > 3)
                {
                    throw new InvalidCredentialsException("write correct credentials");
                }

            }




        }
        catch (InvalidCredentialsException es)
        {
            Console.WriteLine(es.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }

    }
    static void Main()
    {
        LoginSystem loginSystem = new LoginSystem();
        loginSystem.Credentials();
        loginSystem.Login();


    }
}