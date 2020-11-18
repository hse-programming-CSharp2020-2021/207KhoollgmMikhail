using System;
using System.Collections.Generic;

namespace Salary
{
    public class Employee
    {
        private string name;
        protected decimal basepay;

        public Employee(string name, decimal basepay)
        {
            this.name = name;
            this.basepay = basepay;
        }

        public virtual decimal CalculatePay()
        {
            return basepay;
        }

        public override string ToString()
        {
            return $"Имя = {name}, зарплата = {CalculatePay(),6:F3}";
        }
    }

    public class SalesEmployee : Employee
    {
        private decimal salesbonus;

        public SalesEmployee(string name, decimal basepay,
                  decimal salesbonus) : base(name, basepay)
        {
            this.salesbonus = salesbonus;
        }

        public override decimal CalculatePay()
        {
            return basepay + salesbonus;
        }


        public override string ToString()
        {
            return base.ToString() + $", бонус = {salesbonus,6:F3}";
        }

    }

    public class PartTimeEmployee : Employee
    {
        private int workingDays;

        public PartTimeEmployee(string name, decimal basepay,
                  int workingDays) : base(name, basepay)
        {
            this.workingDays = workingDays;
        }

        public override decimal CalculatePay()
        {
            return basepay * ((decimal)workingDays / 25);
        }

        public override string ToString()
        {
            return base.ToString() + $", рабочие дни = {workingDays,2}";
        }
    }

    public class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee p1, Employee p2)
        {
            if (p1.CalculatePay() > p2.CalculatePay())
                return -1;
            else if (p1.CalculatePay() < p2.CalculatePay())
                return 1;
            else
                return 0;
        }
    }
}
