using System;

namespace ConsoleApp1
{
    public class Sin
    {
        public double Xmin { get; set; }

        public double Xmax { get; set; }

        public double delta { get; set; }

        public Sin(double xmin, double xmax, double delta)
        {
            Xmin = xmin;
            Xmax = xmax;
            this.delta = delta;
        }

        public double this[double number]
        {
            get
            {
                return Math.Round(Math.Sin(number), 4);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Sin a = new Sin(0, Math.PI, Math.PI / 6);

            for (double i = a.Xmin; i < a.Xmax; i += a.delta)
            {
                Console.WriteLine($"Sin({Math.Round(i,4)}) = {a[i]}");
            }
        }
    }
}
