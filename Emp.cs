/*
🔟 Func + LINQ + Lambda Combination

Given a list of employees:

Requirements:

Use Func<Employee, bool>

Filter employees with Salary > 50,000

Use LINQ with lambda

Sort by salary descending
*/

class Emp
{
    static void Main(string[] args)
    {
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>
       {
        {"nitin",98000},{"rakesh",97000},{"rahul",621}
       };
        var result = keyValuePairs.Where(s => s.Value > 50000);
        foreach (var data in result)
        {
            Console.WriteLine(data.Key);
        }
        var salary = keyValuePairs.OrderByDescending(s => s.Value);
        foreach (var data1 in salary)
        {
            Console.WriteLine($"{data1.Key}-{data1.Value}");
        }





    }
}