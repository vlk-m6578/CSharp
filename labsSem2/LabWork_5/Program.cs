using System;

namespace lab5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("5", "1", "6", "Для заданной предметной области спроектировать программную структуру, состоящую из 3-5 классов. Предметная область: Отдел расчета зарплаты", "Лебедева Милана", "353504");
            menu.ShowMenu();


            PayrollDepartment department = new PayrollDepartment();

            //виды работы
            department.SetSalaryOfProgrammer(500);
            department.SetSalaryOfDesigner(400);
            department.SetSalaryOfTester(300);

            Employee employee1 = new Employee("Bob");
            employee1.AddWorkType(Profession.Programmer);
            employee1.AddWorkType(Profession.Tester);
            department.Employees.Add(employee1);

            Employee employee2 = new Employee("Alice");
            employee2.AddWorkType(Profession.Designer);
            department.Employees.Add(employee2);


            //зарплата сотрудников
            decimal employee1Salary = department.CalculateEmployeeSalary(employee1);
            Console.WriteLine("Сотрудник " + employee1.Name);
            Console.WriteLine("Виды работы: " + string.Join(", ", employee1.GetWorkTypes()));
            Console.WriteLine("Зарплата: " + employee1Salary);

            decimal employee2Salary = department.CalculateEmployeeSalary(employee2);
            Console.WriteLine("Сотрудник " + employee2.Name);
            Console.WriteLine("Виды работы: "+ string.Join(", ", employee2.GetWorkTypes()));
            Console.WriteLine("Зарплата: "+employee2Salary);


            //общая зарплата
            decimal totalSalary = department.CalculateTotalSalary(department.Employees);
            Console.WriteLine("Общая зарплата: " + totalSalary);

            //поиск
            Console.WriteLine("Введите имя сотрудника для поиска в списке:");
            string searchName = Console.ReadLine();
            Employee findEmployee = department.SearchEmployee(searchName);
            if(findEmployee!=null)
            {
                Console.WriteLine("Сотрудник " + findEmployee.Name);
                Console.WriteLine("Виды работы: " + string.Join(", ", findEmployee.GetWorkTypes()));
                Console.WriteLine("Зарплата: " + department.CalculateEmployeeSalary(findEmployee));
            }
            else
            {
                Console.WriteLine("Сотрудник не найден!");
            }

            Console.WriteLine("\n\n");
            
        }
    }
}
