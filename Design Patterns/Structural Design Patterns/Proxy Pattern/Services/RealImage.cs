

namespace Design_Patterns.Structural_Design_Patterns.Proxy_Pattern.Services
{
    public class RealImage : IImage
    {
        public string Name {  get; set; }
        public string data{  get; set; }
        public void display()
        {
            Console.WriteLine($"{Name} is loading.");
        }
    }
}
