using System;

namespace Task_3
{
    public delegate double function(double x);
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b, epsX, epsY;
                Console.Write("Введите левую грвницу интервала: ");
                double.TryParse(Console.ReadLine(), out a);
                Console.Write("Введите правую грвницу интервала: ");
                double.TryParse(Console.ReadLine(), out b);
                Console.Write("Введите точность по абсциссе: ");
                double.TryParse(Console.ReadLine(), out epsX);
                Console.Write("Введите точность по ординате: ");
                double.TryParse(Console.ReadLine(), out epsY);
                Console.WriteLine($"Корень функции: {NumMeth.Bisec(a, b, epsX, epsY, Math.Log)}");
                Console.WriteLine($"Корень функции: {NumMeth.Bisec(a, b, epsX, epsY, Log)}");
                Console.WriteLine($"Корень функции: {NumMeth.Bisec(a, b, epsX, epsY, delegate (double x) { return Math.Log(x); })}");
                Console.WriteLine($"Корень функции: {NumMeth.Bisec(a, b, epsX, epsY, x => Math.Log(x))}");
                Console.WriteLine($"Минимум функции cos(x): {NumMeth.Optimum_1(x => Math.Cos(x), 3, 6, 0.001, 0.001)}");
                Console.WriteLine($"Минимум функции x*(x*x-2)-5: {NumMeth.Optimum_1(x => x * (x * x - 2) - 5, 0, 1, 0.001, 0.001)}");
                Console.WriteLine($"Минимум функции -Sin(x)-Sin(3*x)/3 : {NumMeth.Optimum_1(x => -Math.Sin(x) - Math.Sin(3 * x) / 3, 0, 1, 0.001, 0.001)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static double Log(double x) => Math.Log(x);
    }

    public class NumMeth
    {
        // Метод поиска корня функции делением интервала пополам:
        static public double Bisec(double a, double b, // Границы интервала
           double epsX, double epsY,    // точность по абсциссе и ординате
           function f)
        {  // f - исследуемая функция
            double x, y, z; // локальные переменные
            x = a; y = f(x);
            if (Math.Abs(y) <= epsY) return x;
            x = b; z = f(x);
            if (Math.Abs(z) <= epsY) return x;
            if (y * z > 0)
                throw new Exception("Интервал не локализует корень функции!");
            do
            {
                x = a / 2 + b / 2; y = f(x);
                if (Math.Abs(y) <= epsY) return x;
                if (y * z > 0) b = x; else a = x;
            } while (Math.Abs(b - a) >= epsX);
            return x;
        }   // Bisec()

        public static double Optimum_1(function fun,
    // fun - минимизируемая функция (функционал)
    double A, double B,           //границы интервала
    double Delta, double Epsilon)
        { // точности по абсциссе и ординате
            double Rone = (Math.Sqrt(5.0) - 1.0) / 2.0; // Determine constants
            double Rtwo = Rone * Rone;      /* for golden search */
            double YA, YB;                  /* function values at A and B */
            double C, D;                    /* interior points */
            double H;                       /* width of interval */
            double P, YC, YD, YP;           /* minimum and function values */
            YA = fun(A);
            YB = fun(B);
            H = B - A;
            C = A + Rtwo * H;
            YC = fun(C);
            D = A + Rone * H;
            YD = fun(D);
            while (Math.Abs(YA - YB) > Epsilon || H > Delta)
            {
                if (YC < YD)
                {
                    B = D;
                    YB = YD;
                    D = C;
                    YD = YC;
                    H = B - A;
                    C = A + Rtwo * H;
                    YC = fun(C);
                }
                else
                {
                    A = C; YA = YC;
                    C = D;
                    YC = YD;
                    H = B - A;
                    D = A + Rone * H;
                    YD = fun(D);
                }
            }
            P = A;
            YP = YA;
            if (YB < YA) { P = B; YP = YB; }
            return P;
        }//Optimum_1()
    }
}
