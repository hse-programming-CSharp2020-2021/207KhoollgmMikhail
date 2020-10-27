using System;
using System.IO;

namespace Task_01
{
    class Program
    {
        public static void GetDirectoryInfo(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine(path);
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.LastWriteTime);
        }
        
        static void Main(string[] args)
        {
            string path = @"C:\Users\mixak\source\repos\207KhoollgmMikhail\Module_1\Seminar_7\Task_01";

        }
    }
}
