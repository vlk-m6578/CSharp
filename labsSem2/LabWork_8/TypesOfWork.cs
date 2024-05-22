namespace lab8
{
    internal class TypesOfWork
    {
        //поля
        private IPayment iPayment;

        //свойства
        private string type;

        //методы
        public TypesOfWork(string type, IPayment iPayment) 
        {
            this.type = type;
            this.iPayment = iPayment;
        }
        public new string GetType()
        {
            return type;
        }
        public IPayment GetIPayment()
        {
            return iPayment;
        }
        public decimal GetPayment()
        {
            return iPayment.GetPayment();
        }
    }
}
