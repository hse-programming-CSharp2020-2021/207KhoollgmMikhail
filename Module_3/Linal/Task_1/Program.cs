using System;

namespace Task_1
{
    class Program
    {
        public static int GCD(int val1, int val2)
        {
            while ((val1 != 0) && (val2 != 0))
            {
                if (val1 > val2)
                    val1 %= val2;
                else
                    val2 %= val1;
            }
            return Math.Max(val1, val2);
        }

        static void Main(string[] args)
        {
            int count = 0;
            for (int g = 0; g < 170; g++)
            {
                if (GCD(g, 170) == 1)
                {
                    Console.Write(5 * g + " ");
                    count++;
                }

            }
            Console.WriteLine(count);
        }
    }
}
