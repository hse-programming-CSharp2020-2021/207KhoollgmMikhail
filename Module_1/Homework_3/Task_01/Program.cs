using System;

namespace Task_01
{
    class Program
    {
        public static bool Check(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }
        
        
        
        static void Main(string[] args)
        {
            int a, b, c;

            


            for (a = 1; a < 21; a++)
            {
                for (b = 1; b < 21; b++)
                {
                    for (c = 1; c < 21; c++)
                    {
                        if (Check(a, b, c)) Console.WriteLine(a + " " + b + " " + c);
                    }
                }
            }
        }
    }
}
