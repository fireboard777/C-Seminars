using System;

class Program {
    static void Main() {
        Console.Write("Введите координаты первой точки через пробел (x1 y1 z1): ");
        string[] coords1 = Console.ReadLine().Split();

        Console.Write("Введите координаты второй точки через пробел (x2 y2 z2): ");
        string[] coords2 = Console.ReadLine().Split();

        double x1 = double.Parse(coords1[0]);
        double y1 = double.Parse(coords1[1]);
        double z1 = double.Parse(coords1[2]);

        double x2 = double.Parse(coords2[0]);
        double y2 = double.Parse(coords2[1]);
        double z2 = double.Parse(coords2[2]);

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {distance:F2}");
    }
}
