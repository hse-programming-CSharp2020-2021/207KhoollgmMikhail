using System;

namespace Task_1
{
    interface ICalculation
    {
        double Perform(double x);
    }

    class Add : ICalculation
    {
        double value;
        public Add(double v) { value = v; }

        public double Perform(double x)
        {
            return x + value;
        }
    }

    class Multiply : ICalculation
    {
        double koeff;
        public Multiply(double k) { koeff = k; }

        public double Perform(double x)
        {
            return x * koeff;
        }
    }

    class Program
    {
        public static double Calculate(double x, Add a, Multiply m)
        {
            return (m as ICalculation).Perform((a as ICalculation).Perform(x));
        }
        static void Main(string[] args)
        {
            Add a = new Add(5);
            Multiply m = new Multiply(7);
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(Calculate(i, a, m));
            }
        }
    }
}
