

namespace Design_Patterns.Structural_Design_Patterns.Bridge_Pattern.Services
{
    public abstract class Car
    {
        protected readonly Engine _engine;
        public Car(Engine engine)
        {
            _engine = engine;
        }
        public abstract void drive();
        public virtual void getEngine() => _engine.start();
    }
}
