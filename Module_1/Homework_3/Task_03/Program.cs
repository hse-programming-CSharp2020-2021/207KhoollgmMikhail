using System;

namespace Task_03
{
    class Program
    {
        public static double Y(double a, double b, double c, double x)
        {
            if (x < 1.2) return a * x * x + b * x + c;
            if (x == 1.2) return a / x + Math.Sqrt(x * x + 1);
            if (x > 1.2) return (a + b * x) / Math.Sqrt(x * x + 1);

            return 0;
        }



        static void Main(string[] args)
        {
            double a, b, c;
            if (!double.TryParse(Console.ReadLine(), out a) || !double.TryParse(Console.ReadLine(), out b) || !double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Invalid value");
                return;
            }

            for (double x = 1.00; x <= 2.00; x += 0.05) Console.WriteLine(Y(a, b, c, x));



        }
    }
}
