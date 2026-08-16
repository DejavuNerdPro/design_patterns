
namespace Design_Patterns.Behavioral_Design_Patterns.Observer_Pattern.Services
{
    public class Observer : IObserver
    {
        public string channel { get; set; }
        public void Update(string context)
        {
            Console.WriteLine($"{channel} - New Post : {context} has been uploaded.");
        }
    }
}
