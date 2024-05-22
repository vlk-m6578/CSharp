using System;

namespace lab4
{
    internal class HRDepartment
    {
        //Поля
        private static HRDepartment instance;
        private string nameCompany;
        private int countEmployees;
        private ProductionRate productionRate;
        private double payForHour;
        private int tax;

        //Cвойства 
        public string GetNameCompany() // public string GetNameCompany() => nameCompany;
        {
            return nameCompany;
        }
        public void SetNameCompany(string name)
        {
            nameCompany = name;
        }
        public int GetCountEmployees()
        {
            return countEmployees;
        }
        public void SetEmployees(int count)
        {
            countEmployees = count;
        }
        public double GetPayForHour()
        {
            return payForHour;
        }
        public void SetPayForHour(double pay)
        {
            payForHour = pay;
        }
        public int GetTax()
        {
            return tax;
        }
        public int SetTax(int currentTax)
        {
            return tax = currentTax;
        }
        //Методы
        private HRDepartment()
        {
            productionRate = new ProductionRate();
        }
        public static HRDepartment GetInstance()
        {
            if (instance == null)
            {
                instance = new HRDepartment();
            }
            return instance;
        }

        public void SetProdictionRate(int hours)
        {
            productionRate.SetHoursPerMonth(hours);
        }
        public int GetProductionRate()
        {
            return productionRate.GetHoursPerMonth();
        }
        public void IncreaseProductionRate(int hours)
        {
            int startHours = productionRate.GetHoursPerMonth();
            productionRate.SetHoursPerMonth(startHours+hours);
        }
        public void IncreaseProductionRate(ProductionRate productionRate, int hours)
        {
            int startHours = productionRate.GetHoursPerMonth();
            productionRate.SetHoursPerMonth(startHours + hours);
        }
        public void DecreaseProductionRate(int hours)
        {
            int startHours = productionRate.GetHoursPerMonth();
            int newHours = startHours - hours;
            if (newHours < 0)
            {
                newHours = 0;
            }
            productionRate.SetHoursPerMonth(newHours);
        }
        public void DecreaseProductionRate(ProductionRate productionRate, int hours)
        {
            int startHours = productionRate.GetHoursPerMonth();
            int newHours = startHours - hours;
            if (newHours < 0)
            {
                newHours = 0;
            }
            productionRate.SetHoursPerMonth(newHours);
        }
        public double CalculateTax()
        {
            double totalPayment = payForHour * (double)(productionRate.GetHoursPerMonth()) * (double)countEmployees;
            double totalTax = totalPayment * ((double)tax/100);
            return totalTax;
        }
    
    }
}