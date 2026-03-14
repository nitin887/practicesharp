/*
2️⃣ Predicate Delegate – Even Number Filter

Given a list of integers:

Requirements:

Use Predicate<int>

Filter even numbers

Use List<T>.FindAll()
*/
class EvenNumberFilter
{

    static void Main(string[] args)
    {

        List<int> number = [1, 2, 3, 4];
        Predicate<int> operation = s => s % 2 == 0;

        List<int> result = number.FindAll(operation);
        foreach (int number1 in result)
        {
            Console.WriteLine(number1);
        }




    }

}
