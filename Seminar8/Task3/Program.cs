using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем две матрицы размером 2x3 и 3x2
        int[,] matrix1 = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int[,] matrix2 = new int[,]
        {
            { 7, 8 },
            { 9, 10 },
            { 11, 12 }
        };

        // Проверяем, что количество столбцов первой матрицы равно количеству строк второй матрицы
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            Console.WriteLine("Невозможно перемножить матрицы!");
            return;
        }

        // Создаем новую матрицу размером с количество строк первой матрицы и количество столбцов второй матрицы
        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        // Вычисляем произведение матриц
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        // Выводим результат
        Console.WriteLine("Результат произведения матриц:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
