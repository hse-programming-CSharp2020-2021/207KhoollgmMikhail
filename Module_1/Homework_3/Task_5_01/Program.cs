﻿using System;

namespace Task_5_01
{
    class Program
    {
        public static void NormArray(ref int[] Values, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Values[i] = (int)Math.Pow(2, i);
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
            int N;
            if (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Invalid value");
                return;
            }

            int[] values = new int[N];


            NormArray(ref values, N);
            Print(ref values);

        }
    }
}
