using System;
using System.IO;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++) arr[i] = rnd.Next(10);
            string path = "MyFile1.txt";

            for (int i = 0; i < 5; i++)
                File.WriteAllBytes(path,
                    System.Text.Encoding.Default.GetBytes(Array.ConvertAll(arr, i => i.ToString()[0])));

            using (FileStream fstream = new FileStream("MyFile2.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(Array.ConvertAll(arr, i => i.ToString()[0]));
                fstream.Write(array, 0, array.Length);
            }

            using (StreamWriter sw = new StreamWriter("MyFile3.txt"))
            {
                foreach (var i in arr)
                    sw.Write(i);
            }

            using (BinaryWriter bw = new BinaryWriter(File.Open("MyFile4.txt", FileMode.OpenOrCreate)))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(Array.ConvertAll(arr, i => i.ToString()[0]));
                bw.Write(array, 0, array.Length);
            }

            using (StreamReader sr = new StreamReader($"MyFile4.txt"))
            {
                string line;
                int sum = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    int num = int.Parse(line);
                    if (num % 2 == 0) sum += num;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
