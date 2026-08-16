

namespace Design_Patterns.Behavioral_Design_Patterns.Strategy_Pattern.Services
{
    public class WavePayStrategy : IStrategy
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"Wave Pay Payment : {amount} MMK.");
        }
    }
}
