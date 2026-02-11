class Person
{
    private string name;
    private string dateOfBirth;
    public string Name
    {
        get
        {
            return name;
        }
    }
    public string DateOfBirth
    {
        get
        {
            return dateOfBirth;
            
        }
    }
    public Person(string name,string dateOfBirth)
    {
        this.name=name;
        this.dateOfBirth=dateOfBirth;
        Console.WriteLine($"name:{Name},date of birth:{DateOfBirth}");
        
    }
    static void Main(string[] args)
    {
        Person person = new("nitin","16-12-4005");
        
        

    }
}