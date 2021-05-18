using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = new XElement("city", "Seattle");



            var customer1 = new XElement("customer", city);

            var customer2 = new XElement("customer", city);



            city.SetValue("London");

            Console.WriteLine(customer2.Element("city").Value);
        }
    }
}
