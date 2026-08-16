

namespace Design_Patterns.Behavioral_Design_Patterns.Strategy_Pattern.Services
{
    public class PaymentMethod
    {
        public decimal amount {  get; set; }
        public void setPaymentMethod(IStrategy paymentMethod)
        {
            paymentMethod.pay(amount);
        }
    }
}
