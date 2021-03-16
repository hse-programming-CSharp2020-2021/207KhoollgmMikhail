using System;

namespace Task_01
{
    interface IFigure
    {
        double Area { get; set; }
    }

    class Square : IFigure
    {
        double length;
        public double Area { get => length * length; set { length = value; } }

        public Square(double length) { this.length = length; }

        public override string ToString()
        {
            return $"Square with length:{length,4:F3} and area:{Area,4:F3}";
        }

    }

    class Circle : IFigure
    {
        double radius;
        public double Area { get => Math.PI * radius * radius; set { radius = value; } }

        public Circle(double radius) { this.radius = radius; }

        public override string ToString()
        {
            return $"Circle with radius:{radius,4:F3} and area:{Area,4:F3}";
        }
    }

    class Program
    {
        public static void PrintFigure<T>(T[] figures, double limit) where T : IFigure
        {
            foreach(var f in figures)
            {
                if (f.Area > limit)
                    Console.WriteLine(f);
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            var figures = new IFigure[10];

            for(int i = 0; i < 10; i++)
            {
                if (rnd.Next(0, 2) == 1)
                    figures[i] = new Circle(rnd.NextDouble() * rnd.Next(0, 101));
                else figures[i] = new Square(rnd.NextDouble() * rnd.Next(0, 101));
            }

            Array.ForEach(figures, Console.WriteLine);
            Console.WriteLine();

            PrintFigure<IFigure>(figures, 100);
        }
    }
}
