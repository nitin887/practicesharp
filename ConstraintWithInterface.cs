/*

🔹 GENERIC CONSTRAINTS
7️⃣ Constraint with Interface

Create a generic method.

Requirements:

Accept type T
Constrain it to implement IComparable
Compare two values and return the larger one.
*/
using System.Numerics;
using System.Runtime.InteropServices;

class ConstraintWithInterface
{
    public T Comparison<T>(T a, T b) where T : IComparable<T>
    {
        T largest = a;
        if (b.CompareTo(a) > 0)
        {
            largest = b;
        }
        return largest;
    }

    static void Main()
    {
        int a = 10;
        int b = 20;
        ConstraintWithInterface constraintWithInterface = new ConstraintWithInterface();
        Console.WriteLine(constraintWithInterface.Comparison<int>(a, b));

    }
}