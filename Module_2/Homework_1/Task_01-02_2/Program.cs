using System;

namespace Task_01_02_2
{
    class Program
    {
        static int N;

        public static void FillArray(int[] A, int k)
        {
            k += 1;
            for (int i = 0; i < N; i++, k++)
            {
                A[i] = k;
                if (k == N) k = 0;
            }

        }


        static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Incorrect input");
            }

            int[][] arr = new int[N][];

            for (int i = 0; i < N; i++)
            {
                arr[i] = new int[N];
                FillArray(arr[i], i);
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{arr[i][j], 2} ");
                }
                Console.Write("\n");
            }
        }
    }
}
