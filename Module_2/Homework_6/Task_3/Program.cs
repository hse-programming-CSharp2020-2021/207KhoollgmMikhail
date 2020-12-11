using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStrings[] test = new MyStrings[2];
            try
            {
                test[0] = new RusString('б', 'к', 10);
                test[1] = new LatString('U', 'к', 10);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Некорректные данные");
            }

            try
            {
                test[1] = new LatString('f', 'u', 10);
                Console.WriteLine(test[0]);
                Console.WriteLine(test[1]);
                Console.WriteLine(test[0].IsPalindrome);
                Console.WriteLine(test[1].IsPalindrome);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Некорректные данные");
            }

        }
    }

    abstract class MyStrings
    {
        protected string str;
        public static Random rnd = new Random();
        public bool IsPalindrome
        {
            get
            {
                if (str.Length > 0)
                {
                    char[] tmp = str.ToCharArray();
                    Array.Reverse(tmp);
                    string tmpString = new string(tmp);
                    if (str.CompareTo(tmpString) == 0) return true;
                }
                return false;
            }
        }

        public abstract void Validate(char start, char finish, int n);
    }


    class RusString : MyStrings
    {
        public RusString(char start, char finish, int n)
        {
            Validate(start, finish, n);
            char[] letters = new char[n];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)rnd.Next(start, finish + 1);
            }
            str = new String(letters);
        }

        public override void Validate(char start, char finish, int n)
        {
            if (n <= 0 || start < 'а' || finish > 'я')
                throw new ArgumentOutOfRangeException();
        }


        public int CountLetter(char letter)
        {
            if (letter < 'а' || letter > 'я') return 0;
            int start = 0, result = -1, res;
            do
            {
                res = str.IndexOf(letter, start);
                start = res + 1;    // начало следующего поиска 
                result++;           // счетчик вхождений
            } while (res >= 0);
            return result;
        }

        public override string ToString()
        {
            return str;
        }
    }

    class LatString : MyStrings
    {
        public LatString(char start, char finish, int n)
        {
            Validate(start, finish, n);
            char[] letters = new char[n];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)rnd.Next(start, finish + 1);
            }
            str = new String(letters);
        }

        public override void Validate(char start, char finish, int n)
        {
            if (n <= 0 || start < 'a' || finish > 'z')
                throw new ArgumentOutOfRangeException();
        }


        public int CountLetter(char letter)
        {
            if (letter < 'a' || letter > 'z') return 0;
            int start = 0, result = -1, res;
            do
            {
                res = str.IndexOf(letter, start);
                start = res + 1;    // начало следующего поиска 
                result++;           // счетчик вхождений
            } while (res >= 0);
            return result;
        }

        public override string ToString()
        {
            return str;
        }
    }

}
