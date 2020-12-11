using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticTrinomial P1 = new QuadraticTrinomial(2, 3, 7);
            QuadraticTrinomial P2 = new QuadraticTrinomial(1, -5, 6);
            int[] X0 = { 1, -3, 3, 2, 7, 100, 0 };
            for (int i = 0; i < X0.Length; i++)
            {
                try
                {
                    Console.WriteLine($"P1({X0[i]})/P2({X0[i]}) = {P1.Division(P2, X0[i])}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Произошло деление на ноль");
                    Console.WriteLine($"P1({X0[i]}) = {P1.ValueInX(X0[i])}");
                    Console.WriteLine($"P2({X0[i]}) = {P2.ValueInX(X0[i])}");
                }
            }
        }
    }

    class QuadraticTrinomial
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public QuadraticTrinomial(double a, double b, double c)
        {
            A = a; B = b; C = c;
        }


        public double ValueInX(double x0)
        {
            return A * x0 * x0 + B * x0 + C;
        }


        public double Division(QuadraticTrinomial another, double x0)
        {
            double res = another.ValueInX(x0);
            if (res == 0) throw new DivideByZeroException();

            return ValueInX(x0) / res;
        }
    }
}
