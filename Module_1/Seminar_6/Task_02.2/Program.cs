using System;
using System.IO;


namespace Task_02._2
{
    class Program
    {
        public static int BinToDec(string str)
        {

            // 1 0 1 0

            // 3 2 1 0

            // 0 1 2 3

            int n = 0;

            for (int i = 0; i < str.Length; i++)

            {

                n += (str[i] - '0') * (int)Math.Pow(2, str.Length - i - 1);

            }
 
            return n;

        }

        public static void Main(string[] args)

        {

            string path = "../../../../MyFile.txt";

            string str = File.ReadAllText(path);

            Console.WriteLine(BinToDec(str));

        }
    }
}
