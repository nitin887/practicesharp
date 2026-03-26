/*

9️⃣ Constructor Constraint

Create a generic method that:

Requirements:

Creates object using new()
Return instance of generic type.
*/
class ConstructionConstraint<T> where T : new()
{
    public T A;
}
class ConstructionConstraint1
{
    static void Main()
    {
        ConstructionConstraint<int> constructionConstraint = new ConstructionConstraint<int>();
        constructionConstraint.A = 10;
        Console.WriteLine(constructionConstraint.A);


    }
}