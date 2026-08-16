

namespace Design_Patterns.Behavioral_Design_Patterns.Visitor_Pattern.Services
{
    public class Nurse : IEmployee
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Nurse(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public void accept(IVisitor visitor) => visitor.visit(this);
        
    }
}
