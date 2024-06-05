// dotnet run --property:DefineConstants="RUN_TASK1_2"
using System;

class Task1_2
{
#if RUN_TASK1_2
    static int[,] InputArray()
    {
        Console.WriteLine("Enter the size of the array:");
        Console.Write("Rows (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Columns (m): ");
        int m = int.Parse(Console.ReadLine());

        int[,] array = new int[n, m];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return array;
    }

    static void PrintArray(int[,] array)
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void ReplaceElements(int[,] array, int threshold)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < threshold)
                {
                    array[i, j] = threshold;
                }
            }
        }
    }

    static void Main()
    {
        int[,] myArray = InputArray();

        Console.WriteLine("Enter the threshold value:");
        int threshold = int.Parse(Console.ReadLine());

        Console.WriteLine("Original array:");
        PrintArray(myArray);

        ReplaceElements(myArray, threshold);

        Console.WriteLine("Array after replacement:");
        PrintArray(myArray);
    }
#endif
}
