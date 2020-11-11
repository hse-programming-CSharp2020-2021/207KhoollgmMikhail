using System;

namespace Task_10
{
    class Circle
    {
        double x, y, r;

        public double X { get { return x; } }

        public double Y { get { return y; } }

        public double R { get { return r; } }

        public bool DoTheCirclesIntersect(Circle a)
        {
            double rmax = Math.Max(R, a.R);
            double rmin = Math.Min(R, a.R);
            double d = Math.Sqrt((a.X - X) * (a.X - X) + (a.Y - Y) * (a.Y - Y));
            return (rmax - rmin < d) && (d < rmin + rmax);

        }

        public Circle(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public override string ToString()
        {
            return $"Координаты: ({X,6:F3},{Y,6:F3}), радиус = {R,6:F3}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {            
            do
            {
                int N;
                do { Console.Write("Введите число окружностей: "); }
                while (!int.TryParse(Console.ReadLine(), out N));

                Circle[] circles = new Circle[N];

                Random rnd = new Random();
                for (int i = 0; i < N; i++)
                {
                    double x = 1 + rnd.NextDouble() * 14;
                    double y = 1 + rnd.NextDouble() * 14;
                    double r = 1 + rnd.NextDouble() * 14;

                    circles[i] = new Circle(x, y, r);
                    Console.WriteLine($"Круг №{i + 1,2}: {circles[i]}");
                }

                Circle A = new Circle(1 + rnd.NextDouble() * 14, 1 + rnd.NextDouble() * 14, 1 + rnd.NextDouble() * 14);

                Console.WriteLine($"\nКруги пересекающиеся с кругом {A} :");

                for (int i = 0; i < circles.Length; i++)
                {
                    if (circles[i].DoTheCirclesIntersect(A))
                        Console.WriteLine($"Круг №{i + 1,2}: {circles[i]}");
                }

                Console.WriteLine("Нажмите ESC, чтобы выйти");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        
        }
    }
}
