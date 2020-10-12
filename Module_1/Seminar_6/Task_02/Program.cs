using System;
using System.IO;


namespace Task_02
{
    class Program
    {
        public static string DecToBin(int number)
        {
            string str = "";
            do
            {
                str = (number % 2).ToString() + str;

                number /= 2;
            } while (number > 0);
            return str;
        }

        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            string path = "../../../../MyFile.txt";

            File.WriteAllText(path, DecToBin(n));

            Console.WriteLine(DecToBin(n));

        }
    }
}
