

namespace Design_Patterns.Structural_Design_Patterns.Flyweight_Pattern.Services
{
    public class AsteroidFlyweight
    {
        public string name { get; set; }
        public int lenght {  get; set; }
        public int weight {  get; set; }
        public string color { get; set; }
        public decimal speed { get; set; }

        //--- its position (x,y) can vary everytime - extrinstic state
        public AsteroidPosition position { get; set; }
    }
}
