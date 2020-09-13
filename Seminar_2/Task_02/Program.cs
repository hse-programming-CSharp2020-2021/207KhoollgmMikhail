using System;

namespace Task_02
{
    class Program
    {
        public static double Square (double radius){
            return Math.PI * radius * radius;
        }
        public static double Length(double length)
        {
            return 2*Math.PI * length;
        }
        static void Main(string[] args)
        {
            double r;

            if (!double.TryParse(Console.ReadLine(), out r) || r <= 0) 
            {
                return;
            }

            Console.WriteLine($" Площадь равна = {Square(r):f2}");
            Console.WriteLine($" Длина окружности равна = {Length(r):f2}");

        }
    }
}
