using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Abbreviation
    {
        public static bool Validate(string str)
        {
            foreach (char ch in str)
            {
                if ((ch < 'A' || ch > 'Z') && (ch < 'a' || ch > 'z') && (ch != ' ')) return false;
            }
            return true;
        }

        public static string[] ValidatedSplit(string str, char ch)
        {
            string[] output = str.Split(ch);

            foreach (string s in output)
            {
                if (!Validate(s)) return null;
            }
            return output;
        }

        public static string Shorten(string str)
        {
            char[] alph = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            int ind = str.IndexOfAny(alph);
            return str[..(ind + 1)];
        }

        public static string Abbrevation(string str)
        {
            string output = String.Empty;
            if (str != String.Empty)
            {
                string[] tmp = str.Split(' ');
                foreach (string s in tmp)
                {
                    if (s == "") continue;
                    string shortenS = Shorten(s);
                    FirstUpcase(ref shortenS);
                    output += shortenS;
                }
            }
            return output;
        } 

        public static void FirstUpcase(ref string str)
        {
            string res= str[0].ToString().ToUpper();
            
            for (int i = 1; i < str.Length; i++)
            {
                res += str[i].ToString().ToLower();
            }
            str = res;
        } 


    }
}
