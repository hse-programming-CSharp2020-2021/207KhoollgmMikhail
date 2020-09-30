using System;

namespace SemTask_5_08
{
    class Program
    {
        public static void FormArray(ref double[] Values, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Values[i] = i * (i + 1) / 2;
            }
        }

        public static void NormArray(ref double[] Values, int N)
        {
            double max=-1;
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(Values[i]) > max) max = Values[i];
            }

            for (int i = 0; i < N; i++)
            {
                Values[i] /= max;
            }
        }

        public static void Print(ref double[] Values, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(Values[i].ToString("F3") + " ");
            }
            Console.WriteLine();

        }



        static void Main(string[] args)
        {
            int N;
            if (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Invalid value");
                return;
            }

            double[] values = new double[N];

            FormArray(ref values, N);
            Print(ref values, N);

            NormArray(ref values, N);
            Print(ref values, N);

        }
    }
}
