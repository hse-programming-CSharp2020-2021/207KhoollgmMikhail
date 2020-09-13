using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpStr1, inpStr2, inpStr3;

            Console.WriteLine("Введите три любых слова: ");

            inpStr1 = Console.ReadLine();
            inpStr2 = Console.ReadLine();
            inpStr3 = Console.ReadLine();
            Console.WriteLine(inpStr1 + "!" + inpStr2 + "!" + inpStr3);

        }
    }
}
