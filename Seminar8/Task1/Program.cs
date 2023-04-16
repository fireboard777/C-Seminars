using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем двумерный массив размером 3x4
        int[,] arr = new int[,]
        {
            { 3, 1, 4, 2 },
            { 9, 5, 8, 6 },
            { 7, 10, 12, 11 }
        };

        // Проходим по каждой строке и сортируем ее по убыванию
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                for (int k = j + 1; k < arr.GetLength(1); k++)
                {
                    if (arr[i, j] < arr[i, k])
                    {
                        int temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }

        // Выводим отсортированный массив
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
