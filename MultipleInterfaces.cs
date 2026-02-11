using System.Reflection.Metadata;
interface ILogin
{
    void Login(string Username,string Password);
}
interface ILogout
{
    void Logout();
    
}
class UserSession:ILogin,ILogout
{
    
    public bool isLogin=false;
    public void Login(string username,string password)
    {
        if (username == "admin" && password == "admin123")
        {
            isLogin=true;
            Console.WriteLine("valid credentails");

        }
        else
        {
            Console.WriteLine("invalid credentials");
        }
    }
    public void Logout()
    {
        if (isLogin)
        {
            isLogin=false;
            Console.WriteLine("logged out successfully");
        }
        else
        {
            Console.WriteLine("no active session");
        }
    }
    
    
}
class MultipleInterfaces
{
    static void Main(string[] args)
    {
    UserSession userSession = new();
    userSession.Login("admin","admin123");
    userSession.Logout();

    }
}