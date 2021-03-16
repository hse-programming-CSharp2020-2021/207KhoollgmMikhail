using System;
using System.IO;

namespace Task_2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            using (FileStream f = new FileStream("../../../../Numbers.dat", FileMode.OpenOrCreate))
            {
                
                BinaryReader fIn = new BinaryReader(f);

                int[] arr = new int[f.Length / 4];
                long n = f.Length / 4; int a;
                for (int i = 0; i < n; i++)
                {
                    a = fIn.ReadInt32();
                    arr[i] = a;
                    Console.Write(a + " ");
                }
                

                int value;
                do
                {
                    Console.WriteLine("\nВведите число:");
                }
                while ((!int.TryParse(Console.ReadLine(), out value)) || (value < 1) || (value > 100));


                f.Position = 0;

                BinaryWriter fOut = new BinaryWriter(f);
                
                int min = 100;
                int mini = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Math.Abs(arr[i] - value) < min)
                    {
                        min = Math.Abs(arr[i] - value);
                        mini = i;
                    }
                }

                f.Position = mini * 4;
                fOut.Write(value);

                

                f.Position = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.Write(fIn.ReadInt32() + " ");
                }

                fOut.Close();
                fIn.Close();
                
            }


        }
    }
}
