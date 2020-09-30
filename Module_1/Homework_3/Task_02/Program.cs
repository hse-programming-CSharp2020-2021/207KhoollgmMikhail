using System;

namespace Task_02
{
    class Program
    {
        public static double Average(int s, int k)
        {
            return (double)s / k;

        }


        static void Main(string[] args)
        {
            int x = -1, s = 0, k = 0;

            while (true)
            {
                Console.WriteLine("Для завершения введите 0");
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Invalid value");
                    return;
                }
                if (x < 0)
                {
                    s += x;
                    k++;
                }
                if ((x == 0) || s < -1000) break;
            }
            Console.WriteLine(Average(s, k));

        }
    }
}
