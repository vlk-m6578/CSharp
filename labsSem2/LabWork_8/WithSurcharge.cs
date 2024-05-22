namespace lab8
{
    internal class WithSurcharge : IPayment
    {
        //поля
        private decimal payment;
        private int surcharge;

        //методы
        public WithSurcharge(int surcharge, decimal payment)
        {
            this.surcharge = surcharge;
            this.payment = payment;
        }
        public decimal GetPayment()
        {
            return payment + payment * ((decimal)surcharge / 100);
        }
        
    }
}
