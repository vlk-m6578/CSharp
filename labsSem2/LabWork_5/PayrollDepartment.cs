using System;
using System.Collections.Generic;

namespace lab5._1
{
    internal class PayrollDepartment
    {
        private List<Employee> employees;
        private TypesOfWork works;

        public void SetSalaryOfProgrammer(decimal salary)
        {
            Dictionary <Profession, decimal> workTypePayment = works.GetWorkTypePayment();
            workTypePayment[Profession.Programmer] = salary;
        }

        public void SetSalaryOfDesigner(decimal salary)
        {
            Dictionary<Profession, decimal> workTypePayment = works.GetWorkTypePayment();
            workTypePayment[Profession.Designer] = salary;
        }

        public void SetSalaryOfTester(decimal salary)
        {
            Dictionary<Profession, decimal> workTypePayment = works.GetWorkTypePayment();
            workTypePayment[Profession.Tester] = salary;
        }

        public PayrollDepartment()
        {
            employees = new List<Employee>();
            works = new TypesOfWork();
        }

        public List<Employee> Employees
        {
            get { return employees; }
        }

        //internal Employee Employee
        //{
        //    get => default;
        //    set
        //    {
        //    }
        //}

        public decimal CalculateEmployeeSalary(Employee employee)
        {
            decimal employeeSalary = 0;

            foreach (Profession workType in employee.GetWorkTypes())
            {
                employeeSalary += works.GetPayment(workType);
            }

            return employeeSalary;
        }

        public decimal CalculateTotalSalary(List<Employee> employees)
        {
            decimal totalSalary = 0;

            foreach (Employee employee in employees)
            {
                totalSalary += CalculateEmployeeSalary(employee);
            }
            return totalSalary;
        }
        public Employee SearchEmployee(string name)
        {
            Employee findEmployee = null;
            foreach(Employee employee in employees)
            {
                if(employee.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    findEmployee = employee;
                    break;
                }
            }
            return findEmployee;
        }
    }
}

