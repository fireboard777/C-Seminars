using System;

class Program
{
    static void Main()
    {
        // задаем двумерный массив
        int[,] array = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // получаем количество строк и столбцов массива
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        // проходимся по столбцам и находим среднее арифметическое элементов
        for (int j = 0; j < columns; j++)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            double average = (double)sum / rows;
            Console.WriteLine("Среднее арифметическое элементов в столбце " + j + " равно " + average);
        }
    }
}
