/*
3️⃣ Count Elements

Problem:
Count how many students scored more than 60 marks using LINQ.
*/
class CountElements
{
    static void Main(string[] args)
    {
        int[] marks=[10,39,45,90,60];
        int totalStudent=0;
        var result=marks.Where(n=>n>60).ToArray();
        Console.WriteLine("student scored than 60");
        foreach(var data in result)
        {
            totalStudent++;
            Console.WriteLine(" "+data+$"repeated {totalStudent}");
            
        }
        
    }
    
}