using System;
using System.Text;

namespace Task_1
{
    public delegate string ConvertRule(string str);

    class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr(str);
        }
    }

    class Program
    {
        public static string RemoveDigits(string str)
        {
            StringBuilder str1 = new StringBuilder(str);
            for (int i = 0; i < str1.Length; i++)
            {
                if ((str1[i] >= '0') && (str1[i] <= '9'))
                {
                    str1.Remove(i, 1);
                    i--;
                }
            }
            return str1.ToString();
        }

        public static string RemoveSpaces(string str)
        {
            StringBuilder str1 = new StringBuilder(str);
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == ' ')
                {
                    str1.Remove(i, 1);
                    i--;
                }
            }
            return str1.ToString();
        }

        static void Main(string[] args)
        {
            ConvertRule rd = RemoveDigits;
            ConvertRule rs = RemoveSpaces;

            Converter cv = new Converter();

            string test1 = "1njon423n5jn36";
            string test2 = "  jj k l [ effw  wfwerf";
            string test3 = "23 45 4f 6hj 9k";

            Console.WriteLine(cv.Convert(test1, rd));
            Console.WriteLine(cv.Convert(test2, rs));

            ConvertRule rds = rd + rs;
            foreach (ConvertRule a in rds.GetInvocationList())
            {
                Console.WriteLine(a?.Invoke(test3));
            }
        }
    }
}
