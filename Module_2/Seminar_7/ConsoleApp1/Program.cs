using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static void F()
        {
            
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            foreach (var number in numbers)
            {
                int square = (int)Math.Pow(number, 2);
                numbers.Add(square);
            }
            
        }

        public static void A(string s)
        {           
            
             Console.WriteLine(s[1]);
            
            
        }

        static void Main(string[] args)
        {
            try
            {
                F();                
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }      
            
            try
            {
                string s = null;
                A(s);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                int.Parse(null);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                double.Parse("3.14");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                int x = 0;
                int n = 5/x;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            
            try
            {
                File.ReadAllLines("c");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
