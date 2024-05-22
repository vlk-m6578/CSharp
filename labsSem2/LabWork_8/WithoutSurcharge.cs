namespace lab8
{
    internal class WithoutSurcharge : IPayment
    {
        //поля
        private decimal payment;

        //методы
        public WithoutSurcharge(decimal payment)
        {
            this.payment = payment;
        }
        public decimal GetPayment()
        {
            return payment;
        }
    }
}
