using System;

namespace SemTask_4_06
{
    class Program
    {
        public static double FirstSum(double x)
        {
            double s1 = 0, s2 = -1;
            int k = 0;


            for (int i = 2; s1 != s2; i += 2)
            {
                s2 = s1;
                s1 += Math.Pow(-1, k) * (Math.Pow(2, i - 1) * Math.Pow(x, i)) / Fact(i);
                k++;
            }

            return s1;
        }

        public static double SecondSum(double x)
        {
            double s1 = 1, s2 = 0;


            for (int i = 1; s1 != s2; i++)
            {
                s2 = s1;
                s1 += Math.Pow(x, i) / Fact(i);
            }

            return s1;
        }

        public static double Fact(double n)
        {
            double res = 1;
            for (int i = 1; i <= n; i++) res *= i;
            return res;
        }




        static void Main(string[] args)
        {
            double value;

            if (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid value");
                return;
            }

            Console.WriteLine(FirstSum(value));
            Console.WriteLine(SecondSum(value));

        }
    }
}
