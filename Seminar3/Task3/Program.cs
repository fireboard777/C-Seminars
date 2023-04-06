using System;

class Program {
    static void Main() {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Таблица кубов:");
        Console.WriteLine("--------------");

        for (int i = 1; i <= n; i++) {
            int cube = i * i * i;
            Console.WriteLine($"{i} в кубе = {cube}");
        }
    }
}
