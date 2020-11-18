using System;
using Salary;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Employee[] employees =
            {
                new SalesEmployee("Ben", 5000, 300),
                new PartTimeEmployee("George", 4000, 20),
                new SalesEmployee("John", 7200, 400),
                new PartTimeEmployee("Robert", 5700, 15),
                new PartTimeEmployee("Chris", 8000, 30),
                new SalesEmployee("Dave", 10000, 1200)
            };

            Array.Sort(employees, new EmployeeComparer());

            string salesEmployees = "";
            string partTimeEmployees = "";

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].GetType().Name == "SalesEmployee") salesEmployees += employees[i].ToString() + "\n";
                else partTimeEmployees += employees[i].ToString() + "\n";
            }

            Console.WriteLine("SalesEmployees: ");
            Console.WriteLine(salesEmployees);


            Console.WriteLine("PartTimeEmployees: ");
            Console.WriteLine(partTimeEmployees);
        }
    }
}
