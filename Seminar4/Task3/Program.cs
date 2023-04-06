using System;

class Program {
    static void Main() {
        int[] array = new int[8];

        // заполнение массива случайными числами от 1 до 10
        Random random = new Random();
        for (int i = 0; i < array.Length; i++) {
            array[i] = random.Next(1, 11);
        }

        // вывод элементов массива на экран
        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < array.Length; i++) {
            Console.WriteLine(array[i]);
        }
    }
}
