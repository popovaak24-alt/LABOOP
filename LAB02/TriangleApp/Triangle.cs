using System;

namespace TriangleApp
{
    public class Triangle
    {
        public (double X, double Y) A { get; }
        public (double X, double Y) B { get; }
        public (double X, double Y) C { get; }

        public Triangle((double X, double Y) a, (double X, double Y) b, (double X, double Y) c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Area()
        {
            // Using the Shoelace formula
            return 0.5 * Math.Abs(
                A.X * (B.Y - C.Y) +
                B.X * (C.Y - A.Y) +
                C.X * (A.Y - B.Y)
            );
        }
    }
}
