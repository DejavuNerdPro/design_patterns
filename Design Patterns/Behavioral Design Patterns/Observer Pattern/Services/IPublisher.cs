
namespace Design_Patterns.Behavioral_Design_Patterns.Observer_Pattern.Services
{
    public interface IPublisher
    {
        public void Subscribe(IObserver observer);
        public void UnSubscribe(IObserver observer);
        public void Upload(string context);
    }
}
