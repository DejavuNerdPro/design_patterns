

namespace Design_Patterns.Structural_Design_Patterns.Bridge_Pattern.Services
{
    public class SedanCar : Car
    {
        public SedanCar(Engine engine) : base(engine)
        {
        }

        public override void drive()
        {
            Console.WriteLine("Sedan car is driving.");
        }
    }
}
