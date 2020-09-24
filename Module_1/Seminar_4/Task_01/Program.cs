using System;

namespace Task_01
{
    class Program
    {
        public static bool Shift(ref char ch)
        {
            if (ch < 'a' || ch > 'z') return false;
            if (ch > 'v') ch = (char)(96 + ((int)ch + 4) % 122);
            else ch = (char)(ch + 4);
            return true;
        }


        static void Main(string[] args)
        {
            char ch;
            if(!char.TryParse(Console.ReadLine(), out ch))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            if (!Shift(ref ch))
            {
                Console.WriteLine("Неверное значение");
                return;
            }
            else Console.WriteLine(ch);
        }
    }
}
