using System;

class Program {
    static void Main() {
        Console.Write("Введите пятизначное число: ");
        string number = Console.ReadLine();

        if (number.Length != 5) {
            Console.WriteLine("Вы ввели неправильное количество цифр.");
            return;
        }

        for (int i = 0, j = number.Length - 1; i < 5; i++, j--) {
            if (number[i] != number[j]) {
                Console.WriteLine("Число не является палиндромом.");
                return;
            }
        }

        Console.WriteLine("Число является палиндромом.");
    }
}
