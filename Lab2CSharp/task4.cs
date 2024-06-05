// dotnet run --property:DefineConstants="RUN_TASK4"
using System;

class Task4
{
#if RUN_TASK4
    static int[][] Input()
    {
        Console.WriteLine("Enter the size of the jagged array (n):");
        int n = int.Parse(Console.ReadLine());

        int[][] array = new int[n][];

        for (int i = 0; i < n; ++i)
        {
            Console.WriteLine($"Enter the number of elements in row {i + 1}:");
            int mj = int.Parse(Console.ReadLine());

            array[i] = new int[mj];

            Console.WriteLine($"Enter elements for row {i + 1}:");
            for (int j = 0; j < mj; ++j)
            {
                Console.Write($"Element [{i},{j}]: ");
                array[i][j] = int.Parse(Console.ReadLine());
            }
        }

        return array;
    }

    static void Print(int[][] array)
    {
        Console.WriteLine("Original jagged array:");
        for (int i = 0; i < array.Length; ++i)
        {
            for (int j = 0; j < array[i].Length; ++j)
            {
                Console.Write("{0,5} ", array[i][j]);
            }
            Console.WriteLine();
        }
    }

    static int[] MinInColumns(int[][] array)
    {
        int[] result = new int[array[0].Length];

        for (int j = 0; j < array[0].Length; j++)
        {
            int min = array[0][j];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i][j] < min)
                {
                    min = array[i][j];
                }
            }
            result[j] = min;
        }

        return result;
    }

    static void Main()
    {
        int[][] myArray = Input();

        Console.WriteLine();

        int[] result = MinInColumns(myArray);

        Console.WriteLine("Minimum element in each column:");
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine($"Column {i + 1}: {result[i]}");
        }
    }
#endif
}
