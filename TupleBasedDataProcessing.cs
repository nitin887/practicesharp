/*
🔥 ADVANCED INTERVIEW LEVEL
1️⃣1️⃣ Tuple-Based Data Processing

Create a method that returns:

(StudentName, TotalMarks, Grade)

Requirements:

Accept marks from 3 subjects

Calculate total

Assign grade using conditions

Return all values as ValueTuple.
*/
class TupleBasedDataProcessing
{
    public static (string name, int totalMark, char grade) Result(string name, int marks)
    {
        int totalMark = 0;

        for (int i = 1; i <= 3; i++)
        {
            totalMark += marks;
        }
        if (totalMark > 80 && totalMark < 90)
        {
            return (name, totalMark, 'A');
        }
        else if (totalMark > 70 && totalMark < 80)
        {
            return (name, totalMark, 'B');
        }
        else if (totalMark > 60 && totalMark < 70)
        {
            return (name, totalMark, 'c');
        }
        return (name, totalMark, 'F');



    }

    static void Main()
    {

        string[] subject = new string[3];
        for (int i = 0; i < subject.Length; i++)
        {
            Console.WriteLine("enter the name, marks,subject");
            string name = Console.ReadLine();
            int marks = Convert.ToInt32(Console.ReadLine());
            subject[i] = Console.ReadLine();

            Result(name, marks);


        }




    }
}