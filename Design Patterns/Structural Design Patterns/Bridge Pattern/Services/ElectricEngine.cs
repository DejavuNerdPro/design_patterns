

namespace Design_Patterns.Structural_Design_Patterns.Bridge_Pattern.Services
{
    public class ElectricEngine : Engine
    {
        public override void start()
        {
            Console.WriteLine("Electric Engine started.");
        }
    }
}
