using System;

namespace Geometry
{
	public class Triangle
	{
		public (double x, double y) A { get; }
		public (double x, double y) B { get; }
		public (double x, double y) C { get; }

		public Triangle((double x, double y) a, (double x, double y) b, (double x, double y) c)
		{
			A = a;
			B = b;
			C = c;
		}

		public double Area()
		{
			// Формула площі трикутника (метод «шнурівки»)
			return 0.5 * Math.Abs(
				A.x * (B.y - C.y) +
				B.x * (C.y - A.y) +
				C.x * (A.y - B.y)
			);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var triangle = new Triangle((0, 0), (4, 0), (0, 3));
			Console.WriteLine($"Площа трикутника: {triangle.Area()}");
		}
	}
}
