using System;

public class Triangle
{
    public double X1, Y1, X2, Y2, X3, Y3;

    public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        X1 = x1; Y1 = y1;
        X2 = x2; Y2 = y2;
        X3 = x3; Y3 = y3;
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
        // Приклад: координати вершин (0,0), (4,0), (0,3)
        Triangle t = new Triangle(0, 0, 4, 0, 0, 3);
        Console.WriteLine("Площа трикутника: " + t.Area());
    }
}
