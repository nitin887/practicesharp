class User
{ 
    private string userName;
    private string password;

    public User(string userName,string password)
    {
        if (!IsValidPassword(password))
        {
            throw new ArgumentException("password must be of 6 length with number");
        }
        this.userName=userName;
        this.password=password; 
        Console.WriteLine("username and password are set");
    }
    public void  Login(string userName,string password)
    {
        if (userName == userName && password==password)
        {
            Console.WriteLine("credential are correct");
            Console.WriteLine("---task performed----");
            
        }
        else
        {
            Console.WriteLine("invalid userName or password");
        }
        
    }
    private void IsValidPassword(string pwd)
    {
        if (pwd.Length < 6)
        {
            Console.WriteLine("invalid length of password");
        }
        bool hasNumber= false;
        
            foreach(char c in pwd)
            {
            if (char.IsDigit(c))
            {
                hasNumber=true;
                break;
                
            }
            Console.WriteLine(hasNumber);
            }
        
        
    }
    static void Main(string[] args)
    {
        try{
        User user= new User("nitin@123","9213323058");
        user.Login("nitin@123","9213323058");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        
    }
}