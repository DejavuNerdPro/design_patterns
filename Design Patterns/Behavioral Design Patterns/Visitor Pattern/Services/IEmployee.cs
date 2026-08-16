

namespace Design_Patterns.Behavioral_Design_Patterns.Visitor_Pattern.Services
{
    public interface IEmployee
    {
        public void accept(IVisitor visitor);
    }
}
