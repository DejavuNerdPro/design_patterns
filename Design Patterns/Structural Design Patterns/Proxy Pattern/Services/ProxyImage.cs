

namespace Design_Patterns.Structural_Design_Patterns.Proxy_Pattern.Services
{
    public class ProxyImage : IImage
    {
        private RealImage? image;
        public void display()
        {
            if (image is null)
            {
                image = new();
                image.Name = "New_image_97867";
            }

            image.display();
        }
    }
}
