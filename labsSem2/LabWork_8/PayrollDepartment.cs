using System.Collections.Generic;

namespace lab8
{
    internal class PayrollDepartment
    {
        //поля
        private List<TypesOfWork> typeOfWork = new List<TypesOfWork>();

        //методы
        public List<TypesOfWork> GetTypesOfWork()
        {
            return typeOfWork;
        }
        public void AddTypeWithSurcharge(string type, int surcharge, decimal payment)
        {
            IPayment paymentStrategy = new WithSurcharge(surcharge, payment);
            typeOfWork.Add(new TypesOfWork(type, paymentStrategy));
        }
        public void AddTypeWithoutSurcharge(string type, decimal payment)
        {
            IPayment paymentStrategy = new WithoutSurcharge(payment);
            typeOfWork.Add(new TypesOfWork(type, paymentStrategy));
        }
        public decimal GetAveragePayment()
        {
            decimal totalPayment = 0;
            decimal payment;
            foreach(TypesOfWork type in typeOfWork) 
            {
                if(type.GetIPayment() is WithSurcharge withSurcharge)
                {
                    payment = withSurcharge.GetPayment();
                }
                else
                {
                    payment = type.GetPayment();
                }
                totalPayment += payment;
            }
            decimal averagePayment = totalPayment / typeOfWork.Count;
            return averagePayment;
        }

    }
}
