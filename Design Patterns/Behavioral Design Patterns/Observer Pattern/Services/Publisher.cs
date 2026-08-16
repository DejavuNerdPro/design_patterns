

namespace Design_Patterns.Behavioral_Design_Patterns.Observer_Pattern.Services
{
    public class Publisher : IPublisher
    {
        private List<IObserver> observers = new List<IObserver>();
        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnSubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Upload(string context)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(context);
            }
        }
    }
}
