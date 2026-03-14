/*
BASIC LEVEL
1️⃣ Return Multiple Values Using Tuple

Create a method that returns two values using Tuple.

Requirements:

Method GetStudentInfo()

Return Name and Marks

Access tuple values and print them.

*/
class MultipleValues
{
    public static Tuple<string, int> tuple = { { "nitin", 98 }, { "mukesh", 43 }, { "rajesh", 87 } };

    static void Main(string[] args)
    {
        MultipleValues multipleValues = new MultipleValues();
        multipleValues.GetStudentInfo();



    }
    Tuple<string, int> GetStudentInfo()
    {
        return tuple;




    }
}