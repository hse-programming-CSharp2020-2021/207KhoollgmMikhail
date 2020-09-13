using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpStr;

            int value;

            inpStr = Console.ReadLine();

            int.TryParse(inpStr, out value);
            Console.WriteLine(" " + value / 100);
            Console.WriteLine(" " + (value / 10)%10);
            Console.WriteLine(" " + value % 10);

        }
    }
}
