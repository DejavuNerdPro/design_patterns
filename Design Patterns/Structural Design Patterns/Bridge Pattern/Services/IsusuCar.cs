

namespace Design_Patterns.Structural_Design_Patterns.Bridge_Pattern.Services
{
    public class IsusuCar : Car
    {
        public IsusuCar(Engine engine) : base(engine)
        {
        }

        public override void drive()
        {
            Console.WriteLine("Isusu car is driving.");
        }
    }
}
