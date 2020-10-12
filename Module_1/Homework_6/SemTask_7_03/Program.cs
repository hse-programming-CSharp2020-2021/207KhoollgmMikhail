using System;
using System.IO;
using System.Text;

namespace SemTask_7_03
{
    class Program
    {
        static Random rnd = new Random();

        public static void GenerationRandomText(string[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                int lineLength = rnd.Next(20, 51);
                for (int j = 0; j < lineLength; j++)
                {
                    text[i] += (char)rnd.Next('А', 'Я');
                }

                if (rnd.Next(0, 2) == 1) text[i] += ".";
            }
        }

        public static void WriteTextInFile(string[] text, string filePath)
        {
            File.WriteAllLines(filePath, text);
        }

        public static void ReadTextFromFile(string filePath)
        {
            string[] text = File.ReadAllLines(filePath);

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i][^1] == '.') Console.WriteLine(text[i][..^1]);
                else Console.WriteLine(text[i]);
            }
        }

        static void Main(string[] args)
        {
            const string fileName = "dialog.txt";
            Encoding enc = Encoding.Unicode;
            const int linesCount = 6;

            string[] text = new string[linesCount];

            GenerationRandomText(text);
            WriteTextInFile(text, fileName);

            foreach (string str in text) Console.WriteLine(str);


            ReadTextFromFile(fileName);


        }
    }
}
