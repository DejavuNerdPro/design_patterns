

namespace Design_Patterns.Behavioral_Design_Patterns.Strategy_Pattern.Services
{
    public class VisaStrategy : IStrategy
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"Visa Payment : {amount} MMK.");
        }
    }
}
