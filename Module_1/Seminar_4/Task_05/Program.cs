using System;

namespace Task_05
{
    class Program
    {
        public static void Sum(int k)
        {
            double s=0;
            for (int i = 0; i <= k; i++)
            {
                s += (i + 0.3) / (3 * i * i + 5);
                Console.WriteLine($"{i} \t {s:f3}");
            }
            
        }




        static void Main(string[] args)
        {
            int k;

            int.TryParse(Console.ReadLine(), out k);

            Sum(k);
        }
    }
}
