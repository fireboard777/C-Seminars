using System;

class Program {
    static void Main() {
        Console.Write("Введите количество чисел: ");
        int m = int.Parse(Console.ReadLine());
        
        int count = 0;
        for (int i = 0; i < m; i++) {
            Console.Write($"Введите число {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0) {
                count++;
            }
        }
        
        Console.WriteLine($"Количество чисел больше нуля: {count}");
    }
}

