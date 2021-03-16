using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string h = "i lovelife";
            string h1 = new string(h.Reverse().ToArray());
            Console.WriteLine(h1);
            Console.ReadLine();
        }
    }
}
