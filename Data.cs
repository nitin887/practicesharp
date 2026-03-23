/*
2️⃣ Generic Method – Print Data

Create a method PrintData<T>().

Requirements:

Accept any data type
Print the value to console
Call method with:
integer
string
boolean
*/
class Data
{
    void PrintData<T>(T output)
    {
        Console.WriteLine(output);


    }
    static void Main()
    {
        int integer = 8;
        string name = "nitin";
        bool condition = true;
        Data data = new Data();
        data.PrintData<int>(integer);
        data.PrintData<string>(name);
        data.PrintData<bool>(condition);



    }
}