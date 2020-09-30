using System;

namespace Task_04
{
    class Program
    {
        public static ulong Sum(int N,int M)
        {
            ulong a = 1, b = 1;
            a <<= N;
            b <<= M;
            return a + b;

        }
        
        
        
        static void Main(string[] args)
        {
            int N, M;
            if (!int.TryParse(Console.ReadLine(), out N) || !int.TryParse(Console.ReadLine(), out M))
            {
                Console.WriteLine("Invalid value");
                return;
            }

            Console.WriteLine(Sum(N, M));
        }
    }
}
