using System;

namespace Task_2
{
    interface ISequence
    {
        double GetElement(int n);
    }

    class ArithmeticProgression : ISequence
    {
        double a, d;
        public ArithmeticProgression(double a, double d)
        {
            this.a = a;
            this.d = d;
        }

        public double GetElement(int n)
        {
            return a + d * (n - 1);
        }
    }

    class GeometricProgression : ISequence
    {
        double b, q;
        public GeometricProgression(double b, double q)
        {
            this.b = b;
            this.q = q;
        }

        public double GetElement(int n)
        {
            return b * Math.Pow(q, n - 1);
        }
    }

    class Program
    {

        public static double Sum(ISequence p, int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += p.GetElement(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new ArithmeticProgression(3, 5), 10));
        }
    }
}
