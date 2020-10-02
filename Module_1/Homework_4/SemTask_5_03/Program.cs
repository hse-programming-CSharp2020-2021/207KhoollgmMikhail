using System;

namespace SemTask_5_03
{
    class Program
    {
        public static double Sin1(double x, int N, ref double[] SinLine)
        {
            double sin, sinOld, memb;



            int m; // число просуммированных членов ряда        
            for (m = 1, sin = memb = x, sinOld = 0; m < N; m++)
            {

                sinOld = sin;
                memb *= -x * x / 2 / m / (2 * m + 1);
                SinLine[m] = memb;
                sin += memb;
            }
            return sin;
        }

        public static double Sinx(double x)
        {
            double sin, sinOld, memb;



            int m; // число просуммированных членов ряда        
            for (m = 1, sin = memb = x, sinOld = 0; sin != sinOld; m++)
            {

                sinOld = sin;
                memb *= -x * x / 2 / m / (2 * m + 1);
                sin += memb;
            }
            return sin;
        }



        static void Main(string[] args)
        {
            double angle, x;
            int N;

            if (!double.TryParse(Console.ReadLine(), out angle))
            {
                Console.WriteLine("Неаерное значение");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Неаерное значение");
                return;
            }

            x = angle % (2 * Math.PI);


            double[] sin1 = new double[N];

            Sin1(1.0, N, ref sin1);

            Console.WriteLine("Своя функция: " + Sinx(x));
            Console.WriteLine("Math.Sin() " + Math.Sin(x));


        }
    }
}
