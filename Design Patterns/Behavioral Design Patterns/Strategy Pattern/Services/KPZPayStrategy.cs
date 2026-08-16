

namespace Design_Patterns.Behavioral_Design_Patterns.Strategy_Pattern.Services
{
    public class KPZPayStrategy : IStrategy
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"KPZ Pay Payment : {amount} MMK.");
        }
    }
}
