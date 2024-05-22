using System.Collections.Generic;

namespace lab5._1
{
    internal class Employee
    {
        private string name;
        private List<Profession> workTypes;

        public Employee(string name)
        {
            this.name = name;
            workTypes = new List<Profession>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddWorkType(Profession workType)
        {
            workTypes.Add(workType);
        }

        public List<Profession> GetWorkTypes()
        {
            return workTypes;
        }
    }
}
