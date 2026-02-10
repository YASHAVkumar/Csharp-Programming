public  class MultiDimenionArr
{
    public void Demo()
    {
        // Declare a 2D array
        int[,] matrix = new int[3, 4]
        //int[][] matrix = new int[3][4]
        {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };


        // Accessing elements
        Console.WriteLine("Element at (1,2): " + matrix[1, 2]); // Output: 7

        // Iterating through the array
        Console.WriteLine("Matrix elements:");
        for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) returns number of rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) returns number of columns
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void jaggedArrayDemo()
    {
        // Declare a jagged array
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Accessing elements
        Console.WriteLine("Element at (2,1): " + jaggedArray[2][1]); // Output: 7

        // Iterating through the jagged array
        Console.WriteLine("Jagged array elements:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void higherDimensionalArrayDemo()
    {
        // Declare a 3D array
        int[,,] threeDArray = new int[2, 2, 2]
        {
            { {1, 2}, {3, 4} },
            { {5, 6}, {7, 8} }
        };

        // Accessing elements
        Console.WriteLine("Element at (1,0,1): " + threeDArray[1, 0, 1]); // Output: 6

        // Iterating through the 3D array
        Console.WriteLine("3D array elements:");
        for (int i = 0; i < threeDArray.GetLength(0); i++)
        {
            for (int j = 0; j < threeDArray.GetLength(1); j++)
            {
                for (int k = 0; k < threeDArray.GetLength(2); k++)
                {
                    Console.Write(threeDArray[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}