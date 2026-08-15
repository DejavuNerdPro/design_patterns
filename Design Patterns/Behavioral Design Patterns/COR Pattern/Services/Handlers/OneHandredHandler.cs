

namespace Design_Patterns.Behavioral_Design_Patterns.COR_Pattern.Services.Handlers
{
    public class OneHandredHandler : Handler
    {
        decimal currentIndex = 100;
        public override void Handle(decimal withdrawAmount)
        {
            decimal index = withdrawAmount / 100;
            if (index > 0)
            {
                currentIndex -= index;
                Console.WriteLine("Withdraw : " + index * 100);
                Console.WriteLine("Remainng amount : " + currentIndex * 100);
            }


            if (next != null)
            {
                decimal amount = withdrawAmount - (index * 100);
                next.Handle(amount);
            }
        }
    }
}
