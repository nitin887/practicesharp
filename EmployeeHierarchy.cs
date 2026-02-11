class Employee1
{
    public double Salary
    {
        get;
        set;
    }
    public double Time
    {
        get;
        set;
    }
   
    public  double CalculateSalary()
    {
        return Salary*Time;

        
    }
    
}
class EmployeeHierarchy:Employee1
{
    public EmployeeHierarchy(double salary,double time,double duration)
    {
        Salary=salary;
        Time=time;
        Duration=duration;
        Console.WriteLine("salary:{0},time:{1},duration:{2}",Salary,Time,duration);
                
    }
    public double Duration
    {
        get;
        set;
    }
    public double FullTimeEmplyee()
    {

        return Salary*Time+Duration;
    }
    public double PartTimeEmployee()
    {
        return Salary*Time/2+Duration;
    }
    static void Main(string[] args)
    {
        EmployeeHierarchy employeeHierarchy = new EmployeeHierarchy(234,34,5);
      Console.WriteLine("{0},{1},{2}",employeeHierarchy.CalculateSalary(),employeeHierarchy.FullTimeEmplyee(),employeeHierarchy.PartTimeEmployee());
      


        
    }
}