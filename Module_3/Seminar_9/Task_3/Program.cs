using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(new FileStream("1.txt", FileMode.Create));
            Console.SetOut(sw);
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(100 + rnd.NextDouble() * 900);
            }
            sw.Close();
            StreamReader sr= new StreamReader(new FileStream("1.txt", FileMode.OpenOrCreate));
            Console.SetIn(sr);

            double sum = 0;
            for(int i = 0; i < 100; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            var standardOutput = new StreamWriter(Console.OpenStandardOutput());
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
            Console.WriteLine(sum / 100);
        }
    }
}
