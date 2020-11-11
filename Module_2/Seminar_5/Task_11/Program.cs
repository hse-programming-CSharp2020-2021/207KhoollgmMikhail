using System;
/*
 Реализовать класс, представляющий сведения о человеке Person.
Реализовать свойства: Ф.И.О.(string FullName), дата рождения (DateTime BirthDate), пол (bool IsMale).
Реализовать метод для вывода информации о человеке void ShowInfo().
Реализовать класс, представляющий сведения о студенте Student (наследуется от Person).
Реализовать свойства: название ВУЗа (string Institute), специальность (string Speciality).
Реализовать класс, представляющий сведения о сотруднике фирмы Employee (наследуется от Person).
Реализовать свойства: название компании (string CompanyName), должность (string Post), график (string Schedule),
оклад (decimal Salary).
 
В основной программе решить задачи:
- Создать  объекты всех трех типов и вызвать ShowInfo(), чтобы показать всю доступную информацию.
- Создать массив Person[] arr и присвоить его членам объекты всех трех типов. Продемонстрировать работу метода ShowInfo() на массиве. 
 */

class Person
{
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsMale { get; set; }

    public Person(string f, DateTime d, bool m)
    {
        FullName = f;
        BirthDate = d;
        IsMale = m;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"{FullName} {BirthDate} {IsMale}");
    }
}

class Student : Person
{
    public string Institute { get; set; }
    public string Speciality { get; set; }

    public Student(string f, DateTime d, bool m, string inst, string spec) : base(f, d, m)
    {
        Institute = inst;
        Speciality = spec;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"{FullName} {BirthDate} {IsMale} {Institute} {Speciality}");
    }
}

class Employee : Student
{
    public string CompanyName { get; set; }

    public string Post { get; set; }

    public string Shedule { get; set; }

    public decimal Salary { get; set; }

    public Employee(string f, DateTime d, bool m, string inst, string spec,
        string comp, string post, string shed, decimal sal) : base(f, d, m, inst, spec)
    {
        CompanyName = comp;
        Post = post;
        Shedule = shed;
        Salary = sal;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"{FullName} {BirthDate} {IsMale} {Institute} {Speciality} {CompanyName} {Post} {Shedule} {Salary}");
    }
}

class Program
{
    static void Main()
    {
        //Person person = new Person("Oleg", new DateTime(2000, 10, 10), true);
        //Student student = new Student("Taras", new DateTime(2010, 5, 5), true, "HSE", "ФКН ПИ");
        //Employee employee = new Employee("Michael", new DateTime(2007, 2, 17), true, "HSE", "ФКН ПИ", "Apple", "CEO", "24/7", 100000);
        //person.ShowInfo();
        //student.ShowInfo();
        //employee.ShowInfo();

        Person[] people = new Person[3];
        people[0] = new Person("Oleg", new DateTime(2000, 10, 10), true);
        people[1] = new Student("Taras", new DateTime(2010, 5, 5), true, "HSE", "ФКН ПИ");
        people[2] = new Employee("Michael", new DateTime(2007, 2, 17), true, "HSE", "ФКН ПИ", "Apple", "CEO", "24/7", 100000);

        foreach(Person a in people)
        {
            a.ShowInfo();
        }
    }
}