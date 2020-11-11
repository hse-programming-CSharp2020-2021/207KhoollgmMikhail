using System;

namespace Task_09
{
    class LinearEquation
    {
        double a, b, c;

        public double Root
        {
            get
            {
                return (c - b) / a;
            }
        }

        public LinearEquation(double a, double b, double c)
        {
            if ((a == 0) && (b == c)) throw new Exception("Корнем является все рациональные числа");
            if ((a == 0) && (b != c)) throw new Exception("Корня не существует");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override string ToString()
        {
            return $"{a:F3}x + {b:F3} = {c:F3}  \nx = {Root:F3}";
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            do
            {                
                int N;
                do { Console.Write("Введите число линейных уравнений: "); }
                while (!int.TryParse(Console.ReadLine(), out N));

                LinearEquation[] equations = new LinearEquation[N];

                Random rnd = new Random();
                for (int i = 0; i < N; i++)
                {
                    double a = -10 + rnd.NextDouble() * 20;
                    double b = -10 + rnd.NextDouble() * 20;
                    double c = -10 + rnd.NextDouble() * 20;
                    try
                    {
                        equations[i] = new LinearEquation(a, b, c);
                    }
                    catch (Exception)
                    {
                        i--;
                        continue;
                    }
                }

                for (int i = 0; i < equations.Length - 1; i++)
                {
                    double min = equations[i].Root;
                    int mini = i;
                    for (int j = i + 1; j < equations.Length; j++)
                    {
                        if (min > equations[j].Root)
                        {
                            min = equations[j].Root;
                            mini = j;
                        }
                    }
                    if (mini == i) continue;
                    LinearEquation temp = equations[i];
                    equations[i] = equations[mini];
                    equations[mini] = temp;
                }
                Console.Write("\n");

                for (int i = 0; i < equations.Length; i++)
                {
                    Console.WriteLine($"Уравнение №{i+1,2}: {equations[i]}");
                }

                Console.WriteLine("Нажмите ESC, чтобы выйти");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
