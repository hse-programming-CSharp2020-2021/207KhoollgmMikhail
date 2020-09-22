using System;
using System.Reflection.Metadata.Ecma335;

namespace Task_01
{
    class Program
    {
        public static double CalculFunction(double x)
        {
            return x * x * (12 * x * x + 9 * x - 3) + 2 * x - 4;
        }



        static void Main(string[] args)
        {
            double x;

            if (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            Console.WriteLine((CalculFunction(x)).ToString("F3"));

        }


    }
}
