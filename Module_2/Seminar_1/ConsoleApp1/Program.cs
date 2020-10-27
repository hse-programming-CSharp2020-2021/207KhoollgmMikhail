using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int Fac(int n)
        {

            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            return s;
        }


        public static int Combinations(int n, int k)
        {
            //if ((n == 0) && (k == 0)) return 1;
            //else if ((n == 1) && (k == 0)) return 1;
            //else if ((n == 1) && (k == 1)) return 1;
            //else if ((n == 2) && (k == 0)) return 1;
            //else if ((n == 2) && (k == 2)) return 1;
            return Fac(n) / (Fac(k) * Fac(n - k));



        }

        static void Main(string[] args)
        {
            int N;
            int.TryParse(Console.ReadLine(), out N);

            int[][] arr = new int[N][];

            for (int i = 0; i < N; i++)
            {
                arr[i] = new int[i + 1];
                for (int j = 0; j < i + 1; j++)
                {
                    arr[i][j] = Combinations(i, j);

                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                foreach(int k in arr[i])
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
