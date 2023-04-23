using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Чётные числа в промежутке от {m} до {n}:");
        PrintEvenNumbers(m, n);
    }

    static void PrintEvenNumbers(int start, int end)
    {
        if (start > end)
        {
            return;
        }

        if (start % 2 == 0)
        {
            Console.Write(start + " ");
        }

        PrintEvenNumbers(start + 1, end);
    }
}
