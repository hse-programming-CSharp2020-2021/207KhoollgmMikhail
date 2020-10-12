using System;
using System.IO;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string inPath = "input.txt", outPath = "output.txt";

            string text = File.ReadAllText(inPath);

            string[] values = text.Split(' ');

            bool[] boolValues = new bool[0];

            for (int i = 0; i < values.Length; i++)
            {
                Array.Resize(ref boolValues, boolValues.Length + 1);
                if ((int.Parse(values[i]) > 10) || (int.Parse(values[i]) < -10))
                {
                    values[i] = "Incorrect value";
                }
                else if (int.Parse(values[i]) >= 0)
                {
                    boolValues[i] = true;
                    values[i] = boolValues[i].ToString();
                }
                else
                {
                    boolValues[i] = false;
                    values[i] = boolValues[i].ToString();
                }
            }

            File.WriteAllLines(outPath, values);


        }
    }
}
