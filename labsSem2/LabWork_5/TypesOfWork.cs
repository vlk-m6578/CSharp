using System.Collections.Generic;

namespace lab5._1
{
    internal class TypesOfWork
    {
        private Dictionary<Profession, decimal> workTypePayment;
        public TypesOfWork()
        {
            workTypePayment = new Dictionary<Profession, decimal>();
        }

        public Dictionary<Profession, decimal> GetWorkTypePayment()
        {
            return workTypePayment;

        }
        public decimal GetPayment(Profession workType)
        {
            return workTypePayment[workType];
        }
    }
}
