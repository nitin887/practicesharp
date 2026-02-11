class Employee
{
    private  double basicSalary;
    private double bonus;
    public double BasicSalary
    {
        get
        {
            return basicSalary;
        }
        
    }
    public double Bonus
    {
        get
        {
            return bonus;
        }
        
    }
    public Employee(double basicSalary ,double bonus)
    {
        if (basicSalary < 0 || bonus < 0)
        {
            throw new ArgumentException("salary and bonuses cannot be negative");
        }
        Console.WriteLine("basic salary of employee:"+basicSalary);
        Console.WriteLine("Bonus:"+bonus);
    }
    public double CalculateTotalSalary()
    {
        return basicSalary+bonus;
        
    }
    static void Main(string[] args)
    {
        try
        {
        Employee employee = new Employee(1000,500);
        Console.WriteLine("total salary:"+employee.CalculateTotalSalary());
            
        }
        catch(Exception ex)
        {            
            Console.WriteLine(ex.Message);

        }
      


        
    }
}