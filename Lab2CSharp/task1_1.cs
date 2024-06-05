// dotnet run --property:DefineConstants="RUN_TASK1_1"
using System;

class Task1_1
{
#if RUN_TASK1_1
    static int[] InputArray()
    {
        Console.WriteLine("Enter the size of the array:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine("Array:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void ReplaceElements(int[] array, int threshold)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < threshold)
            {
                array[i] = threshold;
            }
        }
    }

    static void Main()
    {
        int[] myArray = InputArray();

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
