using System;

class Program
{
    static void Main()
    {
        int m = 3; // количество строк
        int n = 4; // количество столбцов

        double[,] array = new double[m, n];

        // заполнение массива случайными числами
        Random rnd = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rnd.NextDouble();
            }
        }

        // вывод массива на экран
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

