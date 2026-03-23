/*
🔹 ADVANCED INDEXERS
9️⃣ Multidimensional Indexer – Matrix

Create a class Matrix.

Requirements:

Store numbers in a 2D array

Create indexer matrix[row, column]

Allow reading and writing values.

Example usage:

matrix[1,2] = 50;
Console.WriteLine(matrix[1,2]);
*/
class MultidimensionalIndexer
{
    private int[,] number = new int[2, 2] { { 1, 2 }, { 2, 3 } };
    public int this[int i, int j]
    {
        get
        {
            return number[i, j];
        }
        set
        {
            number[i, j] = value;
        }
    }
    static void Main()
    {
        MultidimensionalIndexer multidimensionalIndexer = new MultidimensionalIndexer();
        multidimensionalIndexer[0, 1] = 50;

        Console.WriteLine(multidimensionalIndexer[0, 1]);







    }
}