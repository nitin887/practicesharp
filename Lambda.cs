/*
8️⃣ Lambda Expression – Student Filter

Given a list of students:

Requirements:

Use lambda expression

Filter students with Marks > 75

Print names
*/
class Lambda
{
    static void Main(string[] args)
    {
        List<int> marks = [20, 34, 55, 78];
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>
        {
            {"rohan",marks[0]},{"rohit",marks[1]},{"rajesh",marks[2]},{"rask",marks[3]}

        };
        foreach (var result1 in keyValuePairs)
        {
            Console.WriteLine($"{result1.Key}-{result1.Value}");
        }
        var result = keyValuePairs.Where(s => s.Value > 75);
        foreach (var data in result)
        {
            Console.WriteLine(data.Key);
        }


    }
}