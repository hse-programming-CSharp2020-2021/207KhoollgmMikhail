using System;

namespace Sem_04_05._2
{
    class Program
    {
        const int matrixSize = 3;

        public static void RandomMatrix(double[,] A)
        {
            Random rnd = new Random();

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    A[i, j] = rnd.NextDouble() * 10;
                }
            }
        }

        public static double Determinant(double[,] A)
        {
            return (A[0, 0] * A[1, 1] * A[2, 2]) + (A[0, 1] * A[1, 2] * A[2, 0]) + (A[0, 2] * A[1, 0] * A[2, 1])
                - ((A[0, 2] * A[1, 1] * A[2, 0]) + (A[0, 0] * A[1, 2] * A[2, 1]) + (A[0, 1] * A[1, 0] * A[2, 2]));
        }


        static void Main(string[] args)
        {
            double[,] A = new double[matrixSize, matrixSize];

            RandomMatrix(A);
            Console.WriteLine($"Determinant is {Determinant(A)}");
        }
    }
}
