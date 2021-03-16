using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            BinaryWriter fOut = new BinaryWriter(new FileStream("../../../t.dat", FileMode.Create));

            for (int i = 0; i <= 10; i += 2)
                fOut.Write(i);

            fOut.Close();

            
            FileStream f = new FileStream("../../../t.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long n = f.Length / 4; int a;
            for (int i = 0; i < n; i++)
            {
                a = fIn.ReadInt32();
                Console.Write(a + " ");
            }

            // 1) TODO: Прочитать и напечатать все числа из файла в обратном порядке
            Console.WriteLine("\nЧисла в обратном порядке:");
            for (int i = 0; i < n; i++)
            {
                f.Seek(f.Length - 4 * (i + 1), SeekOrigin.Begin);
                a = fIn.ReadInt32();
                Console.Write(a + " ");
            }

            f.Seek(0, SeekOrigin.Begin);

            // 2) TODO: увеличить  все числа в файле в 5 раз
            BinaryWriter bw = new BinaryWriter(f);
            for (int i = 0; i < n; i++)
            {                
                a = fIn.ReadInt32();
                f.Seek(i * 4, SeekOrigin.Begin);
                bw.Write(5 * a);
            }

            // 3) TODO: Прочитать и напечатать все числа из файла в прямом порядке
            Console.WriteLine("\nЧисла, увеличенные в 5 раз:");
            f.Seek(0, SeekOrigin.Begin);

            for (int i = 0; i < n; i++)
            {
                a = fIn.ReadInt32();
                Console.Write(a + " ");
            }            
            
            bw.Close();
            fIn.Close();
            f.Close();
        }
    }
}
