/*
🧩 10. Combined Real-World Problem (Best One)
💻 Coding Problem

Employee Analyzer System

⚙️ Requirements:
Use:
Attribute → Mark employee role
Reflection → Read attribute at runtime
Nullable types → Optional bonus field
Extension method → Format employee name
Pattern matching → Process different employee types

*/
using System;
using System.Reflection;


// ---------------- EXTENSION METHOD ----------------
public static class ExtensionMethods
{
    public static string FormatEmployeeName(this string name)
    {
        return name.Trim().ToUpper();
    }
}


// ---------------- ATTRIBUTE ----------------
[AttributeUsage(AttributeTargets.Class)]
class RoleAttribute : Attribute
{
    public string RoleName { get; }

    public RoleAttribute(string role)
    {
        RoleName = role;
    }
}


// ---------------- BASE EMPLOYEE ----------------
abstract class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    // Nullable type (optional bonus)
    public double? Bonus { get; set; }

    protected Employee(int id, string name, double? bonus)
    {
        Id = id;
        Name = name;
        Bonus = bonus;
    }
}



// ---------------- EMPLOYEE TYPES ----------------
[Role("Full Time")]
class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id, string name, double? bonus)
        : base(id, name, bonus)
    {
    }
}

[Role("Part Time")]
class PartTimeEmployee : Employee
{
    public PartTimeEmployee(int id, string name, double? bonus)
        : base(id, name, bonus)
    {
    }
}

[Role("Intern")]
class Intern : Employee
{
    public Intern(int id, string name, double? bonus)
        : base(id, name, bonus)
    {
    }
}



// ---------------- MAIN SYSTEM ----------------
class EmployeeAnalyzerSystem
{
    static void Main()
    {
        Employee[] employees =
        {
            new FullTimeEmployee(1,"john doe",5000),
            new PartTimeEmployee(2,"mary smith",null),
            new Intern(3,"alex ray",1000)
        };

        foreach (var emp in employees)
        {
            AnalyzeEmployee(emp);
            Console.WriteLine("----------------");
        }
    }

    static void AnalyzeEmployee(Employee emp)
    {
        // Extension method
        string formattedName = emp.Name.FormatEmployeeName();
 
        Console.WriteLine($"ID: {emp.Id}");
        Console.WriteLine($"Name: {formattedName}");

        // Nullable type
        Console.WriteLine(
            $"Bonus: {(emp.Bonus.HasValue ? emp.Bonus.Value.ToString() : "No Bonus")}"
        );

        // Reflection + Attribute
        Type t = emp.GetType();

        var roleAttr = t.GetCustomAttribute<RoleAttribute>();

        if (roleAttr != null)
        {
            Console.WriteLine($"Role: {roleAttr.RoleName}");
        }

        // Pattern Matching
        switch (emp)
        {
            case FullTimeEmployee:
                Console.WriteLine("Processing Full-Time benefits...");
                break;

            case PartTimeEmployee:
                Console.WriteLine("Processing Hourly wages...");
                break;

            case Intern:
                Console.WriteLine("Processing Internship stipend...");
                break;

            default:
                Console.WriteLine("Unknown employee type");
                break;
        }
    }
}