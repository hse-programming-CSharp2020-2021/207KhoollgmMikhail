using System;
using System.Collections.Generic;

namespace Figures
{
    public class Point
    {
        internal double x, y;

        public double Area { get; internal set; }

        public double Len { get; internal set; }

        public virtual void Display()
        {
            Console.WriteLine($"Координаты точки = ({x:F3},{y:F3})");
        }
    }

    public class Circle : Point
    {
        double rad;

        public double Rad { get { return rad; } set { rad = value; } }

        public override void Display()
        {
            Console.WriteLine($"R = {Rad:F3}, S = {Area:F3}, P = {Len:F3}");
        }

        public Circle(double R, double X, double Y)
        {
            x = X;
            y = Y;
            Rad = R;
            Len = 2 * Math.PI * Rad;
            Area = Math.PI * Rad * Rad;
        }
    }

    public class Square : Point
    {
        double side;

        public double Side { get { return side; } set { side = value; } }

        public override void Display()
        {
            Console.WriteLine($"L = {Side:F3}, S = {Area:F3}, P = {Len:F3}");
        }

        public Square(double L, double X, double Y)
        {
            x = X;
            y = Y;
            Side = L;
            Len = 4 * Side;
            Area = side * side;
        }
    }

    public class FigureComparer : IComparer<Point>
    {
        public int Compare(Point p1, Point p2)
        {
            if (p1.Area > p2.Area)
                return 1;
            else if (p1.Area < p2.Area)
                return -1;
            else
                return 0;
        }
    }
}
