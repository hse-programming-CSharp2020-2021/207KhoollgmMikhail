using System;

namespace SemTask_4_07
{
    class Program
    {
        public static uint NOD(ref uint[] minDivisors, ref uint[] maxDivisors)
        {
            for (uint i = (uint)(minDivisors.Length - 1); true; i--)
            {
                if ((minDivisors[i] == 1) && (maxDivisors[i] == 1)) return i;
            }
        }

        public static uint NOK(uint min, uint max, uint nod)
        {
            return min * max / nod;
        }

        public static void Divisors(uint value, ref uint[] valueDivisors)
        {
            for (int i = 1; i <= value; i++)
            {
                if (value % i == 0) valueDivisors[i]++;
            }
        }




        static void Main(string[] args)
        {
            uint A = 0, B = 0, max, min, nod;

            if (!(uint.TryParse(Console.ReadLine(), out A) && uint.TryParse(Console.ReadLine(), out B)))
            {
                Console.WriteLine("Invalid value");
                return;
            }

            max = (A > B) ? A : B;
            min = (A < B) ? A : B;

            uint[] maxDivisors = new uint[max + 1];
            uint[] minDivisors = new uint[max + 1];

            Divisors(max, ref maxDivisors);
            Divisors(min, ref minDivisors);

            nod = NOD(ref minDivisors, ref maxDivisors);

            Console.WriteLine(nod);
            Console.WriteLine(NOK(min, max, nod));
        }
    }
}