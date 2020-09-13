using System;

namespace Seminar_2
{
    class Program
    {
        public static void randomString()
        {
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(3, 20); i++)
            {
                Console.Write((char)rnd.Next('a', 'z' + 1));
            }
            Console.WriteLine(Math.Pow(3,4));

        }



        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //rnd.Next(-100, 10);
            //Console.WriteLine((char)rnd.Next('a', 'z' + 1));

            randomString();
            randomString();
            randomString();
            randomString();
            randomString();
            randomString();
            randomString();
            randomString();
            randomString();
            randomString();
        }
    }
}
