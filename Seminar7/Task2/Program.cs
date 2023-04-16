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

        // просим пользователя ввести позиции элемента
        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int column = int.Parse(Console.ReadLine());

        // проверяем, что позиции элемента находятся в допустимых пределах
        if (row < 0 || row >= array.GetLength(0) || column < 0 || column >= array.GetLength(1))
        {
            Console.WriteLine("Указанные позиции находятся за пределами массива.");
        }
        else
        {
            // получаем значение элемента и выводим его на экран
            int value = array[row, column];
            Console.WriteLine("Значение элемента: " + value);
        }
    }
}
