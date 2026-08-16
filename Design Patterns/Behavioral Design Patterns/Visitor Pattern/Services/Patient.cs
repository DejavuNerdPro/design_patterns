
namespace Design_Patterns.Behavioral_Design_Patterns.Visitor_Pattern.Services
{
    public class Patient : IEmployee
    {
        public string Name {  get; set; }
        public string Id { get; set; }

        public Patient(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
