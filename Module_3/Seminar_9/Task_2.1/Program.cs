using System;
using System.IO;

namespace Task_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            BinaryWriter fOut = new BinaryWriter(new FileStream("../../../../Numbers.dat", FileMode.Create));

            for (int i = 0; i <= 10; i += 2)
                fOut.Write(rnd.Next(1, 101));

            fOut.Close();
        }
    }
}
