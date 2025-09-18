using System;

public class Triangle
{
    public double X1, Y1, X2, Y2, X3, Y3;

    public Triangle() { }

    public void Input()
    {
    Console.WriteLine("Введіть координати першої вершини (x1 y1):");
    var line1 = Console.ReadLine();
    if (line1 == null) throw new Exception("Ввід перервано");
    var parts1 = line1.Split();
    X1 = double.Parse(parts1[0]);
    Y1 = double.Parse(parts1[1]);

    Console.WriteLine("Введіть координати другої вершини (x2 y2):");
    var line2 = Console.ReadLine();
    if (line2 == null) throw new Exception("Ввід перервано");
    var parts2 = line2.Split();
    X2 = double.Parse(parts2[0]);
    Y2 = double.Parse(parts2[1]);

    Console.WriteLine("Введіть координати третьої вершини (x3 y3):");
    var line3 = Console.ReadLine();
    if (line3 == null) throw new Exception("Ввід перервано");
    var parts3 = line3.Split();
    X3 = double.Parse(parts3[0]);
    Y3 = double.Parse(parts3[1]);
    }

    public double Area()
    {
        // Формула площі трикутника за координатами вершин
        return 0.5 * Math.Abs(
            X1 * (Y2 - Y3) +
            X2 * (Y3 - Y1) +
            X3 * (Y1 - Y2)
        );
    }
}

class Program
{
    static void Main()
    {
        Triangle t = new Triangle();
        t.Input();
        Console.WriteLine("Площа трикутника: " + t.Area());
    }
}
