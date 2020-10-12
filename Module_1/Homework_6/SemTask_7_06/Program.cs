using System;
using System.IO;

namespace SemTask_7_06
{
    class Program
    {
        public static void Average(int[] values)
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            Console.WriteLine(sum / values.Length);
        }


        static void Main(string[] args)
        {
            string filePath = "IntArray.txt";

            string file = File.ReadAllText(filePath);

            string[] values = file.Split(';');
            int[] array = new int[values.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (!int.TryParse(values[i], out array[i])) Console.WriteLine("Incorrect value");
                else Console.WriteLine(array[i]);
            }

            Average(array);
        }
    }
}
