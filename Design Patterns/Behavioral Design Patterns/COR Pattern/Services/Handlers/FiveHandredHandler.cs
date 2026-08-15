

namespace Design_Patterns.Behavioral_Design_Patterns.COR_Pattern.Services.Handlers
{
    public class FiveHandredHandler : Handler
    {
        decimal currentIndex = 100;
        public override void Handle(decimal withdrawAmount)
        {
            decimal index = withdrawAmount / 500;
            index = Math.Truncate(index);
            if (index > 0)
            {
                currentIndex -= index;
                Console.WriteLine("Withdraw : " + index * 500);
                Console.WriteLine("Remainng amount : " + currentIndex * 500);
            }


            if (next != null)
            {
                decimal amount = withdrawAmount - (index * 500);
                next.Handle(amount);
            }
        }
    }
}
