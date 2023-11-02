using System;

class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{
    private Point[] points;

    public Figure(Point point1, Point point2, Point point3)
    {
        points = new Point[] { point1, point2, point3 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = new Point[] { point1, point2, point3, point4 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = new Point[] { point1, point2, point3, point4, point5 };
    }

    public double GetSideLength(Point a, Point b)
    {
        return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += GetSideLength(points[i], points[i + 1]);
        }
        perimeter += GetSideLength(points[points.Length - 1], points[0]);

        Console.WriteLine("Багатокутник: ");
        foreach (var point in points)
        {
            Console.WriteLine($"Точка {point.Name}: ({point.X}, {point.Y})");
        }
        Console.WriteLine($"Периметр: {perimeter}");
    }
}

class Program
{
    static void Main()
    {
        Point pointA = new Point(0, 0, "A");
        Point pointB = new Point(0, 4, "B");
        Point pointC = new Point(3, 0, "C");

        Figure triangle = new Figure(pointA, pointB, pointC);
        triangle.CalculatePerimeter();

        Point pointD = new Point(0, 4, "D");
        Point pointE = new Point(3, 0, "E");
        Point pointF = new Point(3, 4, "F");

        Figure quadrilateral = new Figure(pointA, pointD, pointC, pointF);
        quadrilateral.CalculatePerimeter();
    }
}
