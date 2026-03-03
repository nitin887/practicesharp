/*
6️⃣ Find Max & Average

Problem:
Using LINQ, find:

Highest marks

Average marks
*/
class FindMaxAndAverage
{
    static void Main(string[] args)
    {
        List<int> marks=[10,38,67];
        var highestMarks=marks.Max();
        double avg=0;
        Console.WriteLine(highestMarks);
        for(int i = 0; i < marks.Count; i++)
        {
            avg=marks.Average();
            
            
        }
        Console.WriteLine(avg);
    }
}



