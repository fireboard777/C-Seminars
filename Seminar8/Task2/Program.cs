using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем прямоугольный двумерный массив размером 3x4
        int[,] arr = new int[,]
        {
            { 3, 1, 4, 2 },
            { 9, 5, 8, 6 },
            { 7, 10, 12, 11 }
        };

        int minSumRow = 0;
        int minSum = int.MaxValue;

        // Проходим по каждой строке и находим строку с наименьшей суммой элементов
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }

        // Выводим наименьшую строку
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");
    }
}
