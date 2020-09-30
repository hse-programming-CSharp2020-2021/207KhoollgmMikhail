using System;

namespace SemTask_5_09
{
    class Program
    {
        public static void RandArray(ref double[] Values)
        {
            Random rnd = new Random();
            for (int i = 0; i < Values.Length; i++)
            {
                Values[i] = rnd.Next(10);
            }
        }

        public static void NormArray(ref double[] Values, int a)
        {
            double max = -1;
            for (int i = 0; i < Values.Length; i++)
            {
                if (Math.Abs(Values[i]) > max) max = Values[i];
            }

            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] == max) Values[i] = a;
            }
        }

        public static void Print(ref double[] Values)
        {
            for (int i = 0; i < Values.Length; i++)
            {
                Console.Write(Values[i] + " ");
            }
            Console.WriteLine();

        }



        static void Main(string[] args)
        {
            int a;
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid value");
                return;
            }

            double[] values = new double[10];

            RandArray(ref values);
            Print(ref values);

            NormArray(ref values, a);
            Print(ref values);

        }
    }
}
