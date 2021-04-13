using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace Task_2
{
    [Serializable]
    [DataContract]
    public class ConsoleSimbolStruct
    {
        [DataMember]
        public char simb; // символ
        [DataMember]
        public int x; // координата x
        [DataMember]
        public int y;  // координата y

        public ConsoleSimbolStruct(char ch, int x, int y)
        {
            if (x < 0 || y < 0)
                throw new ArgumentOutOfRangeException();
            this.x = x;
            this.y = y;
            simb = ch;
        }

        public ConsoleSimbolStruct() { }
        public override string ToString()
        {
            return simb + " " + x.ToString() + " " + y;
        }
    }

    [Serializable]
    [DataContract]
    public class ColorConsoleSymbol : ConsoleSimbolStruct
    {
        public ColorConsoleSymbol() { }

        public ColorConsoleSymbol(char ch, int x, int y, int color) : base(ch, x, y)
        {
            this.color = color;
        }
        [DataMember]
        public int color;
        public override string ToString()
        {
            return simb + " " + x.ToString() + " " + y + " " + color;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            ConsoleSimbolStruct[] symb = new ConsoleSimbolStruct[10];
            for (int i = 0; i < 10; i++)
            {
                if (rnd.Next(0, 2) == 0)
                    symb[i] = new ConsoleSimbolStruct((char)rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
                else
                    symb[i] = new ColorConsoleSymbol((char)rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
            }

            // XML
            XmlSerializer xmlser = new XmlSerializer(typeof(ConsoleSimbolStruct[]), new Type[] { typeof(ColorConsoleSymbol)});
            using (FileStream fs = File.Create("result1.xml"))
            {
                xmlser.Serialize(fs, symb);
            }

            ConsoleSimbolStruct[] result1;
            using (FileStream fs = File.Open("result1.xml", FileMode.Open))
            {
                result1 = (ConsoleSimbolStruct[])xmlser.Deserialize(fs);
            }

            Console.WriteLine("XML");
            foreach (var s in result1)
                Console.WriteLine(s);

            // Binary
            using (Stream file = new FileStream("result2.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(file, symb);
            }


            ConsoleSimbolStruct[] result2;
            using (Stream file = File.OpenRead("result2.bin"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                result2 = (ConsoleSimbolStruct[])formatter.Deserialize(file);
            }

            Console.WriteLine("Binary");
            foreach (var s in result2)
                Console.WriteLine(s);


            // JSON
            using (Stream file = new FileStream("result3.json", FileMode.Create))
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(JsonSerializer.Serialize(symb));
            }

            ConsoleSimbolStruct[] result3;
            using (Stream file = File.OpenRead("result3.json"))
            using (StreamReader reader = new StreamReader(file))
            {
                result3 = JsonSerializer.Deserialize<ConsoleSimbolStruct[]>(reader.ReadToEnd());
            }

            Console.WriteLine("JSON");
            foreach (var s in result2)
                Console.WriteLine(s);


            // DataContract
            DataContractSerializer contractSerializer = new DataContractSerializer(typeof(ConsoleSimbolStruct[]), new Type[] { typeof(ColorConsoleSymbol) });
            using (Stream file = new FileStream("result4.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                contractSerializer.WriteObject(file, symb);
            }

            ConsoleSimbolStruct[] result4;
            using (Stream file = File.OpenRead("result4.xml"))
            {
                result4 = (ConsoleSimbolStruct[])contractSerializer.ReadObject(file);
            }

            Console.WriteLine("DATA CONTRACT");
            foreach (var s in result2)
                Console.WriteLine(s);
        }
    }
}
