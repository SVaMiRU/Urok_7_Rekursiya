// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = Convert.ToInt32(Console.ReadLine());

        PrintNumbersInRange(m, n);
    }

    static void PrintNumbersInRange(int start, int end)
    {
        if (start <= end)
        {
            Console.WriteLine(start);
            PrintNumbersInRange(start + 1, end);
        }
    }
}
