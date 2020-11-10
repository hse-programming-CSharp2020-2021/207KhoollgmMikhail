using System;

namespace Task_08
{
    class Point
    {
        double x, y;

        public double X
        {
            get { return x; }
            private set { x = value; }
        }
        public double Y
        {
            get { return y; }
            private set { y = value; }
        }

        public Point()
        {

        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(double x, double y)
        {
            return Math.Sqrt((X - x) * (X - x) + (Y - y) * (Y - y));
        }

        public double Distance(Point a)
        {
            return Math.Sqrt((X - a.X) * (X - a.X) + (Y - a.Y) * (Y - a.Y));
        }
    }

    class Triangle
    {
        Point a, b, c;

        public Point A
        {
            get { return a; }
            private set { a = value; }
        }
        public Point B
        {
            get { return b; }
            private set { b = value; }
        }
        public Point C
        {
            get { return c; }
            private set { c = value; }
        }

        public Triangle() { }

        public Triangle(Point a, Point b, Point c)
        {
            if (a.Distance(b) + a.Distance(c) < b.Distance(c)) throw new Exception("Такого треугольника не существует");
            if (b.Distance(a) + b.Distance(c) < a.Distance(c)) throw new Exception("Такого треугольника не существует");
            if (c.Distance(a) + c.Distance(b) < a.Distance(b)) throw new Exception("Такого треугольника не существует");

            A = a;
            B = b;
            C = c;
        }

        public double P()
        {
            return a.Distance(b) + a.Distance(c) + b.Distance(c);
        }

        public double S()
        {
            double p = P() / 2;
            return Math.Sqrt(p * (p - a.Distance(b)) * (p - a.Distance(c)) * (p - b.Distance(c)));
        }

        public override string ToString()
        {
            return $"Периметр: {P(),5:F3}, Площадь: {S(),5:F3}";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Triangle[] triangles = new Triangle[rnd.Next(5, 16)];

            for (int i = 0; i < triangles.Length; i++)
            {
                Point a = new Point(-10 + rnd.NextDouble() * 20, -10 + rnd.NextDouble() * 20);
                Point b = new Point(-10 + rnd.NextDouble() * 20, -10 + rnd.NextDouble() * 20);
                Point c = new Point(-10 + rnd.NextDouble() * 20, -10 + rnd.NextDouble() * 20);
                triangles[i] = new Triangle(a, b, c);
            }

            for (int i = 0; i < triangles.Length; i++)
            {
                Console.WriteLine($"Треугольник №{i,2}: {triangles[i]}");
            }

            for (int i = 0; i < triangles.Length - 1; i++)
            {
                double max = triangles[i].S();
                int maxi = i;
                for (int j = i + 1; j < triangles.Length; j++)
                {
                    if (max < triangles[j].S())
                    {
                        max = triangles[j].S();
                        maxi = j;
                    }
                }
                if (maxi == i) continue;
                Triangle temp = triangles[i];
                triangles[i] = triangles[maxi];
                triangles[maxi] = temp;
            }
            Console.Write("\n");

            for (int i = 0; i < triangles.Length; i++)
            {
                Console.WriteLine($"Треугольник №{i,2}: {triangles[i]}");
            }
        }
    }
}
