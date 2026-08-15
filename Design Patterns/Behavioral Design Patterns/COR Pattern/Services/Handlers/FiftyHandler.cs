

namespace Design_Patterns.Behavioral_Design_Patterns.COR_Pattern.Services.Handlers
{
    public class FiftyHandler : Handler
    {
        decimal currentIndex = 100;
        public override void Handle(decimal withdrawAmount)
        {
            decimal index = withdrawAmount / 50;
            index = Math.Truncate(index);
            if (index > 0)
            {
                currentIndex -= index;
                Console.WriteLine("Withdraw : " + index * 50);
                Console.WriteLine("Remainng amount : " + currentIndex * 50);
            }


            if (next != null)
            {
                decimal amount = withdrawAmount - (index * 50);
                next.Handle(amount);
            }
        }
    }
}
