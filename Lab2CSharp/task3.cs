// dotnet run --property:DefineConstants="RUN_TASK3"
using System;

class Task3
{
#if RUN_TASK3
    static int[,] Input(out int n)
    {
        Console.WriteLine("Enter the size of the array (n):");
        n = int.Parse(Console.ReadLine());

        int[,] array = new int[n, n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i},{j}]= ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return array;
    }

    static void Print(int[,] array)
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,5} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }

    static double ArithmeticMean(int[,] array)
    {
        int count = 0;
        double sum = 0;

        for (int i = 1; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[i, j] % 2 == 0)
                {
                    sum += array[i, j];
                    count++;
                }
            }
        }

        if (count != 0)
        {
            return sum / count;
        }
        else
        {
            return 0;
        }
    }

    static void Main()
    {
        int n;
        int[,] myArray = Input(out n);

        Console.WriteLine("Original array:");
        Print(myArray);

        double average = ArithmeticMean(myArray);
        Console.WriteLine($"Arithmetic mean of even elements below the main diagonal: {average:f2}");
    }
#endif
}
