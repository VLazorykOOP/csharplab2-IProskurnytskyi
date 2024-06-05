// dotnet run --property:DefineConstants="RUN_TASK2"
using System;

class Task2
{
#if RUN_TASK2
    static int[] Input()
    {
        Console.WriteLine("Enter the size of the array:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}]= ");
            a[i] = int.Parse(Console.ReadLine());
        }
        return a;
    }

    static int Min(int[] a)
    {
        int min = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
            }
        }
        return min;
    }

    static void Main()
    {
        int[] myArray = Input();
        int min = Min(myArray);
        int count = 0;

        Console.WriteLine("Indices of all minimum elements:");

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] == min)
            {
                Console.WriteLine($"Index: {i}");
                count++;
            }
        }

        Console.WriteLine($"Number of minimum elements = {count}");
    }
#endif
}
