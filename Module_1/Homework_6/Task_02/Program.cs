using System;
using System.IO;

namespace Task_02
{
    class Program
    {
        public static int NearestPowerOfTwo(int value)
        {
            int i = 0;
            while (value > 0)
            {
                value >>= 1;
                i++;
            }

            return (int)Math.Pow(2, i - 1);
        }

        static void Main(string[] args)
        {
            string inPath = "input.txt", outPath = "output.txt";

            string text = File.ReadAllText(inPath);

            string[] values = text.Split(' ');

            int[] powerOfTwo = new int[0];

            string result = "";

            for (int i = 0; i < values.Length; i++)
            {
                if ((int.Parse(values[i]) > 10000) || (int.Parse(values[i]) < 0))
                {
                    result += "Incorrect value ";
                }
                else
                {
                    result += NearestPowerOfTwo(int.Parse(values[i])).ToString() + " ";
                }
            }

            File.WriteAllText(outPath, result);


        }
    }
}
