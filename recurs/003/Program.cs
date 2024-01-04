//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };

        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReversed(arr, index - 1);
        }
    }
}
