
namespace Design_Patterns.Structural_Design_Patterns.Bridge_Pattern.Services
{
    public class CabrioletCar : Car
    {
        public CabrioletCar(Engine engine) : base(engine)
        {
        }

        public override void drive()
        {
            Console.WriteLine("Cabriolet car is driving.");
        }
    }
}
