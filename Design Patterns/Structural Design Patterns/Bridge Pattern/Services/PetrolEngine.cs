

namespace Design_Patterns.Structural_Design_Patterns.Bridge_Pattern.Services
{
    public class PetrolEngine : Engine
    {
        public override void start()
        {
            Console.WriteLine("Petrol Engine started.");
        }
    }
}
