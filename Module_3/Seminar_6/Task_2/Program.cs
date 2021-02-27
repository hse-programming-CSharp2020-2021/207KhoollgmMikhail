using System;

namespace Task_2
{
    struct PointS
    {
        double x, y;

        public double X
        {
            get => x;
            set => x = value;
        }
        public double Y
        {
            get => y;
            set => y = value;
        }

        public PointS(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Distance(PointS point)
        {
            return Math.Sqrt((X - point.X) * (X - point.X) + (Y - point.Y) * (Y - point.Y));
        }

        public override string ToString()
        {
            return $"({x:f3}, {y:f3})";
        }
    }

    struct Circle : IComparable
    {
        double rad;
        PointS center;

        public double Rad { get => rad; private set => rad = value; }

        public PointS Center { get => center; private set => center = value; }

        public Circle(double x, double y, double r)
        {
            rad = r;
            center = new PointS(x, y);
        }

        public double Length { get => Math.PI * 2 * rad; }

        public int CompareTo(object obj)
        {
            Circle second = (Circle)obj;
            return Rad.CompareTo(second.Rad);
        }

        public override string ToString()
        {
            return $"R = {rad:f3}, Center = {center}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[5];

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                circles[i] = new Circle(rnd.NextDouble() * 10,
                    rnd.NextDouble() * 10, rnd.NextDouble() * 10);
            }

            Array.Sort(circles);

            foreach (var c in circles)
                Console.WriteLine(c);
        }
    }
}
