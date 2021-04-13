using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    [Serializable]
    public class Student
    {
        public string surname;
        public int course;

        public override string ToString()
        {
            return $"Student = {surname} and course = {course}\n";
        }
    }

    [Serializable]
    public class Group
    {
        public int number;
        public List<Student> students;

        public override string ToString()
        {
            string result = $"Group {number} with students: \n";
            foreach(var s in students)
            {
                result += s;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {        
            Random rnd = new Random();
            Student[] students1 = new Student[10];
            for (int i = 0; i < 10; i++)
            {
                students1[i] = new Student();
                students1[i].surname = "Name " + i;
                students1[i].course = rnd.Next();
            }
            Group group1 = new Group() { number = 1, students = new List<Student>(students1) };

            Student[] students2 = new Student[10];
            for (int i = 0; i < 10; i++)
            {
                students2[i] = new Student();
                students2[i].surname = "Name " + i;
                students2[i].course = rnd.Next();
            }
            Group group2 = new Group() { number = 2, students = new List<Student>(students2) };

            Console.WriteLine("From programm: ");
            Console.WriteLine(group1);
            Console.WriteLine(group2);

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, group1);
            formatter.Serialize(stream, group2);
            stream.Close();




            BinaryFormatter formatter1 = new BinaryFormatter();
            Stream stream1 = new FileStream(@"D:\MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Group group3 = (Group)formatter1.Deserialize(stream1);
            Group group4 = (Group)formatter1.Deserialize(stream1);
            stream1.Close();

            Console.WriteLine("\nFrom file: ");
            Console.WriteLine(group3);
            Console.WriteLine(group4);




            Console.ReadKey();
        }
    }
}