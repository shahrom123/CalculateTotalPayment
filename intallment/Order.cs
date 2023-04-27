

namespace intallment
{
    public class Order
    {
        public int id { get; set; }
        public string Product { get; set; }
        public decimal Amount { get; set; }
        public string PhoneNumber { get; set; }
        public int InstallmentDuration { get; set; }

        public Order() { }
        
      public decimal CalculateTotalPayment(string product, decimal amount, string phoneNumber,int installmentDuration)
        {
            decimal TotalAmount = amount;

           if(product == "Смартфон")
            {
                if(installmentDuration > 9)
                {
                    TotalAmount+=(TotalAmount * 0.03m);
                }
            }
           else if(product == "Компьютер")
            {
                if(installmentDuration > 12)
                {
                    TotalAmount+= (TotalAmount * 0.04m); 
                }
            }
           else if(product == "Телевизор")
            {
                if(installmentDuration > 18)
                {
                    TotalAmount+= (TotalAmount * 0.05m);

                }
            }
            SendSMS(phoneNumber,
                $"Вы приобрели {product} на сумму {TotalAmount} сомони в рассрочку на {installmentDuration} месяцев." +"\n" +
                $"Общая сумма платежа {TotalAmount} сомони ");

           return TotalAmount;            
   }

        public void SendSMS(string phoneNumber, string message)
        {

            Console.WriteLine($"Отправлено СМС на номер {phoneNumber}:");
            Console.WriteLine(message);
        }

}
}
