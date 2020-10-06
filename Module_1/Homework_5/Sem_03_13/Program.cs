using System;

namespace Sem_03_13
{
    class Program
    {
        public static void PrintArray(int[] Array, int K)
        {
            for (int i = 1; K * i < Array.Length; i++)
            {
                Console.WriteLine(Array[K * i]);
            }
        }

        public static void RandomArray(int[] Array)
        {
            Random rnd = new Random();

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rnd.Next(-10, 11);
            }
        }

        static void Main(string[] args)
        {
            int N, K;

            if (!int.TryParse(Console.ReadLine(), out N) || N < 1)
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out K) || K < 1 || K > N)
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            int[] A = new int[N];

            RandomArray(A);
            PrintArray(A, K);
        }
    }
}
