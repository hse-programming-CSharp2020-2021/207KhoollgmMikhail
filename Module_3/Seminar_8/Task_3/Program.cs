using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "123.txt";
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                byte[] array = new byte[fs.Length];
                fs.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла: {textFromFile}");

                for (int i = 0; i < textFromFile.Length; i++)
                {
                    if ((textFromFile[i] >= '0') && (textFromFile[i] <= '9'))
                        Console.Write(textFromFile[i] + " ");
                }
            }


        }




    }
}



