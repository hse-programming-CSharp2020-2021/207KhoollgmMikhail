using System;

namespace Task_5_04
{
    class Program
    {
        public static void NormArray(ref int[] Values, int N)
        {
            for (int i = 2; i < N; i++)
            {
                Values[i] = Values[i - 1] + Values[i - 2];
            }
        }

        public static void PrintRev(ref int[] Values)
        {
            for (int i = Values.Length - 1; i > 0; i--
                )
            {
                Console.Write(Values[i] + " ");
            }
            Console.WriteLine();

        }



        static void Main(string[] args)
        {
            int N;
            if (!int.TryParse(Console.ReadLine(), out N) || N < 1)
            {
                Console.WriteLine("Invalid value");
                return;
            }


            int[] values = new int[N];
            values[0] = values[1] = 1;


            NormArray(ref values, N);
            PrintRev(ref values);

        }
    }
}
