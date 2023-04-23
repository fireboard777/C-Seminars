using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = SumNaturalNumbers(m, n);
        Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} равна {sum}.");
    }

    static int SumNaturalNumbers(int start, int end)
    {
        if (start > end)
        {
            return 0;
        }

        return start + SumNaturalNumbers(start + 1, end);
    }
}
