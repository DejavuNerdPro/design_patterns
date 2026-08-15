

namespace Design_Patterns.Behavioral_Design_Patterns.COR_Pattern.Services.Handlers
{
    public class FiveThousandHandler : Handler
    {
        decimal currentIndex = 100;
        public override void Handle(decimal withdrawAmount)
        {
            decimal index = withdrawAmount / 5000;
            if (index > 0)
            {
                currentIndex -= index;
                Console.WriteLine("Withdraw : " + index * 5000);
                Console.WriteLine("Remainng amount : " + currentIndex * 5000);
            }


            if (next != null)
            {
                decimal amount = withdrawAmount - (index * 5000);
                next.Handle(amount);
            }
        }
    }
}
