using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 5; // Размерность квадратной матрицы

        int[,] matrix = new int[n, n]; // Создаем новую матрицу

        int value = 1; // Начальное значение элемента матрицы

        int row = 0; // Индекс строки текущего элемента
        int col = 0; // Индекс столбца текущего элемента

        int rowMax = n - 1; // Максимальный индекс строки
        int colMax = n - 1; // Максимальный индекс столбца

        int rowMin = 1; // Минимальный индекс строки
        int colMin = 0; // Минимальный индекс столбца

        while (value <= n * n) // Продолжаем заполнение, пока не достигнем конца матрицы
        {
            // Заполняем элементы верхней строки слева направо
            for (int i = col; i <= colMax; i++)
            {
                matrix[row, i] = value;
                value++;
            }
            row++; // Переходим на следующую строку

            // Заполняем элементы правого столбца сверху вниз
            for (int i = row; i <= rowMax; i++)
            {
                matrix[i, colMax] = value;
                value++;
            }
            colMax--; // Переходим на следующий столбец

            // Заполняем элементы нижней строки справа налево
            for (int i = colMax; i >= colMin; i--)
            {
                matrix[rowMax, i] = value;
                value++;
            }
            rowMax--; // Переходим на предыдущую строку

            // Заполняем элементы левого столбца снизу вверх
            for (int i = rowMax; i >= rowMin; i--)
            {
                matrix[i, colMin] = value;
                value++;
            }
            colMin++; // Переходим на следующий столбец
        }

        // Выводим матрицу на консоль
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
