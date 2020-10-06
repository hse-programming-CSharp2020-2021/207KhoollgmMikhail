using System;

namespace Sem_04_06
{
    class Program
    {

        public static void RandomMatrix(int[,] A)
        {
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    A[i, j] = rnd.Next(0,26);
                }
            }
        }

        public static int Determinant1(int[,] A)
        {
            return (A[0, 0] * A[1, 1] * A[2, 2]) + (A[0, 1] * A[1, 2] * A[2, 0]) + (A[0, 2] * A[1, 0] * A[2, 1])
                - ((A[0, 2] * A[1, 1] * A[2, 0]) + (A[0, 0] * A[1, 2] * A[2, 1]) + (A[0, 1] * A[1, 0] * A[2, 2]));
        }
        public static int Determinant2(int[,] A)
        {
            return (A[0, 3] * A[1, 4] * A[2, 5]) + (A[0, 4] * A[1, 5] * A[2, 3]) + (A[0, 5] * A[1, 3] * A[2, 4])
                - ((A[0, 5] * A[1, 4] * A[2, 3]) + (A[0, 3] * A[1, 5] * A[2, 4]) + (A[0, 4] * A[1, 3] * A[2, 5]));
        }


        static void Main(string[] args)
        {
            int[,] A = new int[3, 6];
            int[] determinants = new int[2];

            RandomMatrix(A);
            determinants[0] = Determinant1(A);
            determinants[1] = Determinant2(A);
            Console.WriteLine($"Determinant 1 is {determinants[0]}");
            Console.WriteLine($"Determinant 2 is {determinants[1]}");
        }
    }
}
