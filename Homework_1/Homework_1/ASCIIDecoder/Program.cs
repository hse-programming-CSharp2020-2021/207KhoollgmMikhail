using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            char word;
            string inpStr;
            int a;

            inpStr = Console.ReadLine();
            int.TryParse(inpStr, out a);
            word = (char)a;
            Console.WriteLine(word);
        }
    }
}
