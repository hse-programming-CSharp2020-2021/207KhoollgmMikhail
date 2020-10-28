using System;

namespace Task_2
{
    class LatinChar
    {
        char _char = 'a';

        public char _Char
        {
            get
            {
                return _char;
            }
        }

        public LatinChar(char a)
        {
            if ((a < 97) && (a > 122))
            {
                throw new ArgumentException();
            }
            _char = a;
        }

        public LatinChar() { }

        public override string ToString()
        {
            return $"Letter is : {_char}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальный символ: ");
            if (!char.TryParse(Console.ReadLine(), out char min))
            {
                Console.WriteLine("Incorrect input");
            }

            Console.Write("Введите ммаксимальный символ: ");
            if (!char.TryParse(Console.ReadLine(), out char max))
            {
                Console.WriteLine("Incorrect input");
            }

            LatinChar A;

            for (char i = min; i <= max; i++)
            {
                A = new LatinChar(i);
                Console.WriteLine(A.ToString());
            }
        }
    }
}
