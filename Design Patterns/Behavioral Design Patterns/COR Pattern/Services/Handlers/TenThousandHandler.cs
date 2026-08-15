

namespace Design_Patterns.Behavioral_Design_Patterns.COR_Pattern.Services.Handlers
{
    public class TenThousandHandler : Handler
    {
        decimal currentIndex = 100;

        public override void Handle(decimal withrawAmount)
        {
            decimal index = withrawAmount / 10000;
            index = Math.Truncate(index);
            if(index > 0)
            {
                currentIndex -= index;
                Console.WriteLine("Withdraw : " + index * 10000);
                Console.WriteLine("Remaining : " + currentIndex * 10000);
            }

            if(next != null)
            {
                decimal amount = withrawAmount - (index * 10000);
                next.Handle(amount);
            }
        }
    }
}
