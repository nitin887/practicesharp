/*
8️⃣ Login System with Exceptions

Concept: Business rule exceptions

Problem:
Create a login system:

Throw exception if:

Username is empty

Password is incorrect
*/
class LoginSystemException
{
    private static readonly string UserName="Nitin";
    private static readonly string Password="123";
    
    public static void Login(string userName,string password)
    {
        if (UserName == userName && Password == password)
        {
            Console.WriteLine("login successful");
        }
       else if (userName == ""||Password!=password)
        {
            throw new InvalidOperationException("username should not be empty or invalid password");
            
        }



        
    }
    static void Main(string[] args)
    {
        try{
        Login("Nitin","124");
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }



    
}