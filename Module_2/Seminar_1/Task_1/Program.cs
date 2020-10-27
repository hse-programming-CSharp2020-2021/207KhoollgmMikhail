using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][][] primary = new char[3][][];

            primary[0] = new char[3][];
            primary[1] = new char[2][];
            primary[2] = new char[1][];

            primary[0][0] = new char[] { 'a', 'b' };
            primary[0][1] = new char[] { 'c', 'd', 'e' };
            primary[0][2] = new char[] { 'f', 'g', 'h', 'i' };

            primary[1][0] = new char[] { 'j', 'k' };
            primary[1][1] = new char[] { 'l', 'm', 'n' };

            primary[2][0] = new char[] { 'o', 'p', 'q', 'r' };

            for (int i = 0; i < primary.Length; i++)
            {
                for (int j = 0; j < primary[i].Length; j++)
                {
                    foreach (char k in primary[i][j])
                    {
                        Console.Write(k);
                    }
                }
            }
        }
    }
}
