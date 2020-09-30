using System;

namespace Task_5_03
{
    class Program
    {
        public static void NormArray(ref int[] Values, int N, int A, int D)
        {
            for (int i = 0; i < N; i++)
            {
                Values[i] = A + i * D;
            }
        }

        public static void Print(ref int[] Values)
        {
            for (int i = 0; i < Values.Length; i++)
            {
                Console.Write(Values[i] + " ");
            }
            Console.WriteLine();

        }



        static void Main(string[] args)
        {
            int N, A, D;
            if (!int.TryParse(Console.ReadLine(), out N) || N < 1)
            {
                Console.WriteLine("Invalid value");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out A))
            {
                Console.WriteLine("Invalid value");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out D))
            {
                Console.WriteLine("Invalid value");
                return;
            }

            int[] values = new int[N];


            NormArray(ref values, N, A, D);
            Print(ref values);

        }
    }
}
