

namespace Design_Patterns.Behavioral_Design_Patterns.Strategy_Pattern.Services
{
    public class MPUStrategy : IStrategy
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"MPU Payment : {amount} MMK.");
        }
    }
}
