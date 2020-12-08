using System;
using System.Text;

namespace Task_2
{
    class Program
    {
        public static string DeleteSpaces(StringBuilder a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if ((a[i] == ' ') && (a[i + 1] == ' '))
                {
                    a.Remove(i, 1);
                    i--;
                }                        
            }
            return a.ToString();
        }

        public static int NumberOfWords(string a, int k)
        {
            string[] str = a.Split(" ");
            int sum = 0;
            foreach (string inStr in str)
            {
                if (inStr.Length > k) sum++;
            }
            return sum;
        }

        public static int Vowel(string a)
        {
            int sum = 0;
            a = a.ToLower();
            string[] str = a.Split(" ");
            char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            foreach (string inStr in str)
            {
                foreach (char ch in vowels)
                {
                    if (inStr.StartsWith(ch)) sum++;
                }
            }
            return sum;
        }


        static void Main(string[] args)
        {
            string input = DeleteSpaces(new StringBuilder(Console.ReadLine()));
            Console.WriteLine(input);
            Console.WriteLine(NumberOfWords(input, 4));
            Console.WriteLine(Vowel(input));

        }
    }
}
