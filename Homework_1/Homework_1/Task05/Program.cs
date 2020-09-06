using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpStr;
            double a, b;

            Console.WriteLine("Введите 1-ый катет: ");
            inpStr = Console.ReadLine();
            double.TryParse(inpStr, out a);

            Console.WriteLine("Введите 2-ой катет: ");
            inpStr = Console.ReadLine();
            double.TryParse(inpStr, out b);

            Console.WriteLine("Гипотенуза = " + Math.Sqrt(a*a+b*b));
        }
    }
}
