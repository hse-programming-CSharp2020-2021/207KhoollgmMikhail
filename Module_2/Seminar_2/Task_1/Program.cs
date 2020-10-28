using System;
using System.Linq;

namespace DoubleArr
{
    class Circle
    {
        double _r;
        public double Radius
        {
            get
            {
                return _r;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Radius should be non-negative");
                _r = value;
            }
        }

        public double S
        {
            get
            {
                return Math.PI * _r * _r;
            }
        }

        public double L
        {
            get
            {
                return Math.PI * _r * 2;
            }
        }

        public Circle()
        {
            Radius = 1;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return $"Circle: radius = {Radius,7:f3}, Square = {S,7:f3}, Length = {L,7:f3}";
        }
    }


    class Program
    {
        public static double RandomRadius(double min, double max)
        {
            Random rnd = new Random();

            return rnd.Next((int)(min * 1000), (int)(max * 1000)) * 0.001;

        }
        static void Main(string[] args)
        {

            Console.Write("Введите количество кругов: ");
            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine("Incorrect input");
            }

            Console.Write("Введите минимальный радиус: ");
            if (!double.TryParse(Console.ReadLine(), out double rmin))
            {
                Console.WriteLine("Incorrect input");
            }

            Console.Write("Введите ммаксимальный радиус: ");
            if (!double.TryParse(Console.ReadLine(), out double rmax))
            {
                Console.WriteLine("Incorrect input");
            }

            Circle[] circles = new Circle[N];

            for (int i = 0; i < N; i++)
            {
                circles[i] = new Circle(RandomRadius(rmin, rmax));
                Console.WriteLine(circles[i].ToString());
            }

            double maxS = circles[0].S;
            int maxIndex = 0;
            for (int i = 1; i < N; i++)
            {
                if (circles[i].S > maxS)
                {
                    maxS = circles[i].S;
                    maxIndex = i;
                }
            }

            Console.WriteLine("Круг с наибольшей площадью: " + circles[maxIndex].ToString());

        }
    }
}