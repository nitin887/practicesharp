/*
🧩 6. Anonymous Types
💻 Coding Problem

Create an anonymous object:

Store Name, Age, City
Print values
⚠️ Bonus:
Create a list of anonymous objects using LINQ
*/
var obj = new
{
    Name = "Nitin",
    Age = 26,
    City = "gurugram"

};
Console.WriteLine($"{obj.Age}-{obj.City}-{obj.Name}");


